using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma raça: \n{0}\n{1}\n{2}", "1 - Terran", "2 - Protoss", "3 - Zerg");

            switch (Console.ReadLine())
            {
                case "1":
                    new FabricaBaseTerran();
                    break;
                
                case "2":
                    new FabricaBaseProtoss();
                    break;
                
                case "3": 
                    new FabricaBaseZerg();
                    break;
            }
        }
    }
}
