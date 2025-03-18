using PriorityQueue;

public class UnsortedLinkedPriorityQueue<T> : PriorityQueue<T>
{
    private class Node
    {
        public T Data;
        public int Priority;
        public Node Next;
        public Node(T data, int priority)
        {
            Data = data;
            Priority = priority;
            Next = null;
        }
    }

    private Node head;

    public void Add(T item, int priority)
    {
        Node newNode = new Node(item, priority);
        newNode.Next = head;
        head = newNode;
    }

    public T Head()
    {
        if (head == null)
            throw new QueueUnderflowException();
        Node maxNode = head;
        Node current = head.Next;
        while (current != null)
        {
            if (current.Priority > maxNode.Priority)
                maxNode = current;
            current = current.Next;
        }
        return maxNode.Data;
    }

    public void Remove()
    {
        if (head == null)
            throw new QueueUnderflowException();
        Node maxNode = head;
        Node maxPrev = null;
        Node current = head;
        Node prev = null;
        while (current != null)
        {
            if (current.Priority > maxNode.Priority)
            {
                maxNode = current;
                maxPrev = prev;
            }
            prev = current;
            current = current.Next;
        }
        if (maxPrev != null)
            maxPrev.Next = maxNode.Next;
        else
            head = head.Next;
    }

    public bool IsEmpty() => head == null;
}
