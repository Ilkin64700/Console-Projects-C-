using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerTask.Models
{
    class GenreType
    {
        private static int _count;
        public readonly int Id;

        public string Name { get; set; }

        public GenreType(string name)
        {
            _count++;
            Id = _count;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
