using System;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            //fulano.Idade = 21;

            try
            {
                var apresentacaoFulano = fulano.Apresentar();
                Console.WriteLine(apresentacaoFulano);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        
            
        }
    }
}
