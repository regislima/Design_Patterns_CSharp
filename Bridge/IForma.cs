using System;

namespace Bridge
{
    public interface IForma
    {
        ICor ICor { get; set; }
        string Descer();
    }
}