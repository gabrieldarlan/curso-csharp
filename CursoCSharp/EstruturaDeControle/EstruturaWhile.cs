using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativas = 0;


            while (tentativaRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var conAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado com {tentativas} tentativas");
                    Console.BackgroundColor = conAnterior;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Menor... tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativaRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativaRestantes);
                }
            }


        }
    }
}
