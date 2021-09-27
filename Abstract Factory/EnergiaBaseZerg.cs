using System;

namespace Abstract_Factory
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base orgânica");
        }
    }
}