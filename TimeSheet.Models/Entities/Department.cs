using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TimeSheet.Models.Enitites.Base;

namespace TimeSheet.Models.Entities
{
    [Table("Department", Schema = "Employee")]
    public class Department : EntityBase
    {       

            [Required]
            [DataType(DataType.Text), MaxLength(50)]
            public string DepartmentName { get; set; }

            [Required]
            [DataType(DataType.Text), MaxLength(50), Display(Name = "Roles")]
            public string Role { get; set; }


    }
}
