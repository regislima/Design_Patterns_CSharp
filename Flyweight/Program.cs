using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyweight flyweight = new Flyweight();
            Tartaruga tartaruga;
            string cor;

            while (true)
            {
                Console.WriteLine();
                Console.Write("Qual tartaruga enviar para tela: ");
                cor = Console.ReadLine();

                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("-------------------");
            }
        }
    }
}
