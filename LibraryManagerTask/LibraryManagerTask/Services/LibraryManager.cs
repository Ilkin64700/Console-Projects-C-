using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerTask.CustomExceptions;
using LibraryManagerTask.Interfaces;
using LibraryManagerTask.Models;

namespace LibraryManagerTask.Services
{
    class LibraryManager : ILibraryManager
    {
        public LibraryManager()
        {
            Books = new List<Book>();
        }

        public List<Book> Books { get; set; }

        public void Add(Book book)
        {
            if (Books.Any(b => b.Name.Trim().ToLower() == book.Name.Trim().ToLower()))
            {
                throw new SameBooksAlreadyAddedExpection($"{book.Name} adli kitab artiq movcuddur");
            }

            Books.Add(book);
        }

        public List<Book> Filter(GenreType genre)
        {
            List<Book> books = Books.FindAll(b => b.Genre == genre);
            return books;
        }

        public List<Book> Search(string val)
        {
            List<Book> books = Books.FindAll(b => b.Name.Trim().ToLower() == val.Trim().ToLower() ||
            b.Author.Trim().ToLower() == val.Trim().ToLower() ||
            b.Genre.Name.Trim().ToLower() == val.Trim().ToLower() ||
            b.PageCount.ToString() == val);

            return books;
        }

        public Book ShowInfo(string name)
        {
            Book book = Books.Find(b => b.Name.Trim().ToLower() == name.Trim().ToLower());
            if (book == null)
            {
                throw new BookNotFoundException($"{name} adli kitab movcud deyil");
            }
            return book;
        }
    }
}
