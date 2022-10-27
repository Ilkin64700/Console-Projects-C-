using System;
using System.Collections.Generic;
using System.Text;

namespace _21042021
{
    class Doctor:Human
    {
        private static int _count = 1000;
        private string _speciality;
        public string No { get; }
        public string Speciality
        {
            get
            {
                return _speciality;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && value.Length > 2)
                {
                    _speciality = value;
                }
            }
        }
        public byte Experience;

        public Doctor(string speciality)
        {
            _count++;

            this.Speciality = speciality;
            No = this.Speciality.Substring(0, 2).ToUpper() + _count;
        }

        public Doctor(string name,string surname,string speciality) : this(speciality)
        {
            Name = name;
            Surname = surname;
        }
    }
}
