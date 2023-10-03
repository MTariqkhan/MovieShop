using System;
using MoviesManagement.Models.DTO;
using System.Net.NetworkInformation;

namespace MoviesManagement.Repositoriy
{
    public interface IUserAuthenticationService
    {

        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        //Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}

