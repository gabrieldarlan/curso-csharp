using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            double somatario = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            for (int i = 1; i <= tamanhoDaTurma; i++)
            {
                Console.Write($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatario += notaAtual;
            }

            double media = tamanhoDaTurma > 0 ? somatario / tamanhoDaTurma : 0;
            Console.WriteLine($"Media da turma: {media}");
        }
    }
}
