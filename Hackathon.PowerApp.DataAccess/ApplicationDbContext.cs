using Hackathon.PowerApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.PowerApp.DataAccess
{
    public class ApplicationDbContext : DbContext // Add User Conext Here IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SampleEntity> Devices { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
