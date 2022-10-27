using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerTask.Models;

namespace LibraryManagerTask.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; set; }

        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string val);
        List<Book> Filter(GenreType genre);
    }
}
