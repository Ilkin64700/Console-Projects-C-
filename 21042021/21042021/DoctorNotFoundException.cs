using System;
using System.Collections.Generic;
using System.Text;

namespace _21042021
{
    class DoctorNotFoundException: NullReferenceException
    {
        private string _message;
        public override string Message => _message;

        public DoctorNotFoundException(string msg)
        {
            _message = msg;
        }
    }
}
