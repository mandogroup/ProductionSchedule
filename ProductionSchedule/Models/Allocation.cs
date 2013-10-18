using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductionSchedule.Models
{
    public class Allocation
    {
        public int AllocationId { get; set; }
        [Required]
        public String Title { get; set; }
        public String Status { get; set; }
        public Double Hours { get; set; }
        public DateTime Date { get; set; }
    }
}