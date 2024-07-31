using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarajaDeCartas
{
    public class Baraja
    {
        //asdsjdsdsjhds
        private Carta[] cartas=new Carta[40];
        private static int[] numeroDeCartas = {1,2,3,4,5,6,7,10,11,12};
        private Carta[] cartasMontonMaso = new Carta[40];
        private int indiceCartasMonton =0;
        private static string[] palos = {"ORO","BASTO","ESPADA","COPA"};
        private static int indiceCartas = 39;
        public Baraja()
        {
            llenarCartas();
        }

        private void llenarCartas()
        {
            int indice = 0; 
            foreach (string palo in palos)
            {
                foreach (int numero in numeroDeCartas)
                {
                    cartas[indice++] = new Carta(numero,palo);
                }
            }
        }
       
        public void mostrarCartas()
        {
            foreach (var carta in cartas)
            {
                Console.WriteLine(carta);
            }
        }

        public void barajar()
        {
            Random random = new Random();
            int n = cartas.Length;
            for (int i = n - 1; i > 0; i--)
               {
                  int j = random.Next(i + 1);
                   // Intercambiar cartas[i] con cartas[j]
                   Carta temp = cartas[i];
                   cartas[i] = cartas[j];
                   cartas[j] = temp;
               }
        }
        public void siguienteCarta()
        {
            bool siguienteCarta = false;
            if (indiceCartas<0)
            {
                Console.WriteLine("No hay mas cartas");
                return;
            }
            while (!siguienteCarta)
            {
                cartasMontonMaso[indiceCartasMonton++] = cartas[indiceCartas];
                Console.WriteLine(cartas[indiceCartas--]);
                siguienteCarta = true;
            }
        }
        public void cartasDisponibles()
        {
            if (indiceCartas < 0)
            {
                Console.WriteLine("No hay cartas disponibles");
            }else
                Console.WriteLine("Cartas Disponibles: " + (indiceCartas+1));
        }
        public void darCartas(int c)
        {
            if (indiceCartas < c)
            {
                Console.WriteLine("No alcanzan las cartas que pides");
                return;
            }
            for (int i = 0; i < c; i++)
            {
                cartasMontonMaso[indiceCartasMonton++]= cartas[indiceCartas];
                indiceCartas--;
                Console.WriteLine(cartas[indiceCartas]);
            }
        }
        public void cartasMonton()
        {
            if (indiceCartasMonton == 0)
            {
                Console.WriteLine("No ha salido ninguna carta todavia");
            }
            Console.WriteLine("Cartas que ya salieron: ");
            for (int i = 0; i < indiceCartasMonton; i++)
            {
                Console.WriteLine(cartasMontonMaso[i]);
            }
        }
        public void mostrarBaraja()
        {
            if(indiceCartas < 0)
            {
                Console.WriteLine("NO HAY CARTAS EN LA BARAJA");
            }
            for (int i = 0;i < indiceCartas+1; i++)
            {
                Console.WriteLine(cartas[i]);
            }
        }
    }
}
