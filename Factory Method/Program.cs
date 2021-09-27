using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | Sub Zero | Scorpion | Raiden");
            Console.Write("Escolha seu personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine();

            Console.Write("Você vai jogar com: ");
            personagem.Escolhido();
        }
    }
}
