using System;
using System.Collections.Generic;
using System.Text;

namespace _21042021
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        public Human()
        {

        }
        public Human(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Human(string name, string surname,bool gender):this(name,surname)
        {
            Gender = gender;
        }
    }


}
