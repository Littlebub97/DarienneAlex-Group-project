using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeSheet.Models.Enitites.Base;

namespace TimeSheet.Models.Entities
{
   [Table("TimeSheet", Schema = "TimeSheet")]
   public class Timesheet : EntityBase
    {
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [DataType(DataType.Time)]
        public decimal dailyHours { get; set; } //Possibly change later

        [DataType(DataType.Time)]
        public decimal weeklyHours { get; set; }

        [DataType(DataType.Currency)]
        public decimal payRate { get; set; }        //Possibly change

        [DataType(DataType.Currency)]
        public decimal salesCommision { get; set; }     //Possibly change

        public bool approved { get; set; }

        [DataType(DataType.Text), MaxLength(200)]
        public string Reason { get; set; }

       


    }
}
