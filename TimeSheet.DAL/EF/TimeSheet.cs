using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TimeSheet.Models.Entities;

namespace TimeSheet.DAL.EF
{
  public class TimeSheet : DbContext
    {
        public TimeSheet()
        {

        }

        public TimeSheet(DbContextOptions options) : base(options)
        {

        }

        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                     @"Server=(localdb)\mssqllocaldb;Database=SpyStore;Trusted_Connection=True;MultipleActiveResultSets=true;",
                    options => options.EnableRetryOnFailure());)
            }
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
