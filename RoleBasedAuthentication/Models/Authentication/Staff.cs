using RoleBasedAuthentication.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoleBasedAuthentication.Models.Authentication
{
    public class Staff
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId {  get; set; }
        public Guid BranchId { get; set; }
        public Guid RestaurantId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
