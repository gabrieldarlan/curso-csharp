using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var soma = CalculadoraEstatica.Somar(31, 12);
            Console.WriteLine($"Somar = {soma}");

            int multiplicar = CalculadoraEstatica.Multiplicar(3, 4);
            Console.WriteLine($"multiplicar = {multiplicar}");
        }
    }
}
