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
        public string Title { get; set; }
        public string Status { get; set; }
        public string Hours { get; set; }
        public DateTime Date { get; set; }
    }
}