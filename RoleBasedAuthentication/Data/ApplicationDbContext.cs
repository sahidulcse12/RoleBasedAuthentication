using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoleBasedAuthentication.Models.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RoleBasedAuthentication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
            .HasOne(u => u.Staff)
            .WithOne(t => t.ApplicationUser)
            .HasForeignKey<Staff>(b=>b.ApplicationUserId)
            .IsRequired(false);

            SeedRoles(builder);
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole<Guid>>().HasData
                (
                 new IdentityRole<Guid>() { Id = Guid.NewGuid(), Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                 new IdentityRole<Guid>() { Id = Guid.NewGuid(), Name = "Manager", ConcurrencyStamp = "3", NormalizedName = "Manager" },
                 new IdentityRole<Guid>() { Id = Guid.NewGuid(), Name = "Staff", ConcurrencyStamp = "2", NormalizedName = "Staff" },
                 new IdentityRole<Guid>() { Id = Guid.NewGuid(), Name = "User", ConcurrencyStamp = "4", NormalizedName = "User" }
                );
        }
    }
}
