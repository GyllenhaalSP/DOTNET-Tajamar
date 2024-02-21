using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME
{
    public class NoDatabaseFound: Exception
    {
        public NoDatabaseFound(string message) : base(message)
        {
        }
    }
}
