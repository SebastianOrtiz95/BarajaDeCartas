using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaDeCartas
{
    public class Carta
    {
        private int numero;
        private string palo;

        public Carta(int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Palo { get => palo; set => palo = value; }

        public override string ToString()
        {
            return numero + " de " + palo;
        }
        
    }
}
