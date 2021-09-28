using Adapter;

namespace Adapter
{
    public class Adapter : IAcao
    {
        private readonly Aviao _aviao;

        public Adapter(Aviao aviao)
        {
            _aviao = aviao;
        }

        public void Andar(string jogador)
        {
            _aviao.Voar(jogador);
        }

        public void Atirar()
        {
            _aviao.SoltarMissil();
        }
    }
}