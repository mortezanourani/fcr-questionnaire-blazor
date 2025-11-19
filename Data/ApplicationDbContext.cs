using FCR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FCR.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<GeneralInformation> GeneralInformation { get; set; }

        public DbSet<Questionnaire> Questionnaires { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Scale> Scales { get; set; }

        public DbSet<Option> Options { get; set; }
     
        public DbSet<Participant> Participants { get; set; }

        public DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<GeneralInformation>().HasData(
                new GeneralInformation
                {
                    Id = Guid.NewGuid(),
                    ApplicationTitle = string.Empty,
                    FirstPageDescription = string.Empty,
                    LastPageDescription = string.Empty,
                    GiftLink = string.Empty,
                }
            );
        }
    }
}
