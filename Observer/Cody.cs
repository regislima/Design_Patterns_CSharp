using System.Collections.Generic;

namespace Observer
{
    public class Cody : IPersonagem
    {
        private List<IObservador> inimigos = new List<IObservador>();
        public int vida = 100;

        public void NotificarPersonagem()
        {
            foreach (IObservador item in inimigos)
            {
                item.Avisar(this);
            }
        }

        public void RegistrarObservador(IObservador observador)
        {
            inimigos.Add(observador);
        }

        public void GolpeAcertado(bool golpe)
        {
            if (golpe)
                vida -= 10;
            
            NotificarPersonagem();
        }

        public int GetVida()
        {
            return vida;
        }
    }
}