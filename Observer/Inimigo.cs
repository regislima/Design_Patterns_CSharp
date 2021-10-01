using System;

namespace Observer
{
    public class Inimigo : IObservador
    {
        private Cody _personagemObservado;

        public Inimigo(Cody cody)
        {
            _personagemObservado = cody;
            _personagemObservado.RegistrarObservador(this);
        }

        public void Avisar(IPersonagem personagem)
        {
            if (personagem == _personagemObservado)
            {
                Console.WriteLine("O cody foi acertado com um golpe, agora sua vida no jogo é: " + _personagemObservado.GetVida());
            }
        }
    }
}