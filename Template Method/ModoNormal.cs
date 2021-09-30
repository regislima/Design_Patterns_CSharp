using System;

namespace Template_Method
{
    public class ModoNormal : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("O Carro precisa abastecer 1 vez");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros correm na mesma velocidade");
        }
    }
}