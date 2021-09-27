using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            criadorDeSoldado = new CriadorForcasEspeciais();
            new Exercito().ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine($"Soldado com as características: {soldado.Arma}, {soldado.Transporte}, {soldado.Foco}");
            
            criadorDeSoldado = new CriadorDeInfantariaLeve();
            new Exercito().ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine($"Soldado com as características: {soldado.Arma}, {soldado.Transporte}, {soldado.Foco}");
        }
    }
}
