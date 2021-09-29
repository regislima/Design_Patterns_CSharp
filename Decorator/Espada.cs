namespace Decorator
{
    public class Espada : DecoratorArmadura
    {
        private string _descricao = "Espada de adamantium, ";
        private readonly MoldeArmadura _moldeArmadura;

        public Espada(MoldeArmadura moldeArmadura)
        {
            this._moldeArmadura = moldeArmadura;
        }

        public override string Descricao
        {
            get => _moldeArmadura.Descricao + this._descricao;
        }
    }
}