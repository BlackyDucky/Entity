using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Review : LibraryAsset
    {
        public int Id { get; set; }
        public int CustomerService { get; set; }
        public int ValueForPrice { get; set; }
        public int SpeedOfService { get; set; }
        public int LocationAndAccessibilty { get; set; }
        public int Reliability { get; set; }
        public int OverAll { get; set; }
        public string ReviewNotes { get; set; }
        public User Customer { get; set; }
        public Mechanic Mechanic { get; set; }
        public bool IsAnonymous{ get; set; }

        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public Admin CreateAdmin { get; set; }
    }
}
