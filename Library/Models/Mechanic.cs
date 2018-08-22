using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Mechanic:LibraryAsset
    {
        [Required]
        public int Id { get; set; }

        [StringLength(70)]
        public string ShopName { get; set; }

        [StringLength(70)]
        public string MechanicName { get; set; }

        public int PersonnalCount { get; set; }     // wie viel leute bei den laden gearbietet

        [StringLength(200)]
        public string Address { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public List<Speciality> SpecializationCode { get; set; }

        public User CreateUser { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }

        public Admin CreateAdmin { get; set; }
    }
}
