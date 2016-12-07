using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractAssignment
{
    public class InvalidWithDraw : Exception
    {
        public InvalidWithDraw()
        {
        }

        public InvalidWithDraw(string message)
            : base(message)
        {
        }

        public InvalidWithDraw(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
