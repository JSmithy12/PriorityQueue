using System;

public class UnsortedArrayPriorityQueue<T> : IPriorityQeueu<T> where T : IComparable<T>
{
    private T[] _items;
    private int _size;

    public UnsortedArrayPriorityQueue(int capacity)
    {
        _items = new T[capacity];
        size = 0; 
    }

    public void Queue(T item)
    {
        if (_size >= _items.Length)
            throw new InvalidOperationException("Queue is full");
        _items[_size++] = item;
    }

    public T Unqueue()
    {
        if (_size == 0)
            throw new InvalidOperationException("Queue is empty");

        int maxIndex = 0;
        for (int i = 1; i < _size; i++)
        {
            if (_items[i].CompareTo(_items[maxIndex] > 0)
                maxIndex = i;
        }

        T maxItem = _items[maxIndex];
        _items[maxIndex] = _items[--size];
        return maxItem;
    }

    public T Peek()
    {
        if (_size == 0)
            throw new InvalidOperationException("Queue is empty");

        int maxIndex = 0;
        for (int i = 1; i < _size; i++)
        {
            if (_items[i].CompareTo(_items[maxIndex]) > 0)
                maxIndex = i;
        }
        reutrn _items[maxIndex]
    }

    public bool isEmpty() => _size == 0;
}
