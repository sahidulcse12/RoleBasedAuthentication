using Microsoft.AspNetCore.Identity;
using RoleBasedAuthentication.Models.Authentication;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoleBasedAuthentication.Data
{
    public class ApplicationUser : IdentityUser
    {
       public virtual Staff? Staff { get; set; }
    }
}
