using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using TimeSheet.Models.Enitites.Base;
namespace TimeSheet.Models.ViewModels
{
   public class EmployeeAndTimeSheet : EmployeeAndDepartmentBase
    {
       [Display(Name = "Employee TimeSheet info")]
        public int EmployeeId { get; set; }
        public string employeeName { get; set; }
        public decimal payRate { get; set; }
        public bool excempt { get; set; }
        public DateTime date { get; set; }
        public decimal hours { get; set; }




        
    }
}
