namespace Builder
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo");
        }

        public override void Foco()
        {
            _soldado.Definirfoco("Resposta rápida aérea");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicoptero de ataque do exército");
        }
    }
}