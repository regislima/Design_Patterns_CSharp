namespace Interpreter
{
    public class ArcoEFlecha : IArmamento
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += string.Format(" {0} ", " Arco e Flecha ");
        }
    }
}