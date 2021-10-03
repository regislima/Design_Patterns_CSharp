using System;

namespace Command
{
    public class Receiver
    {
        public void PrimeiroPedido(string a)
        {
            Console.WriteLine("Comando recebido {0}", a);
        }

        public void SegundoPedido(string b)
        {
            Console.WriteLine("Outro comando recebido {0}", b);
        }
    }
}