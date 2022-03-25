using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineCosmeticSalon.Infrastructure.Data.Models;

namespace OnlineCosmeticSalon.Infrastucture.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Service> Services { get; set; }

        public DbSet<Salon> Salons { get; set; }

        public DbSet<SalonService> SalonServices { get; set; }

        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<ApplicationRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            builder.Entity<Appointment>()
               .HasOne(a => a.User)
               .WithMany(u => u.Appointments)
               .HasForeignKey(a => a.UserId);

            builder.Entity<Appointment>()
                .HasOne(a => a.Salon)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.SalonId);

            builder.Entity<Appointment>()
                .HasOne(a => a.Service)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.ServiceId);

            builder.Entity<Appointment>()
                 .HasOne(a => a.SalonService)
                .WithMany(ss => ss.Appointments)
                .HasForeignKey(a => new { a.SalonId, a.ServiceId });

            builder.Entity<SalonService>().HasKey(ss => new { ss.SalonId, ss.ServiceId });
        }
    }
}