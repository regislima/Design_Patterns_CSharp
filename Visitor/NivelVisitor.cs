using System;

namespace Visitor
{
    public class NivelVisitor : IVisitor
    {
        public void Identificar(Chefao chefao)
        {
            switch (chefao.NomeChefao)
            {
                case "Boss 1":
                    Console.WriteLine("O chefão {0} é {1}% difícil e tem {2} pontos de vida.", chefao.NomeChefao, 25, chefao.PontosVida);
                    break;

                case "Boss 2":
                    Console.WriteLine($"O chefão {chefao.NomeChefao} é 50% difícil e tem {chefao.PontosVida} pontos de vida.");
                    break;
            }
        }

        public void Identificar(FaseJogo faseJogo)
        {
            switch (faseJogo.NomeFase)
            {
                case "Floresta":
                    Console.WriteLine($"A fase {faseJogo.NomeFase} no jogo é 70% difícil.");
                    break;
                
                case "Caverna":
                    Console.WriteLine($"A fase {faseJogo.NomeFase} no jogo é 30% difícil.");
                    break;
            }
        }
    }
}