using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    interface ITeste
    {
        bool Bla(string a);
    }

    interface IOperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    class Soma : IOperacaoBinaria, ITeste
    {
        public bool Bla(string a)
        {
            return true;
        }

        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Subtracao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }


    class Calculadora
    {
        List<IOperacaoBinaria> operacoes = new List<IOperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }

    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
