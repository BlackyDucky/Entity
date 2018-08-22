using System;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<LibraryAsset> libraryAssets { get; set; }
    }
}
