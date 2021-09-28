using System;

namespace Adapter
{
    public class Aviao
    {
        public void Voar(string personagem)
        {
            Console.WriteLine($"{personagem} voou para frente");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou míssil no jogo");
        }
    }
}