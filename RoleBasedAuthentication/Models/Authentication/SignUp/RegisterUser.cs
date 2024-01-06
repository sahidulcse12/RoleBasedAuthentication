using RoleBasedAuthentication.Models.Authentication.UserRole;
using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthentication.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        public required string FirstName { get; set; } = default!;

        public required string LastName { get; set; } = default!;

        public required string Email { get; set; } = default!;
        public required string Password { get; set; } = default!;
        public required UserRoles RoleType { get; set; } 

    }
}
