using System;

namespace Abstract_Factory
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso");

            new RevestimentoBaseProtoss().Composicao();
            new EnergiaBaseProtoss().Composicao();
        }
    }
}