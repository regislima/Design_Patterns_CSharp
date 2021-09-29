using System;

namespace Flyweight
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = "tartaruga dentro do casco";
            this.acao = "rodando no chão";
        }

        public override void Mostra(string cor)
        {
            this.Cor = cor;
            Console.WriteLine($"{condicao}, {acao} - {Cor.ToUpper()}");
        }
    }
}