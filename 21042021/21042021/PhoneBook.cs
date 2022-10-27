using System;
using System.Collections.Generic;
using System.Text;

namespace _21042021
{
    class PhoneBook
    {
        private string[] _phones = new string[10];

        public string this[int index]
        {
            get
            {
                if (index < 0 || index > _phones.Length-1)
                {
                    throw new IndexOutOfRangeException();
                }
                return _phones[index];
            }
            set
            {
               if(index<0 || index + 1 > _phones.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                _phones[index] = value;

            }
        }
    }
}
