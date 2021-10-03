﻿using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Controle controle = new Controle();
            controle.EnviarComandoSimples(new SimplesComando("Dizer oi"));

            Receiver receiver = new Receiver();
            controle.EnviarComandoComplexo(new ComplexoComando(receiver, "Abastecer o carro", "Calibrar pneus do carro"));
            controle.fazer();
        }
    }
}
