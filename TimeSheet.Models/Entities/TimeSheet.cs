using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeSheet.Models.Enitites.Base;

namespace TimeSheet.Models.Entities
{
    [Table("TimeSheet", Schema = "TimeSheet")]
   public class timeSheet : EntityBase
    {
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [DataType(DataType.Time)]
        public decimal hours { get; set; }

        [DataType(DataType.Currency)]
        public decimal payRate;

        [DataType(DataType.Currency)]
        public decimal salesCommision;
        

       


    }
}
