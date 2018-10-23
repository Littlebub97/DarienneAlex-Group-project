using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TimeSheet.DAL.EF;
using TimeSheet.DAL.Repos.Base;
using TimeSheet.Models.Entities;

namespace TimeSheet.DAL.Repos
{
   public class DepartmentRepo : RepoBase<Department>
    {
        public DepartmentRepo(DbContextOptions<TimeSheetContext> options) : base(options)
        {
        }
     
        public DepartmentRepo() : base()
        {
        }

        public override IEnumerable<Department> GetAll()
            => Table.OrderBy(x => x.DepartmentName);        
    }
}
