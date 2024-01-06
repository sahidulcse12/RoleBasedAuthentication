using Microsoft.AspNetCore.Identity;
using RoleBasedAuthentication.Models.Authentication;

namespace RoleBasedAuthentication.Data;

public class ApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public Guid StaffId { get; set; } = default!;
    public virtual Staff? Staff { get; set; }
}
