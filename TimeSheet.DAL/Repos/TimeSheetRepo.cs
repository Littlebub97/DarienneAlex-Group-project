using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TimeSheet.DAL.EF;
using TimeSheet.DAL.Repos.Base;
using TimeSheet.Models.Entities;

namespace TimeSheet.DAL.Repos
{
   public class TimeSheetRepo : RepoBase<Timesheet>
    {
        public TimeSheetRepo(DbContextOptions<TimeSheetContext> options) : base(options)
        { 
        }

        public TimeSheetRepo() : base()
        {
        }
        public override IEnumerable<Timesheet> GetAll()
       => Table.OrderBy(x => x.Id);                     //CHANGE LATER

        public override IEnumerable<Timesheet> GetRange(int skip, int take)
            => GetRange(Table.OrderBy(x => x.Id), skip, take);      //CHANGE LATER

    }
}
