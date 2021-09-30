using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFase proxy = new ProxyFase();
            Console.WriteLine("#### Tentando acessar a fase do jogo com password incorreto ####");
            Console.WriteLine(proxy.InformarPassword("12345"));
            Console.WriteLine(proxy.Jogar());
            
            Console.WriteLine();

            Console.WriteLine("#### Tentando acessar a fase do jogo com password correto ####");
            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Jogar());
        }
    }
}
