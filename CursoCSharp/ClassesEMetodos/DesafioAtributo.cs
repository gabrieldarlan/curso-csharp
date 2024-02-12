using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            int a1 = new DesafioAtributo().a;
            Console.WriteLine(a1);

            var a = new DesafioAtributo();
            int variavelA = a.a;
            Console.WriteLine(variavelA);
        }
    }
}
