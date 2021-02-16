using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezeko
{
    class HibasJaratszam : Exception
    {
        public HibasJaratszam(string jaratszam) :
        base("Hiba jaratszam:" +jaratszam)
        { 

        }
    }
}
