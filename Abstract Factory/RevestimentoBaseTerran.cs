using System;

namespace Abstract_Factory
{
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor azul");
        }
    }
}