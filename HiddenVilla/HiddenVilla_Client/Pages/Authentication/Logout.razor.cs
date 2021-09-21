using HiddenVilla_Client.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Pages.Authentication
{
    public partial class Logout
    {
        //private AuthenticationDTO userForAuthentication = new AuthenticationDTO();
        //public bool IsProcessing { get; set; } = false;
        //public bool ShowAuthenticationErrors { get; set; }
        //public string Errors { get; set; }
        //public string ReturnUrl { get; set; }

        [Inject]
        public IAuthenticationService _authenticationService { get; set; }

        [Inject]
        public NavigationManager _navigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await _authenticationService.Logout();
            _navigationManager.NavigateTo("/");
        }
    }
}
