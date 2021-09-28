using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorNuvens gerenciador = new GerenciadorNuvens();
            gerenciador["padrão"] = new NuvemConcreta("branco", "azul");
            gerenciador["personalizada"] = new NuvemConcreta("branco", "laranja");

            NuvemConcreta um = gerenciador["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta dois = gerenciador["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta tres = gerenciador["personalizada"].Clone() as NuvemConcreta;
        }
    }
}
