using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static double Tipo_de_Cambio = 3.75;
        static double Porcentaje_Comision = 0.02;
        static void Main(string[] args)
        {
            Console.WriteLine("=== CASA DE CAMBIO ===");

            Console.Write("Ingrese el monto a cambiar en soles: S/");
            double soles = double.Parse(Console.ReadLine());

            double comision = Calcular_Comision(soles);
            double soles_Netos = Calcular_Soles_Netos(soles, comision);
            double dolares = Convertir_a_Dolares(soles_Netos);
            Mostrar_Comprobante(soles, comision, soles_Netos, dolares);
        }
        static double Calcular_Comision(double soles)
        {
            double comision = soles * Porcentaje_Comision;
            return comision;
        }
        static double Calcular_Soles_Netos(double soles, double comision)
        {
            double soles_Netos = soles - comision;
            return soles_Netos;
        }
        static double Convertir_a_Dolares(double soles_Netos)
        {
            double dolares = soles_Netos / Tipo_de_Cambio;
            return dolares;
        }
        static void Mostrar_Comprobante(double soles, double comision, double soles_Netos, double dolares)
        {
            Console.WriteLine("n/ === COMPROBANTE ===");
            Console.WriteLine($"Monto ingresado: S/.{soles:F2}");
            Console.WriteLine($"Comisión (2%): S/.{comision:F2}");
            Console.WriteLine($"Soles netos a cambiar: S/.{soles_Netos:F2}");
            Console.WriteLine($"Dólares recibidos: ${dolares:F2}");
        }
    }
}
