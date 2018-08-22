using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class User: LibraryAsset
    {
        [Required]
        public int Id { get; set; }

        [StringLength(30)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(70)]
        public string VehicleManfacturer { get; set; }

        [StringLength(70)]
        public string VehicleBrand { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public Admin CreateAdmin { get; set; }
    }
}
