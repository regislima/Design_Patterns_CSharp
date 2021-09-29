namespace Decorator
{
    public class Capacete : DecoratorArmadura
    {
        private string _descricao = "Capacete, ";
        private readonly MoldeArmadura _moldeArmadura;

        public Capacete(MoldeArmadura moldeArmadura)
        {
            this._moldeArmadura = moldeArmadura;
        }

        public override string Descricao
        {
            get => _moldeArmadura.Descricao + this._descricao;
        }
    }
}