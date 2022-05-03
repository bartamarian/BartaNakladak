using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartaNakladak
{
    public class Nakladak
    {
        public int Nosnost;
        public int ObjemNadrze;
        public int SpotrebaPaliva;
        public int CelkovaUjetaVzdalenost;

        public string Jmeno { get; set; }
        
    }

    public Nakladak()
    {
        Jmeno = " ";
        nosnost = 20000;
        objenadrze = 1000;
        spotrebapaliva = 30;


    }
}
