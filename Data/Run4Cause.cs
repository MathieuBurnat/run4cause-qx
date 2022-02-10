using Microsoft.EntityFrameworkCore;
using run4cause.Models;

namespace run4cause.Data
{
    public class Run4causeContext : DbContext
    {
        public Run4causeContext(DbContextOptions<Run4causeContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
    }
}