using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    class InvalidAge: Exception
    {
        public InvalidAge()
        {

        }
        public InvalidAge(string message) : base(message)
        {

        }
    }
}
