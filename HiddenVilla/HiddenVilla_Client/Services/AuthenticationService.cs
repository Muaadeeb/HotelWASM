using Blazored.LocalStorage;
using Common;
using HiddenVilla_Client.Services.Interfaces;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;

        public AuthenticationService(HttpClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

        public async Task<AuthenticationResponseDTO> LoginAsync(AuthenticationDTO userFromAuthentication)
        {
            JsonContent content = JsonContent.Create(userFromAuthentication);
            var response = await _client.PostAsync("api/account/signin", content);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AuthenticationResponseDTO>(contentTemp);

            if (response.IsSuccessStatusCode)
            {
                await _localStorage.SetItemAsync(StaticDetails.Local_Token, result.Token);
                await _localStorage.SetItemAsync(StaticDetails.Local_UserDetails, result.UserDTO);
                _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", result.Token);
                return new AuthenticationResponseDTO { IsAuthSuccessful = true };
            }
            else
            {
                return result;
            }
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync(StaticDetails.Local_Token);
            await _localStorage.RemoveItemAsync(StaticDetails.Local_UserDetails);
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegistrationResponseDTO> RegisterUserAsync(UserRequestDTO userForRegistration)
        {
            JsonContent content = JsonContent.Create(userForRegistration);
            var response = await _client.PostAsync("api/account/signup", content);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RegistrationResponseDTO>(contentTemp);

            if (response.IsSuccessStatusCode)
            {
                return new RegistrationResponseDTO { IsRegistrationSuccessful = true };
            }
            else
            {
                return result;
            }

        }
    }
}
