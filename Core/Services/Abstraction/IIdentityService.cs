using Core.Contacts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IIdentityService
    {
        Task<AuthResult> LoginAsync(string Email, string Password);
        Task<AuthResult> RegistrationAsync(string Email, string Password);
        Task<AuthResult> LoginWithFacebookAsync(string accessToken);
        Task SignOutAsync();

    }
}
