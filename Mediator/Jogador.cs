namespace Mediator
{
    public abstract class Jogador
    {
        protected Mediador mediador;

        protected Jogador(Mediador mediador)
        {
            this.mediador = mediador;
        }
    }
}