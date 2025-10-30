using FCR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FCR.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Questionnaire> Questionnaires { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Scale> Scales { get; set; }

        public DbSet<Option> Options { get; set; }
     
        public DbSet<Participant> Participants { get; set; }

        public DbSet<Response> Responses { get; set; }
    }
}
