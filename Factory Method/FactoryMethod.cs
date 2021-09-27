using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Factory_Method
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang": return new LiuKang();
                case "Scorpion": return new Scorpion();
                case "Sub Zero": return new SubZero();
                case "Raiden": return new Raiden();
                default: return null;
            }
        }
    }
}