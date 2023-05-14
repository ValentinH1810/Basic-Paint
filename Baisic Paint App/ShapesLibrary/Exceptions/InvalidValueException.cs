using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Exceptions
{
    class InvalidValueException : Exception
    {
        public InvalidValueException(string message) : base(message)
        {
        }
    }
}
