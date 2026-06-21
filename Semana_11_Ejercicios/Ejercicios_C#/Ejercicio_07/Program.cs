using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] asistencia = new int[5];
            bool existe_Cero = false;

            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.Write($"Asistencia sesión {i + 1}: ");
                asistencia[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAsistencias registradas:");

            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }

            for (int i = 0; i < asistencia.Length; i++)
            {
                if (asistencia[i] == 0)
                {
                    existe_Cero = true;
                }
            }

            if (existe_Cero)
            {
                Console.WriteLine("Alerta: existe una sesión con 0 asistentes");
            }
            else
            {
                Console.WriteLine("No hay sesión con 0 asistentes");
            }

            Console.Write("Índice a modificar: ");
            int indice_modificar = int.Parse(Console.ReadLine());

            if (indice_modificar >= 0 && indice_modificar < asistencia.Length)
            {
                Console.Write("Nuevo valor: ");
                int valor = int.Parse(Console.ReadLine());
                asistencia[indice_modificar] = valor;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }

            Console.WriteLine("\nAsistencias actualizadas");

            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }
        }
    }
}
