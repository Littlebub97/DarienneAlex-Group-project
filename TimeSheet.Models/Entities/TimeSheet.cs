using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeSheet.Models.Enitites.Base;

namespace TimeSheet.Models.Entities
{
    [Table("TimeSheet", Schema = "TimeSheet")]
   public class TimeSheet : EntityBase
    {   
  
        [DataType(DataType.Currency)]
        public decimal payRate;

       


    }
}
