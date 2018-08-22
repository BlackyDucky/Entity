using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Speciality
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        public string Label { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }

        public Admin CreateAdmin { get; set; }
    }
}
