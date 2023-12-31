using RoleBasedAuthentication.Models.Authentication.UserRole;
using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthentication.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        public required string Username { get; set; } = string.Empty;

        public required string Email { get; set; } = string.Empty;

        public required string Password { get; set; } = string.Empty;
        public required UserRoles RoleType { get; set; } 

    }
}
