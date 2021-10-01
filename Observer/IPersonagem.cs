namespace Observer
{
    public interface IPersonagem
    {
        void RegistrarObservador(IObservador observador);
        void NotificarPersonagem();
    }
}