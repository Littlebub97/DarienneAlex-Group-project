using System;
using TimeSheet.DAL.EF;
using TimeSheet.Models.Enitites;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TimeSheet.Models.Entites;

namespace TimeSheet.Test.ContextTests
{
    [Collection("TimeSheet.DAL")]
    public class EmployeeTests : IDisposable
    {
        private readonly TimeSheetContext _db;
        public EmployeeTests()
        {
            _db = new TimeSheetContext();
            CleanDatabase();
        }
        public void Dispose()
        {
            CleanDatabase();
            _db.Dispose();
        }

        private void CleanDatabase()
        {
            _db.Database.ExecuteSqlCommand("Delete from TimeSheet.Employees");
            _db.Database.ExecuteSqlCommand($"DBCC CHECKIDENT (\"TimeSheet.Employees\", RESEED, -1);");
        }

        [Fact]
        public void FirstTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldAddEmployeeWithDbSet()
        {
            var employee = new Employee { EmployeeName = "Foo" };
            _db.Employees.Add(employee);
            Assert.Equal(EntityState.Added, _db.Entry(employee).State);
            Assert.True(employee.Id < 0);
            Assert.Null(employee.TimeStamp);
            _db.SaveChanges();
            Assert.Equal(EntityState.Unchanged, _db.Entry(employee).State);
            Assert.Equal(0, employee.Id);
            Assert.NotNull(employee.TimeStamp);
            Assert.Equal(1, _db.Employees.Count());
        }

        [Fact]
        public void ShouldGetAllEmployeesOrderedByName()
        {
            _db.Employees.Add(new Employee { EmployeeName = "Foo" });
            _db.Employees.Add(new Employee { EmployeeName = "Bar" });
            _db.SaveChanges();
            var Employees = _db.Employees.OrderBy(c => c.EmployeeName).ToList();
            Assert.Equal(2, _db.Employees.Count());
            Assert.Equal("Bar", Employees[0].EmployeeName);
            Assert.Equal("Foo", Employees[1].EmployeeName);
        }

        [Fact]
        public void ShouldUpdateAnEmployee()
        {
            var Employee = new Employee { EmployeeName = "Foo" };
            _db.Employees.Add(Employee);
            _db.SaveChanges();
            Employee.EmployeeName = "Bar";
            _db.Employees.Update(Employee);
            Assert.Equal(EntityState.Modified, _db.Entry(Employee).State);
            _db.SaveChanges();
            Assert.Equal(EntityState.Unchanged, _db.Entry(Employee).State);
            TimeSheetContext context;
            using (context = new TimeSheetContext())
            {
                Assert.Equal("Bar", context.Employees.First().EmployeeName);
            }
        }

        [Fact]
        public void ShouldNotUpdateANonAttachedEmployee()
        {
            var Employee = new Employee { EmployeeName = "Foo" };
            _db.Employees.Add(Employee);
            Employee.EmployeeName = "Bar";
            Assert.Throws<InvalidOperationException>(() => _db.Employees.Update(Employee));
        }

        [Fact]
        public void ShouldDeleteAnEmployee()
        {
            var Employee = new Employee { EmployeeName = "Foo" };
            _db.Employees.Add(Employee);
            _db.SaveChanges();
            Assert.Equal(1, _db.Employees.Count());
            _db.Employees.Remove(Employee);
            Assert.Equal(EntityState.Deleted, _db.Entry(Employee).State);
            _db.SaveChanges();
            Assert.Equal(EntityState.Detached, _db.Entry(Employee).State);
            Assert.Equal(0, _db.Employees.Count());
        }

        [Fact]
        public void ShouldDeleteAnEmployeeWithTimestampData()
        {
            var Employee = new Employee { EmployeeName = "Foo" };
            _db.Employees.Add(Employee);
            _db.SaveChanges();
            var context = new TimeSheetContext();
            var catToDelete = new Employee { Id = Employee.Id, TimeStamp = Employee.TimeStamp };
            context.Entry(catToDelete).State = EntityState.Deleted;
            var affected = context.SaveChanges();
            Assert.Equal(1, affected);

        }

        [Fact]
        public void ShouldNotDeleteAnEmployeeWithoutTimestampData()
        {
            var Employee = new Employee { EmployeeName = "Foo" };
            _db.Employees.Add(Employee);
            _db.SaveChanges();
            var context = new TimeSheetContext();
            var catToDelete = new Employee { Id = Employee.Id };
            context.Employees.Remove(catToDelete);
            var ex = Assert.Throws<DbUpdateConcurrencyException>(() => context.SaveChanges());
            Assert.Equal(1, ex.Entries.Count);
            Assert.Equal(Employee.Id, ((Employee)ex.Entries[0].Entity).Id);
        }
    }
}