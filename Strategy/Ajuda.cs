namespace Strategy
{
    public class Ajuda
    {
        private IAjuda _IAjuda;

        public Ajuda(IAjuda iAjuda)
        {
            _IAjuda = iAjuda;
        }

        public string Ajudar()
        {
            return _IAjuda.Ajudar(this);
        }
    }
}