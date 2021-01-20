using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    class InvalidTravel: Exception
    {
        public InvalidTravel()
        {

        }
        public InvalidTravel(string message): base(message)
        {
            
        }
    }
}
