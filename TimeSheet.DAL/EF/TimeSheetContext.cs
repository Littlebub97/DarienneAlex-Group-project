using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TimeSheet.Models.Entities;


namespace TimeSheet.DAL.EF
{
  public class TimeSheetContext : DbContext
    {
        public TimeSheetContext()
        {

        }

        public TimeSheetContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                     @"Server=(localdb)\mssqllocaldb;Database=TimeSheet;Trusted_Connection=True;MultipleActiveResultSets=true;",
                    options => options.EnableRetryOnFailure());
            }
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Timesheet> TimeSheets { get; set; }
    }
}
