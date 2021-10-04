using System;

namespace Chain_of_Responsability
{
    public class PersonagemC : Manipulador
    {
        public override void Convoca(int quantidadDePoder)
        {
            if (quantidadDePoder >= 20 && quantidadDePoder < 30)
                Console.WriteLine($"{this.GetType().Name} convocado para uma força de poder de {quantidadDePoder}");
            else if (sucessor != null)
                sucessor.Convoca(quantidadDePoder);
        }
    }
}