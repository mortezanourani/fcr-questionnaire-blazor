using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FCR.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Questionnaire> Questionnaires { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<LikertOption> LikertOptions { get; set; }
     
        public DbSet<Participant> Participants { get; set; }

        public DbSet<Response> Responses { get; set; }
    }
}
