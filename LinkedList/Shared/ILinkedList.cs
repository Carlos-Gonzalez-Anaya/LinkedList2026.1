namespace Shared
{
    public interface ILinkedList<T>
    {
        bool Contains(T data);
        void InsertAtBegginning(T data);
        void InsertAtEndinning(T data);
        void Remove(T data);
        void Reverse();
        string ToString();
    }
}
