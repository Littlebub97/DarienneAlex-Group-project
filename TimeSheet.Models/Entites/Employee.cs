using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeSheet.Models.Entites.Base;

namespace TimeSheet.Models.Entites
{   
    [Table("Employees", Schema = "TimeSheet")]
    public class Employee : EntityBase
    {
.       [DataType(DataType.Text), MaxLength(50)]
        public string EmployeeName {get; set; }
    }
}
