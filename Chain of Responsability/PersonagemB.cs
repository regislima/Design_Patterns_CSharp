using System;

namespace Chain_of_Responsability
{
    public class PersonagemB : Manipulador
    {
        public override void Convoca(int quantidadDePoder)
        {
            if (quantidadDePoder >= 10 && quantidadDePoder < 20)
                Console.WriteLine($"{this.GetType().Name} convocado para uma força de poder de {quantidadDePoder}");
            else if (sucessor != null)
                sucessor.Convoca(quantidadDePoder);
        }
    }
}