using System;
using Bridge;

namespace Bridge
{
    public class Bridge
    {
        public IForma formaSolicitada { get; set; }

        public void ExibeQualFormaEstaDescendoNaTela()
        {
            Console.WriteLine(formaSolicitada.Descer());
        }
    }
}