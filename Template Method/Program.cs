using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = null;

            Console.WriteLine("### Escolha o modo de corrida ###");
            Console.WriteLine("{0}\n{1}\n{2}", "1 - Fácil", "2 - Normal", "3 - Dificíl");
            Console.WriteLine("Suas condições de jogo são: ");

            switch (Console.ReadLine())
            {
                case "1":
                    jogo = new ModoFacil();
                    break;

                case "2":
                    jogo = new ModoNormal();
                    break;

                case "3":
                    jogo = new ModoDificil();
                    break;
            }
        }
    }
}
