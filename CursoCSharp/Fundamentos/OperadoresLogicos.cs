using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a Tv 50? {comprouTV50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou o sorvete? {comprouSorvete}");

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou a Tv 50? {comprouTV32}");

         
            Console.WriteLine($"Mais saudavel? {!comprouSorvete}");

        }
    }
}
