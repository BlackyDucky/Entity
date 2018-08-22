using Library;
using Library.Models;
using System;
using System.Linq;

namespace Services
{
    public class LibraryAssetService : iService
    {

        private LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            this._context = context;
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            // rest of transaction
            _context.SaveChanges();

        }

        public System.Collections.Generic.IEnumerable<LibraryAsset> GetAll()
        {
            return _context.libraryAssets;
        }

        public LibraryAsset GetById(int id)
        {
            return _context.libraryAssets.FirstOrDefault(asset => asset.Id == id);
        }

        public void Remove(LibraryAsset oldAsset)
        {
            throw new NotImplementedException();
        }
    }
}
