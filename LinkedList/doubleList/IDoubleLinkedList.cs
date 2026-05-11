using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleList;

public interface IDoubleLinkedList<T>
{
    bool Contains(T data);
    void InsertAtBegginning(T data);
    void InsertAtEndinning(T data);
    void Remove(T data);
    void Reverse();
    string ToString();
}
