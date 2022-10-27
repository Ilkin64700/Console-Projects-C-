using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerTask.CustomExceptions
{
    class BookNotFoundException : NullReferenceException
    {
        private string _msg;
        public override string Message => _msg;

        public BookNotFoundException(string msg)
        {
            _msg = msg;
        }
    }
}
