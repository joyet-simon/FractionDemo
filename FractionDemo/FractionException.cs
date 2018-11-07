using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class FractionException : Exception
    {
        public FractionException(string message) : base(message) {  }
    }
}
