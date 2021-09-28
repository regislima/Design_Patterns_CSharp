using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem person = new Personagem();
            Adapter adapter = new Adapter(new Aviao());

            Console.WriteLine("--- CAMINHANDO ---");
            person.Andar("Sauron");
            person.Atirar();

            Console.Write("\n");

            Console.WriteLine("--- PEGOU UM AVIÃO NO JOGO ---");
            adapter.Andar("Sauron");
            adapter.Atirar();
        }
    }
}
