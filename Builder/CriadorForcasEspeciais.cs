namespace Builder
{
    public class CriadorForcasEspeciais : CriadorDeSoldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoDeForcasEspeciais();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil de assaulto leve");
        }

        public override void Foco()
        {
            _soldado.Definirfoco("Cambate camuflado");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Avião de transporte");
        }
    }
}