using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Veste armadura padrão ##");
            MoldeArmadura armadura = new ArmaduraPadrao();
            Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));
            Console.WriteLine();
            
            Console.WriteLine("## incluir novos itens na armadura (Decorar) ##");
            armadura = new Capacete(armadura);
            armadura = new Espada(armadura);
            Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));
        }
    }
}
