using System;

namespace Template_Method
{
    public abstract class Jogo
    {
        protected Jogo()
        {
            TrilhaSonora();
            PrimeiraFase();
            SegundaFase();
        }

        public abstract void PrimeiraFase();

        public abstract void SegundaFase();

        public void TrilhaSonora()
        {
            Console.WriteLine("Música emocionante");
        }
    }
}