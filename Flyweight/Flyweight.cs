using System.Collections.Generic;

namespace Flyweight
{
    public class Flyweight
    {
        private Dictionary<string, Tartaruga> tartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;

            if (tartarugas.ContainsKey(cor))
                t = tartarugas[cor];
            else
            {
                switch (cor)
                {
                    case "azul":
                        t = new Azul();
                        break;

                    case "verde":
                        t = new Verde();
                        break;

                    case "laranja":
                        t = new Laranja();
                        break;

                    case "vermelha":
                        t = new Vermelha();
                        break;
                }

                tartarugas.Add(cor, t);
            }

            return t;
        }
    }
}