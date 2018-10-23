using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TimeSheet.DAL.EF;
using TimeSheet.DAL.Repos.Base;
using TimeSheet.Models.Entities;

namespace TimeSheet.DAL.Repos
{
    public class EmployeeRepo : RepoBase<Employee>
    {
        public EmployeeRepo(DbContextOptions<TimeSheetContext> options) : base(options)
        {
        }

        public EmployeeRepo()
        {
        }
        public override IEnumerable<Employee> GetAll()
            => Table.OrderBy(x => x.Id);

        public override IEnumerable<Employee> GetRange(int skip, int take)
            => GetRange(Table.OrderBy(x => x.Id), skip, take);
    }
}