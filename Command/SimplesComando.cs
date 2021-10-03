using System;

namespace Command
{
    public class SimplesComando : ICommand
    {
        private string _solicitacao;

        public SimplesComando(string solicitacao)
        {
            _solicitacao = solicitacao;
        }

        public void Executar()
        {
            Console.WriteLine("Estou executando um Simples Comando de {0}", this._solicitacao);
        }
    }
}