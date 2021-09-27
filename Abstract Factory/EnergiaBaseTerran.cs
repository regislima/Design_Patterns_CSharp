using System;

namespace Abstract_Factory
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base macânica");
        }
    }
}