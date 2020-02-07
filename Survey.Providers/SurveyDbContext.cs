using System;
using Microsoft.EntityFrameworkCore;
using Survey.Concerns;
namespace Survey.Providers
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<SurveyForm> SurveyForms { get; set; } 

        public DbSet<SurveyData> SurveyData { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<SurveyOption> SurveyOptions { get; set; }
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options){   }
        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
