using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using run4cause.Models;

namespace run4cause.Data
{
    public class Run4causeContext : DbContext
    {
        public Run4causeContext(DbContextOptions<Run4causeContext> options) : base(options) { }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<IdentityUserClaim<int>> UserClaims { get; set; }
        public virtual DbSet<Run> Runs { get; set; }
        public virtual DbSet<Edition> Editions { get; set; }
        public virtual DbSet<Waypoint> Waypoints { get; set; }
        public virtual DbSet<Sponsorship> Sponsorships { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<RunWaypoint> RunWaypoints { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            this.SeedRoles(modelBuilder);
            this.SeedUsers(modelBuilder);
        }

        protected void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role() { Id = ((int)Constants.Roles.Admin), Name = "Admin" });
            modelBuilder.Entity<Role>().HasData(new Role { Id = ((int)Constants.Roles.Moderator), Name = "Moderator" });
            modelBuilder.Entity<Role>().HasData(new Role { Id = ((int)Constants.Roles.Runner), Name = "Runner" });
        }
        protected void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Id = 1, FirstName = "Run4", LastName = "admin", UserName = "default_admin" });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, FirstName = "Run4", LastName = "moderator", UserName = "default_moderator" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, FirstName = "Run4", LastName = "runner", UserName = "default_Runner" });

            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 1, UserId = 1, RoleId = (int)Constants.Roles.Admin });
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 2, UserId = 2, RoleId = (int)Constants.Roles.Moderator });
            modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = 3, UserId = 3, RoleId = (int)Constants.Roles.Runner });
        }
    }
}