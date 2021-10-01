using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Mochila mochila = new Mochila(new Corda(), new Binoculos(), new ArcoEFlecha());
            mochila.Interpretar(new Contexto());
        }
    }
}
