﻿using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Cody cody = new Cody();

            Inimigo inimigo1 = new Inimigo(cody);
            Inimigo inimigo2 = new Inimigo(cody);
            Inimigo inimigo3 = new Inimigo(cody);

            while (true)
            {
                Console.WriteLine("Acertar Cody com um golpe (S ou N)?");

                if(Console.ReadLine() == "s")
                    cody.GolpeAcertado(true);
                else
                    Console.WriteLine("Você não acertou o golpe");
            }
        }
    }
}
