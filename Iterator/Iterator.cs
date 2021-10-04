using Iterator;

namespace Iterator
{
    public class Iterator : IIterator
    {
        IAggregate colecao = null;
        int atualIndex = 0;

        public Iterator(IAggregate colecao)
        {
            this.colecao = colecao;
        }

        public string PrimeiroItem
        {
            get
            {
                atualIndex = 0;
                return colecao[atualIndex];
            }
        }

        public string ProximoItem
        {
            get
            {
                atualIndex += 1;

                if (EstaPronto == false)
                {
                    return colecao[atualIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string AtualItem
        {
            get
            {
                return colecao[atualIndex];
            }
        }

        public bool EstaPronto
        {
            get
            {
                if (atualIndex < colecao.Contador)
                {
                    return false;
                }

                return true;
            }
        }
    }
}