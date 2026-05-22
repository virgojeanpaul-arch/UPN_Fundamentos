using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasena = "UPN2026";
            int MaxIntentos = 3;
            int intentos = 0;
            bool acceso = false;
            string clave;

            do
            {
                intentos = intentos + 1;
                Console.Write($"Intento {intentos}/{MaxIntentos} - Clave: ");
                clave = Console.ReadLine();

                if (clave == contrasena)
                {
                    acceso = true;
                }
                else
                {
                    int restantes = MaxIntentos - intentos;

                    if (restantes > 0)
                    {
                        Console.WriteLine($"Clave incorrecta. Quedan {restantes} intentos.");
                    }
                }
            } while (!acceso && intentos < MaxIntentos);

            if (acceso)
            {
                Console.WriteLine("Acceso Concedido. Bienvenido.");
            }
            else
            {
                Console.WriteLine("Cuenta bloqueada. Contacte al administrador.");
            }
        }
    }
}
