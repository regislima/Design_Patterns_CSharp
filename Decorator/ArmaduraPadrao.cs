namespace Decorator
{
    public class ArmaduraPadrao : MoldeArmadura
    {
        private string _descricao = "Proteção simples, ";

        public override string Descricao
        {
            get => _descricao;
        }
    }
}