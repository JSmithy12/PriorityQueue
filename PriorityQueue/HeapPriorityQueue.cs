using PriorityQueue;

class HeapPriorityQueue<T> : PriorityQueue<T>
{
    private (T item, int priority)[] heap;
    private int size;

    public HeapPriorityQueue(int capacity)
    {
        heap = new (T, int)[capacity];
        size = 0;
    }

    public void Add(T item, int priority)
    {
        if (size >= heap.Length)
            throw new QueueOverflowException();
        heap[size] = (item, priority);
        size++;
    }

    public T Head()
    {
        if (size == 0)
            throw new QueueUnderflowException();
        return heap[0].item;
    }

    public void Remove()
    {
        if (size == 0)
            throw new QueueUnderflowException();
        size--;
    }

    public bool IsEmpty() => size == 0;
}