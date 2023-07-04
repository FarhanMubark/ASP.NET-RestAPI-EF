using System;
using Microsoft.EntityFrameworkCore;
namespace DashboardAPI.Models
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        { }



            public DbSet<Question> Questions {get; set;}
            public DbSet<Participant> Participants { get; set; }
    }
}

