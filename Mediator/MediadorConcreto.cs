using System.Dynamic;
using System.Windows.Markup;

namespace Mediator
{
    public class MediadorConcreto : Mediador
    {
        private Jogador1 _jogador1;
        private Jogador2 _jogador2;

        public Jogador1 Jogador1
        {
            get => _jogador1;
            set => _jogador1 = value;
        }
        public Jogador2 Jogador2
        {
            get => _jogador2;
            set => _jogador2 = value;
        }

        public override void Enviar(string mensagem, Jogador jogador)
        {
            if (jogador == _jogador2)
                _jogador1.Notificar(mensagem);
            else
                _jogador2.Notificar(mensagem);
        }
    }
}