using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeSheet.Models.Enitites.Base;

namespace TimeSheet.Models.Entites
{   
    [Table("Employee", Schema = "TimeSheet")]
    public class Employee : EntityBase
    {
      [DataType(DataType.Text), MaxLength(50)]
        public string EmployeeName {get; set; }

        [DataType(DataType.Text), MaxLength(50)]
        public string EmailAddress{ get; set; }

        [DataType(DataType.Text), MaxLength(50)]
        public string PhoneNumber { get; set; }

    }
}
