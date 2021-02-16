using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezeko
{
    public class JaratKezelo
    {
        private class Jarat 
        {
            string jaratszam;
            string kezdetiRepuloter;
            string celRepuloter;
            DateTime indulasIdopontja;
            int aktualisKeses;

            public Jarat(string jaratszam, string kezdetiRepuloter, string celRepuloter, DateTime indulasIdopontja, int aktualisKeses)
            {
                this.Jaratszam = jaratszam;
                this.KezdetiRepuloter = kezdetiRepuloter;
                this.CelRepuloter = celRepuloter;
                this.IndulasIdopontja = indulasIdopontja;
                this.AktualisKeses = aktualisKeses;
            }

            public string Jaratszam { get => jaratszam; set => jaratszam = value; }
            public string KezdetiRepuloter { get => kezdetiRepuloter; set => kezdetiRepuloter = value; }
            public string CelRepuloter { get => celRepuloter; set => celRepuloter = value; }
            public DateTime IndulasIdopontja { get => indulasIdopontja; set => indulasIdopontja = value; }
            public int AktualisKeses { get => aktualisKeses; set => aktualisKeses = value; }
        }

        private List<Jarat> jaratok;
        private List<string> jRepuloterrol;

        public JaratKezelo() 
        {
            jaratok = new List<Jarat>();
        }

        public void UjJarat(string jaratszam, string kezdetiRepuloter, string celRepuloter, DateTime indulasIdopontja)
        {
            int aktualisKeses = 0;
            Jarat j = new Jarat(jaratszam, kezdetiRepuloter, celRepuloter, indulasIdopontja, aktualisKeses);
            jaratok.Add(j);
        }

        public void Keses(string jaratszam, int aktualisKeses) 
        {
            foreach (var jarat in jaratok)
            {
                if (jarat.Jaratszam.Equals(jaratszam))
                {
                    jarat.AktualisKeses += aktualisKeses;
                    return;
                }
            }
        }

        public DateTime MikorIndul(string jaratszam) 
        {
            foreach (var jarat in jaratok)
            {
                if (jarat.Jaratszam.Equals(jaratszam))
                {
                    return jarat.IndulasIdopontja;
                }
            }
            throw new HibasJaratszam(jaratszam);

        }

        
        public List<string> jaratokRepuloterrol(string repter) 
        {
            jRepuloterrol = new List<string>();

            foreach (var jarat in jaratok)
            {
                if (jarat.KezdetiRepuloter.Equals(repter))
                {
                   jRepuloterrol.Add(jarat.Jaratszam);
                   return jRepuloterrol;
                }
            }
            throw new HibasRepuloter(repter);

        }

    }

}
