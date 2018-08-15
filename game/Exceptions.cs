using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Exceptions : System.Exception 
    {
        public Exceptions()
        {
        }
        public Exceptions(string message) : base(message)
        {

        }

    }

    class OutOfBoundsException : Exceptions
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    
   
    }
}
