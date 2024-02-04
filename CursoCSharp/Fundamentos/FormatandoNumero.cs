using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C")); // transforma em moeda
            Console.WriteLine(valor.ToString("P")); // transforma em percentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2",culture));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
