using System;

namespace Facade
{
    public class Facade
    {
        private SubsistemaUm um;
        private SubsistemaDois dois;
        private SubsistemaTres tres;

        public Facade()
        {
            this.um = new SubsistemaUm();
            this.dois = new SubsistemaDois();
            this.tres = new SubsistemaTres();
        }

        public void OperacaoA()
        {
            Console.WriteLine("\nOperação A ------- ");
            this.um.Responsabilidade();
            this.dois.Responsabilidade();
        }

        public void OperacaoB()
        {
            Console.WriteLine("\nOperação B ------- ");
            this.tres.Responsabilidade();
        }
    }
}