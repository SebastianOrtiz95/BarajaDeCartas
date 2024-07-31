using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaDeCartas
{
    public class Helper
    {
        private static Random random = new Random();
        public static int numeroAleatorio(int minimo,int maximo)
        {
           return random.Next(minimo,maximo);
        }
    }
}
