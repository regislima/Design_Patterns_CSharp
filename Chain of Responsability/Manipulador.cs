namespace Chain_of_Responsability
{
    public abstract class Manipulador
    {
        protected Manipulador sucessor;

        public void DefineSucessor(Manipulador sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void Convoca(int quantidadDePoder);
    }
}