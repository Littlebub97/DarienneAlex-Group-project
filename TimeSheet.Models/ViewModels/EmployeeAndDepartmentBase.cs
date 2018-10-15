using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using TimeSheet.Models.Enitites.Base;

namespace TimeSheet.Models.ViewModels
{
    public class EmployeeAndDepartmentBase : EntityBase
    {


        [Display(Name = "Employee Info")]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int employeeId { get; set; }
        public bool exempt { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string position { get; set; }
        public string departmentName { get; set; }
    }

       
        }
    

