using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO
{

    public class FilhoNaoReconhcido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhcido");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitoDeFalar);
        }
    }


    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante");

            Console.WriteLine(amiga.InfoPublica);
        }
    }

    class Encapsulamento
    {


        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoNaoReconhcido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
