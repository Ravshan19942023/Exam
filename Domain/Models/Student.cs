using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string FatherName {  get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(60)]
        public string Adress {  get; set; }
        [MaxLength(13)]
        public string Phone {  get; set; }

    }
}

