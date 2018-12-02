using System;
using System.Collections.Generic;
using System.Text;
using TimeSheet.Models.Entities;
using TimeSheet.Models.Enitites.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheet.Models.Entities
{
    public class Management : EntityBase
    {
        public string EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Manager { get; set; }

    }
}
