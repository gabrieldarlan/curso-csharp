﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            double notaDeCorte = 7.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine($"Nota inválida? {nota > 10.0}");
            Console.WriteLine($"Nota inválida? {nota < 0.0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}");
            Console.WriteLine($"Passou média? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperacao? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");


        }
    }
}
