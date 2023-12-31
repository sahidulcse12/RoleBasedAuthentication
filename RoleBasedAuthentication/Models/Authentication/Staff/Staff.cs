using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthentication.Models.Authentication.Staff
{
    public class Staff
    {
        [Key]

        public required string Username { get; set; } = string.Empty;

        public required string Email { get; set; } = string.Empty;

        public required string Password { get; set; } = string.Empty;
    }
}
