using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDTO> RegisterUserAsync(UserRequestDTO userForRegistration);

        Task<AuthenticationResponseDTO> LoginAsync(AuthenticationDTO userFromAuthentication);

        Task Logout();
    }
}
