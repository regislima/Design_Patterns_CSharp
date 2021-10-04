namespace Iterator
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int indexItem] { get; set; }
        int Contador { get; }
    }
}