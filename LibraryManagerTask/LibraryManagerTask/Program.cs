using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerTask.Models;
using LibraryManagerTask.Services;

namespace LibraryManagerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            GenreType type1 = new GenreType("Dram");
            GenreType type2 = new GenreType("Detective");
            GenreType type3 = new GenreType("Roman");

            Book book1 = new Book("Hamlet", "Shekspeare", 150, type1);
            Book book2 = new Book("Otello", "Shekspeare", 173, type1);
            Book book3 = new Book("Waiting for Godot", "Samuel", 192, type1);

            Book book4 = new Book("Shekspeare", "Edqar Allah", 150, type2);
            Book book5 = new Book("Oğurlanmış məktub", "Edqar Allah", 173, type2);
            Book book6 = new Book("Baskervillərin iti", "Sir Arthur", 192, type2);

            Book book7 = new Book("Wuthering Heights", "Emilli", 150, type3);
            Book book8 = new Book("Ivanhoe", "Walter Scot", 173, type3);
            Book book9 = new Book("The Black Moth", "Georgette", 192, type3);

            LibraryManager libraryManager = new LibraryManager();

            libraryManager.Add(book1);
            libraryManager.Add(book2);
            libraryManager.Add(book3);
            libraryManager.Add(book4);
            libraryManager.Add(book5);
            libraryManager.Add(book6);
            libraryManager.Add(book7);
            libraryManager.Add(book8);
            libraryManager.Add(book9);

            //Console.WriteLine(libraryManager.ShowInfo("Ivanhoe"));

            foreach (var item in libraryManager.Search("Shekspeare"))
            {
                Console.WriteLine(item);
            }

            //foreach (var item in libraryManager.Filter(type1))
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
