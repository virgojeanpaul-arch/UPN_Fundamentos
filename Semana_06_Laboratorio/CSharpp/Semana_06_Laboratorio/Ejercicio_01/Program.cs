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
            int saldo = 1000;
            int retiros = 0;

            Console.WriteLine("===CAJERO AUTOMÁTICO ===");
            Console.WriteLine($"Saldo disponible: S/. {saldo}");

            Console.Write("Cuanto desea retirar: ");
            int monto = int.Parse(Console.ReadLine());

            while (monto != 0)
            {
                if (monto < 0)
                {
                    Console.WriteLine("Error: Monto invalido");
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Error: Saldo insuficiente.");
                }
                else
                {
                    saldo = saldo - monto;
                    retiros++;
                    Console.WriteLine($"Retiro exitoso. Saldo: S/. {saldo}");
                }

                Console.Write("Monto a retirar (0 para salir): ");
                monto = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--- RESUMEN ---");
            Console.WriteLine($"Retiros realizados: {retiros}");
            Console.WriteLine($"Saldo final: {saldo}");
        }
    }
}
