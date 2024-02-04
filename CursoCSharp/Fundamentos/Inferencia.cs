using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo";
            Console.WriteLine(nome);

            //var idade;
            int idade;
            idade = 34;

            var st = new StringBuilder();
            st.Append("Gabriel");
            st.Append("Darlan");

            Console.WriteLine($"{st} {idade}");
        }
    }
}
