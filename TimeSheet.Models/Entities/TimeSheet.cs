using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeSheet.Models.Enitites.Base;

namespace TimeSheet.Models.Entities
{
   [Table("TimeSheet", Schema = "TimeSheet")]
   public class Timesheet : EntityBase
    {
  
        
        

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [DataType(DataType.Time)]
        public decimal hours { get; set; }

        [DataType(DataType.Currency)]
        public decimal payRate { get; set; }        //Possibly change

        [DataType(DataType.Currency)]
        public decimal salesCommision { get; set; }     //Possibly change
        

       


    }
}
