using System;

namespace Abstract_Factory
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Terrana criada com sucesso");
            
            new RevestimentoBaseTerran().Composicao();
            new EnergiaBaseTerran().Composicao();
        }
    }
}