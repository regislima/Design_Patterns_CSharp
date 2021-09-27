using System;

namespace Abstract_Factory
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso");

            new RevestimentoBaseZerg().Composicao();
            new EnergiaBaseZerg().Composicao();
        }
    }
}