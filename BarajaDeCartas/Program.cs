using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BarajaDeCartas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Enunciado:

            //Vamos a hacer una baraja de cartas españolas orientado a objetos.
            //Una carta tiene un número entre 1 y 12(el 8 y el 9 no los incluimos) y un palo(espadas, bastos, oros y copas)
            //La baraja estará compuesta por un conjunto de cartas, 40 exactamente.
            //Las operaciones que podrá realizar la baraja son:
            //• barajar: cambia de posición todas las cartas aleatoriamente
            //• siguienteCarta: devuelve la siguiente carta que está en la baraja, cuando no haya más o se haya llegado al final, se indica al usuario que no hay más cartas.
            //• cartasDisponibles: indica el número de cartas que aún puede repartir
            //• darCartas: dado un número de cartas que nos pidan, le devolveremos ese número de cartas(piensa que puedes devolver).En caso de que haya menos cartas que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.
            //• cartasMonton: mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario
            //• mostrarBaraja: muestra todas las cartas hasta el final.Es decir, si se saca una carta y luego se llama al método, este no mostrara esa primera carta.

            Baraja barajaEspañola = new Baraja();
            Console.WriteLine("BARAJANDO");
            Console.WriteLine("------------------------------------------");
            barajaEspañola.barajar();
            for (int i = 0; i < 30; i++)
            {
                barajaEspañola.siguienteCarta();
            }
            Console.WriteLine("------------------------------------------");
            barajaEspañola.cartasDisponibles();
            Console.WriteLine("cuantas cartas quiere");
            int cartas = int.Parse(Console.ReadLine());
            barajaEspañola.darCartas(cartas);
            barajaEspañola.cartasMonton();
            Console.WriteLine("---------------------");
            
            Console.WriteLine("---------------------");
            barajaEspañola.mostrarBaraja();
            
            Console.ReadKey();
        }
    }
}
