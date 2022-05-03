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

        public Nakladak()
        {
            Jmeno = " ";
            nosnost = 20000;
            objemnadrze = 1000;
            spotrebapaliva = 30;
            celkovaujetavzdalenost = 1500;
        }
    }
}
