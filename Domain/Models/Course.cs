using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public decimal Fee {  get; set; }
        public bool HasDiscount { get; set; }
    }
}
