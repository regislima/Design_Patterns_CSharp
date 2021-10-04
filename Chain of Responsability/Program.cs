using System;
using System.Linq;

namespace Chain_of_Responsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Manipulador pA = new PersonagemA();
            Manipulador pB = new PersonagemB();
            Manipulador pC = new PersonagemC();

            pA.DefineSucessor(pB);
            pB.DefineSucessor(pC);

            int[] requisicoes = { 5, 8, 15, 20, 18, 3, 27, 20 };

            foreach (int req in requisicoes)
            {
                pA.Convoca(req);
            }
        }
    }
}
