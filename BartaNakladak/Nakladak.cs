using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartaNakladak
{
    public class Nakladak
    {
        public int nosnost;
        public int objemnadrze;
        public int spotrebapaliva;
        public int celkovaujetavzdalenost;

        public string Jmeno { get; set; }
        public int Nosnost { get; set; }
        public int ObjemNadrze { get; set; }
        public int SpotrebaPaliva { get; set; }
        public int CelkovaUjetaVzdalenost { get; set; }
        public int Naklad { get; set; }

        public Nakladak()
        {
            Jmeno = " ";
            Nosnost = 20000;
            ObjemNadrze = 1000;
            SpotrebaPaliva = 30;
            CelkovaUjetaVzdalenost = 1500;
            Naklad = 0;
        }

        public void Nalozit()
        {
            Naklad += 2000;
            if (Naklad > 20000)
            {
                Naklad = 20000;
            }
        }

        public void Vylozit()
        {
            Naklad -= 2000;
            if(Naklad < 0)
            {
                Naklad = 0;
            }
        }
    }
}
