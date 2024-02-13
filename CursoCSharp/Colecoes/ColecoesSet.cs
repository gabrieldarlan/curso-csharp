using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8 Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),


            };

            carrinho.UnionWith(combo); // Adiciona uma lista de List
            Console.WriteLine(carrinho.Count);
           
            foreach (var item in combo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

        }
    }
}
