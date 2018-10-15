using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TimeSheet.DAL.EF;
using TimeSheet.DAL.Repos.Base;
using TimeSheet.Models.Entities;

namespace TimeSheet.DAL.Repos
{
   public class TimeSheetRepo : RepoBase<timeSheet>
    {
        public TimeSheetRepo(DbContextOptions<TimeSheetContext> options) : base(options)
        { 
        }

        public TimeSheetRepo() : base()
        {
        }


    }
}
