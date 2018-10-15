using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TimeSheet.Models.Enitites;
using TimeSheet.DAL.EF;
using TimeSheet.Models.Entites;

namespace TimeSheet.DAL.Initializers
{
    public static class TimeSheetSampleData
    {
        public static IEnumerable<Employee> GetEmployees() => new List<Employee>
        {
            new Employee { firstName = "Alex", lastName = "Sidwell", EmailAddress = "asidwell@wvup.edu" }
        };
    }
}
