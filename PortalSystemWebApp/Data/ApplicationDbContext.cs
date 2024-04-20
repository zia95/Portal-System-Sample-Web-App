using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using PortalSystemWebApp.Model;

namespace PortalSystemWebApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgramClass>()
                .HasMany(e => e.EnrolledUsers)
                .WithMany(e => e.EnrolledPrograms);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<PortalSystemWebApp.Model.ProgramClass> ProgramClass { get; set; } = default!;
    }
}
