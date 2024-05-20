using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CastException : Exception
    {
        public CastException(string message)
            : base(message) { }

        public CastException()
        : base("Error, casteando objeto!")
        { }
    }
}
