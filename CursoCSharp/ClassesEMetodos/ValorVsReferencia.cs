using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dependente = new Dependente
            {
                Idade = 20,
                Nome = "Beto"
            };

            Console.WriteLine($"{dependente.Nome} | {dependente.Idade}");

            Dependente copiaDependente = dependente;
            copiaDependente.Idade = 21;
            copiaDependente.Nome = "Renato";
            Console.WriteLine($"{copiaDependente.Nome} | {copiaDependente.Idade}");

        }
    }
}
