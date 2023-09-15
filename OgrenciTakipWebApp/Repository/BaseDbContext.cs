using Microsoft.EntityFrameworkCore;
using OgrenciTakipWebApp.Models;

namespace OgrenciTakipWebApp.Repository
{
    
           public class BaseDbContext : DbContext
        {
            public BaseDbContext(DbContextOptions opt) : base(opt) { }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=StudentTakip; Trusted_Connection=true");
            }
            public DbSet<Student>Students { get; set; }




             


        }
    }
