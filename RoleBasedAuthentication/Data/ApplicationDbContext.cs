using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RoleBasedAuthentication.Models.Authentication;

namespace RoleBasedAuthentication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(b =>
            {
                b.Property(e => e.ConcurrencyStamp).HasColumnName("RoleId");
            });

            builder.Entity<ApplicationUser>()
            .HasOne(u => u.Staff)
            .WithOne(t => t.ApplicationUser)
            .HasForeignKey<Staff>(b=>b.UserId)
            .IsRequired(false);

            SeedRoles(builder);
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                 new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                 new IdentityRole() { Name = "Manager", ConcurrencyStamp = "3", NormalizedName = "Manager" },
                 new IdentityRole() { Name = "Staff", ConcurrencyStamp = "2", NormalizedName = "Staff" },
                 new IdentityRole() { Name = "User", ConcurrencyStamp = "4", NormalizedName = "User" }
                );
        }
    }
}
