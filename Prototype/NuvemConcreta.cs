using System;

namespace Prototype
{
    public class NuvemConcreta : NuvemMolde
    {
        private string _corPreenchimento;
        private string _corContorno;

        public NuvemConcreta(string corPreenchimento, string corContorno)
        {
            _corPreenchimento = corPreenchimento;
            _corContorno = corContorno;
        }

        public override NuvemMolde Clone()
        {
            Console.WriteLine($"A nuvem clonada tem contorno {_corContorno} e preenchimento {_corPreenchimento}");

            return this.MemberwiseClone() as NuvemMolde;
        }
    }
}