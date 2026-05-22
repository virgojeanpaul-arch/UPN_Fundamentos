using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subtotal = 0;
            int platos = 0;
            int opcion;

            do
            {
                Console.WriteLine("/n=== MENÚ DE RESTAURANTE ===");
                Console.WriteLine("1. Lomo saltado - S/.25.00");
                Console.WriteLine("2. Ceviche - S/.30.00");
                Console.WriteLine("3. Ají de gallina - S/.20.00");
                Console.WriteLine("4. Pollo a la brasa - S/.35.00");
                Console.WriteLine("0. Pedir cuenta");
                Console.Write("Elija una de las opciones: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    subtotal = subtotal + 25;
                    platos = platos + 1;
                    Console.WriteLine("Agregando: Lomo saltado");
                }
                else if (opcion == 2)
                {
                    subtotal = subtotal + 30;
                    platos = platos + 1;
                    Console.WriteLine("Agregando: Ceviche");
                }
                else if (opcion == 3)
                {
                    subtotal = subtotal + 20;
                    platos = platos + 1;
                    Console.WriteLine("Agregando: Ají de gallina");
                }
                else if (opcion == 4)
                {
                    subtotal = subtotal + 35;
                    platos = platos + 1;
                    Console.WriteLine("Agregando: Pollo a la brasa");
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opción no válida");
                }
            } while (opcion != 0);

            double igv = subtotal * 0.18;
            double total = subtotal + igv;

            Console.WriteLine("/n === CUENTA ===");
            Console.WriteLine($"Platos pedidos: {platos}");
            Console.WriteLine($"Subtotal: {subtotal:F2}");
            Console.WriteLine($"IGV (18%): {igv:F2}");
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
