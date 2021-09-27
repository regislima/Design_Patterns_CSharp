namespace Builder
{
    public class SoldadoDeForcasEspeciais : Soldado
    {
        public override void Definirfoco(string foco)
        {
            Foco = foco;
        }

        public override void EscolherArma(string arma)
        {
            Arma = arma;
        }

        public override void EscolherTransporte(string transporte)
        {
            Transporte = transporte;
        }
    }
}