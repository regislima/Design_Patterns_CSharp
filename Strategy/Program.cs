using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajuda papagaio = new Ajuda(new Papagaio());
            Console.WriteLine(papagaio.Ajudar());

            Ajuda sapo = new Ajuda(new Sapo());
            Console.WriteLine(sapo.Ajudar());
        }
    }
}
