using RoleBasedAuthentication.Models.Authentication.UserRole;

namespace RoleBasedAuthentication.Models.Authentication.MobileUserSignUp
{
    public class User
    {
        public required string FirstName { get; set; } = default!;

        public required string LastName { get; set; } = default!;

        public required string Email { get; set; } = default!;
        public required string Password { get; set; } = default!;
        public string phone {  get; set; } = default!;
        //public required UserRoles RoleType { get; set; }
    }
}
