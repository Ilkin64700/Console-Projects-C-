using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerTask.Models
{
    class Book
    {
        private static int _count;
        public readonly int Id;

        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public GenreType Genre { get; set; }

        public Book()
        {
            _count++;
            Id = _count;
        }

        public Book(string name, string author): this()
        {
            Name = name;
            Author = author;
        }

        public Book(string name, string author, int pageCount, GenreType genre) : this(name, author)
        {
            PageCount = pageCount;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Author} {PageCount} {Genre}";
        }
    }
}
