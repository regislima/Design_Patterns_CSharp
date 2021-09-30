using System;

namespace Template_Method
{
    public class ModoDificil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Adicionar obstáculos na pista");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversários correm mais");
        }
    }
}