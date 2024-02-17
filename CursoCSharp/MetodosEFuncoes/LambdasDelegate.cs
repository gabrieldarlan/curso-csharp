using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{

    delegate double Operacao(double x, double y); //tipo que representa a assinatura de uma funcao com o seu tipo

    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sub(12, 8));
            Console.WriteLine(mult(12, 8));
            Console.WriteLine(sum(12, 8));
        }
    }
}
