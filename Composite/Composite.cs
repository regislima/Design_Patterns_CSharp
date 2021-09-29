using System;
using System.Collections.Generic;
using Composite;

namespace Composite
{
    public class Composite : ComponenteFase
    {
        private List<ComponenteFase> fasesDoJogo = new List<ComponenteFase>();

        public Composite(string nome) : base(nome)
        {
        }

        public override void Adicionar(ComponenteFase c)
        {
            this.fasesDoJogo.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);

            foreach (ComponenteFase item in this.fasesDoJogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase c)
        {
            this.fasesDoJogo.Remove(c);
        }
    }
}