using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_03
{
    internal class Program
    {
        static double limiteCercano = 5;

        static void Main(string[] args)
        {
            Console.Write("Ingrese la distancia (en km): ");
            double distancia = double.Parse(Console.ReadLine());
            double costoDelivery = CalcularDelivery(distancia);

            Console.WriteLine($"La distancia es: {distancia:F2} km");
            Console.WriteLine($"El total del delivery es: S/.{costoDelivery:F2}");
        }

        static Double CalcularDelivery(double distancia)
        {
            if (distancia <= limiteCercano)
            {
                return 6.00;
            }
            else
            {
                return 10.00;
            }
        }
    }
}
