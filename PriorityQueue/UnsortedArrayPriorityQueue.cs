using PriorityQueue;

public class UnsortedArrayPriorityQueue<T> : PriorityQueue<T>
{
    private (T item, int priority)[] _items;
    private int _size;

    public UnsortedArrayPriorityQueue(int capacity)
    {
        _items = new (T, int)[capacity];
        _size = 0;
    }

    public void Add(T item, int priority)
    {
        if (_size >= _items.Length)
            throw new QueueOverflowException();  // Prevent overflow
        _items[_size++] = (item, priority);
    }

    public T Head()
    {
        if (_size == 0)
            throw new QueueUnderflowException();  // Prevent access to empty queue

        int maxIndex = 0;
        for (int i = 1; i < _size; i++)
        {
            if (_items[i].priority > _items[maxIndex].priority)
                maxIndex = i;
        }
        return _items[maxIndex].item;
    }

    public void Remove()
    {
        if (_size == 0)
            throw new QueueUnderflowException();

        int maxIndex = 0;
        for (int i = 1; i < _size; i++)
        {
            if (_items[i].priority > _items[maxIndex].priority)
                maxIndex = i;
        }
        _items[maxIndex] = _items[--_size];  // Replace max priority item with last item
    }

    public bool IsEmpty() => _size == 0;
    public override string ToString() => string.Join(", ", _items[_size]);
}