namespace Iterator
{
    public interface IIterator
    {
        string PrimeiroItem { get; }
        string ProximoItem { get; }
        string AtualItem { get; }
        bool EstaPronto { get; }
    }
}