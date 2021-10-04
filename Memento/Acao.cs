using System;

namespace Memento
{
    public class Acao
    {
        private string _estado;

        public string Estado
        {
            get => _estado;
            set
            {
                _estado = value;
                Console.WriteLine("Estado do jogo = " + _estado);
            }
        }

        public Memento CriarMemento() => new Memento(_estado);

        public void RestaurarEstado(Memento memento)
        {
            Console.WriteLine("Restaurando o estado...");
            Estado = memento.Estado;
        }
    }
}