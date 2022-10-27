using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosbitalManagmentTask.Models
{
    class Doctor : Human
    {
        private static int _count;
        public readonly int Id;

        public string Speciality { get; set; }

        public Doctor(string name, string surName, byte age, string speciality):base(name, surName, age)
        {
            _count++;
            Id = _count;
            Speciality = speciality;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {SurName} {Speciality} {Age}";
        }
    }
}
