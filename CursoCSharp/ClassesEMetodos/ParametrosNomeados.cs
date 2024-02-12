using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int? dia, int mes, int ano)
        {
            if (dia == null)
            {
                dia = 01;
            }
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            Formatar(dia: null, mes: 2, ano: 2005);
        }
    }
}
