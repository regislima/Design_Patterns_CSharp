using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridge bridge = new Bridge();
            Random random = new Random();

            void Sortear()
            {
                if (random.Next(2) == 1)
                    bridge.formaSolicitada = new Forma1();
                else
                    bridge.formaSolicitada = new Forma2();
                
                if (random.Next(1, 3) == 1)
                    bridge.formaSolicitada.ICor = new Verde();
                else if (random.Next(1, 3) == 2)
                    bridge.formaSolicitada.ICor = new Laranja();
                else
                    bridge.formaSolicitada.ICor = new Rosa();
            }

            Console.WriteLine("Presione ENTER para enviar uma forma");

            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey();

                if (input.KeyChar == 13)
                    Sortear();
                
                Console.WriteLine();
                bridge.ExibeQualFormaEstaDescendoNaTela();
            }
        }
    }
}
