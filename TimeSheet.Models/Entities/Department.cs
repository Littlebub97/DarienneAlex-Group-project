using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Models.Entities
{
    class Department
    {
        [Table("Department", Schema = "Employee")]
        public class Department : EntityBase
        {
            [DataType(DataType.Text), MaxLength(50), Display(Name = "Full Name")]
            public string FullName { get, set; }
                [Required]
                [Position]
                [DataType(DataType.Position), MaxLength(50), Display(Name = "Position")]
                public string Position { get, set; }
        }
    }
}
