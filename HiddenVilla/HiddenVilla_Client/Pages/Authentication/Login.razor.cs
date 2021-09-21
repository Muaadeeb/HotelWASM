using HiddenVilla_Client.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Pages.Authentication
{
    public partial class Login
    {
        private AuthenticationDTO userForAuthentication = new AuthenticationDTO();
        public bool IsProcessing { get; set; } = false;
        public bool ShowAuthenticationErrors { get; set; }
        public string Errors { get; set; }
        public string ReturnUrl { get; set; }

        [Inject]
        public IAuthenticationService _authenticationService { get; set; }

        [Inject]
        public NavigationManager _navigationManager { get; set; }


        private async Task LoginUser()
        {
            ShowAuthenticationErrors = false;
            IsProcessing = true;
            var result = await _authenticationService.LoginAsync(userForAuthentication);
            if (result.IsAuthSuccessful)
            {
                IsProcessing = false;
                var absoluteUri = new Uri(_navigationManager.Uri);
                var queryParam = System.Web.HttpUtility.ParseQueryString(absoluteUri.Query);
                ReturnUrl = queryParam["returnUrl"];
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    _navigationManager.NavigateTo("/");
                }
                else
                {
                    _navigationManager.NavigateTo("/" + ReturnUrl);
                }


                //_navigationManager.NavigateTo("/login");
            }
            else
            {
                IsProcessing = false;
                Errors = result.ErrorMessage;
                ShowAuthenticationErrors = true;
            }
        }
    }
}
