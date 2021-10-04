namespace State
{
    public class PersonagemA : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.Estado = new PersonagemB();
        }
    }
}