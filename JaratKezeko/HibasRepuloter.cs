using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezeko
{
    class HibasRepuloter : Exception
    {
        public HibasRepuloter(string repulo) :
        base("Hibas repülőtér:" + repulo)
        {

        }
    }
}
