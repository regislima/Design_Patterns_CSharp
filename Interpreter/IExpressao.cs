using System;

namespace Interpreter
{
    public interface IExpressao
    {
        void Interpretar(Contexto contexto);
    }
}