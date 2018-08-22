using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Admin
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public int name { get; set; }
    }
}
