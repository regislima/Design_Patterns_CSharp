﻿using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate colecaoDeFases = new Aggregate();
            colecaoDeFases[0] = "Fase 1";
            colecaoDeFases[1] = "Fase 2";
            colecaoDeFases[2] = "Fase 3";
            colecaoDeFases[3] = "Fase 4";
            colecaoDeFases[4] = "Fase 5";

            IIterator iterator = colecaoDeFases.GetIterator();

            for (string s = iterator.PrimeiroItem; iterator.EstaPronto == false; s = iterator.ProximoItem)
            {
                Console.WriteLine(s);
            }
        }
    }
}
