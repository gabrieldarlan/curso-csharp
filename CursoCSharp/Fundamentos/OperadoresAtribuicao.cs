using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 = 10;

            int a = 1;
            int b = a;
            a++; // a = a + 1;
            b--; // b = b - 1;

        }
    }
}
