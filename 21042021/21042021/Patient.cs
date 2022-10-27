using System;
using System.Collections.Generic;
using System.Text;

namespace _21042021
{
    class Patient:Human
    {
        private static int _count = 1000;
        public string No;
        public string Diagnosis;
        public string RegisterDate;

        public Patient(string name,string surname,bool gender):base(name,surname,gender)
        {
            _count++;
            No = name.Substring(0, 2).ToUpper() + _count;
        }
    }
}
