using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerTask.CustomExceptions
{
    class SameBooksAlreadyAddedExpection : Exception
    {
        private string _msg;
        public override string Message => _msg;

        public SameBooksAlreadyAddedExpection(string msg)
        {
            _msg = msg;
        }
    }
}
