using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite mapa = new Composite("MAPA DAS CAVERNAS");

            Composite caverna1 = new Composite("Caverna 1");
            caverna1.Adicionar(new FaseJogo("Sub Fase 1"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 2"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 3"));

            Composite caverna2 = new Composite("Caverna 2");
            caverna2.Adicionar(new FaseJogo("Sub Fase 4"));
            caverna2.Adicionar(new FaseJogo("Sub Fase 5"));

            Composite portaSecreta = new Composite("Porta Secreta");
            portaSecreta.Adicionar(new FaseJogo("Sub Fase secreta X"));
            caverna2.Adicionar(portaSecreta);

            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);
            mapa.Mostrar(1);
        }
    }
}
