﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    interface IPonto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : IPonto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine($"X = {coordenadaInicial.X}");
            Console.WriteLine($"Y = {coordenadaInicial.Y}");

            Coordenada coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine($"X = {coordenadaFinal.X}");
            Console.WriteLine($"Y = {coordenadaFinal.Y}");
        }
    }
}