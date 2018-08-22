using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface iService
    {
        IEnumerable<LibraryAsset> GetAll();

        LibraryAsset GetById(int id);

        void Add(LibraryAsset newAsset);

        void Remove(LibraryAsset oldAsset);

    }
}
