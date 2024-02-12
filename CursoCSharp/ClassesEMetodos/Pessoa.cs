using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            if (Nome == null || Nome == " ")
            {
                throw new Exception("Nome vazio");
            }

            if (Idade <= 0)
            {
                throw new Exception("Idade ínválida");
            }



            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = null;
            Idade = 0;

        }
    }
}
