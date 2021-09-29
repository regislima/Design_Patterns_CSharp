namespace Decorator
{
    public class DecoratorArmadura : MoldeArmadura
    {
        private string _descricao = "Decorador abstrato da armadura do personagem";

        public override string Descricao
        {
            get => _descricao;
        }
    }
}