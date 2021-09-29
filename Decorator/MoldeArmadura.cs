namespace Decorator
{
    public abstract class MoldeArmadura
    {
        private string _descricao = "Armadura do personagem abstrata";

        public virtual string Descricao
        {
            get => _descricao;
        }
    }
}