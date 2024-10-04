using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Adivinanza
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int numeroAleatorio = random.Next(10, 9999);

            int intentos = 0;

            Console.WriteLine(numeroAleatorio);

            Console.WriteLine("REGLAS DEL JUEGO\nSe genero un numero entre 10 y 10000.\nIngrese un numero para intentar adivinarlo.\nTiene 9 intentos.");

            if (numeroAleatorio < 1000)
                Console.WriteLine("PISTA\nEl ultimo digito del numero es " + numeroAleatorio.ToString().Substring(2));
            else
                Console.WriteLine("PISTA\nEl ultimo digito del numero es " + numeroAleatorio.ToString().Substring(3));

            while (intentos < 9)
            {

                int numeroAdivino = int.Parse(Console.ReadLine());

                int diferenciaNumeros = Math.Abs(numeroAleatorio - numeroAdivino);

                if (Adivinanza(numeroAleatorio, numeroAdivino, diferenciaNumeros) == true)
                {

                    Console.WriteLine("Le pegaste, sos groso sabelo. El numero era: " + numeroAleatorio);

                    break;

                }
                else
                {

                    intentos++;

                    Console.WriteLine("Numero de intentos: " + intentos);

                }

            }

            Console.Read();

        }

        public static bool Adivinanza(int numeroAdivinar, int numeroAdivinado, int distancia)
        {

            bool resultado = false;

            if (numeroAdivinar == numeroAdivinado)
            {

                resultado = true;

            }
            else if (distancia > 1000)
            {

                Console.WriteLine("Numero equivocado.\nLa distancia entre numeros es mayor a 1000");

                resultado = false;
            }
            else if (distancia > 500 && distancia < 1000)
            {

                Console.WriteLine("Numero equivocado.\nLa distancia entre numeros es mayor a 500 y menor a 1000");

                resultado = false;
            }
            else if (distancia > 100 && distancia < 500)
            {

                Console.WriteLine("Numeor equivocado.\nLa distancia entre numeros es mayor a 100 y menor a 500");

                resultado = false;
            }
            else if(distancia < 100)
            {

                Console.WriteLine("Numero equivocado.\nLa distancia entre numero es menor a 100");

                resultado = false;   
            }

            return resultado;
        }

    }
}
