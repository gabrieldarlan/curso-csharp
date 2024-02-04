using System;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * Math.Pow(raio, 2);

            Console.WriteLine($"Valor da área é = {area}");

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine($"Está chovendo {estaChovendo}");

            byte idade = 45;
            Console.WriteLine($"Idade {idade}");

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine($"Saldo de Gols {saldoDeGols}");

            short salario = short.MaxValue;
            Console.WriteLine($"Salário {salario}");

            int menorValor = int.MinValue; // Maios usados dos inteiros
            Console.WriteLine($"Menor inteiro {menorValor}");

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine($"Populacao brasileira {populacaoBrasileira}");

            long menorValorDoLong = long.MinValue;
            Console.WriteLine($"menor valor do long {menorValorDoLong}");

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine($"populacao mundial {populacaoMundial}");


            float precoComputador = 1299.99f;
            Console.WriteLine($"preco computador {precoComputador}");

            double valorDeMercadorDaApple = 1_000_000_000_000.00;
            Console.WriteLine($"valor apple {valorDeMercadorDaApple}");

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine($"valor entre estrelas {distanciaEntreEstrelas}");

            char letra = 'a';
            Console.WriteLine($"Letra a = {letra}");

            string texto = "sejem bem vindos";
            Console.WriteLine($"{texto}");
        }
    }
}

