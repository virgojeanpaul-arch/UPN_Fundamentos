using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos_Semana_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo01();
            //Ejemplo02();
        }

        //Ejemplo1 
        static void Ejemplo01()
        {
            int n;
            int numero;
            int suma = 0;

            Console.Write("Cantidad de números que desea sumar: ");
            n = int.Parse(Console.ReadLine());

            int contador = 1;

            while (contador <= n)
            {
                Console.Write($"Ingrese el número {contador}: ");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero;
                contador++;
            }
            Console.WriteLine($"La suna de los {n} números es: {suma}");
        }

        //Ejemplo02
        static void Ejemplo02()
        {
            int n, suma = 0;
            Random randon = new Random();

            Console.Write("Cuántos números aleatorios desea dumar: ");
            n = int.Parse(Console.ReadLine());

            int contador = 1;

            while (contador <= n)
            {
                int numero = randon.Next(1, 101);
                Console.WriteLine($"Número aleatorio {contador}: {numero}");
                suma += numero;
                contador++;
            }
            Console.WriteLine($"La suma de los {n} números aleatorios es: {suma}");
        }
    }
}
