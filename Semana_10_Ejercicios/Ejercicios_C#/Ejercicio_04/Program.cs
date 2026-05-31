using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static int Contar_Digitos(int codigo)
        {
            int contador = 0;
            codigo = Math.Abs(codigo);

            if (codigo == 0)
            {
                return 1;
            }
            while (codigo > 0)
            {
                contador++;
                codigo = codigo / 10;
            }
            return contador;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el codigo: ");
            int codigo = int.Parse(Console.ReadLine());

            int digitos = Contar_Digitos(codigo);

            if (digitos >= 6 && digitos <= 8)
            {
                Console.WriteLine("Código válido.");
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }
        }
    }
}
