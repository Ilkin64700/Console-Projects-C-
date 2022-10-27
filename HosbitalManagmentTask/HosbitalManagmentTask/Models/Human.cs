using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosbitalManagmentTask.Models
{
    abstract class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }

        public Human(string name, string surName, byte age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }
    }
}
