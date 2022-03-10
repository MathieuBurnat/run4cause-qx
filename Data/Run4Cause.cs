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
        public virtual DbSet<UserClaim> UserClaims { get; set; }
        public virtual DbSet<Run> Runs { get; set; }
        public virtual DbSet<Edition> Editions { get; set; }
        public virtual DbSet<Waypoint> Waypoints { get; set; }
        public virtual DbSet<Sponsorship> Sponsorships { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<RunWaypoint> RunWaypoints { get; set; }

    }
}