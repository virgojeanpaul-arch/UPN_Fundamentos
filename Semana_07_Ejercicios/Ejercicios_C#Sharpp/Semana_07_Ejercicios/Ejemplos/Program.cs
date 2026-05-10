using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo01();
            Ejemplo02();
            Console.ReadKey();
        }
        static void Ejemplo01()
        {
            int suma = 0;
            int contador = 0;
            int numero = 1;

            do
            {
                suma = suma + numero;
                contador = contador + 1; //contador++
                numero = numero + 2; //1 3 5 7 9 11
            } while (contador < 100 && numero < 500);

            //salidas
            Console.WriteLine($"Cantidad de impares sumados: {contador}");
            Console.WriteLine($"Siguiente impar despues de terminar el ciclo: {numero}");
            Console.WriteLine($"Suma de los primeros 100 números impares" + $"< que 500 es: {suma}");
        }

        static void Ejemplo02()
        {
            int numero;
            int mayor = int.MinValue;
            int contador = 0;

            do
            {
                Console.Write("Ingrese un número entero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                        contador++;
                }
            } while (numero != 0);

            {
                if (contador > 0)
                {
                    Console.WriteLine($"El mayor número ingresado es: {mayor}");
                }
                else
                {
                    Console.WriteLine($"No se ingresaron números validos");
                }
            }
        }
    }
}
