namespace Composite
{
    public abstract class ComponenteFase
    {
        protected string nome;

        protected ComponenteFase(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(ComponenteFase c);
        public abstract void Remover(ComponenteFase c);
        public abstract void Mostrar(int profundidade);
    }
}