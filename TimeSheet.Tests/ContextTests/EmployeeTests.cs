using System;
using TimeSheet.DAL.EF;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TimeSheet.Models.Entities;

namespace TimeSheet.Test.ContextTests
{
    [Collection("TimeSheet.DAL")]
    public class EmployeeTests : IDisposable
    {
        private readonly TimeSheetContext _db;
        public EmployeeTests()
        {
            _db = new TimeSheetContext();
            //    CleanDatabase();
        }
        public void Dispose()
        {
            //  CleanDatabase();   
            _db.Dispose();
        }

        // private void CleanDatabase()
        // {
        //  _db.Database.ExecuteSqlCommand("Delete from TimeSheet.Employees");
        //    _db.Database.ExecuteSqlCommand($"DBCC CHECKIDENT (\"TimeSheet.Employees\", RESEED, -1);");
        //  }

        [Fact]
        public void FirstTest()
        {
            Assert.True(true);
        }
    }
   
}