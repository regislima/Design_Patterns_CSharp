using System;

namespace Command
{
    public class Controle
    {
        private ICommand _comandoSimles;
        private ICommand _comandoComplexo;

        public void EnviarComandoSimples(ICommand command)
        {
            this._comandoSimles = command;
        }

        public void EnviarComandoComplexo(ICommand command)
        {
            this._comandoComplexo = command;
        }

        public void fazer()
        {
            Console.WriteLine("OK, vou executar para você!");

            if (this._comandoSimles is ICommand)
                this._comandoSimles.Executar();
            
            if (this._comandoComplexo is ICommand)
                this._comandoComplexo.Executar();
        }
    }
}