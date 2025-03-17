using System;

public class SortedLinkedPriorityQueue<T> : IPriorityQueue<T> where T : IComparable<T>
{
    private Node<T> head;

    public void Queue(T item)
    {
        Node < T > = newNode = new Node<T>(item);
        if (head == null || head.Data.CompareTo(item) < 0)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null && current.Next.Data.CompareTo(item) >= 0)
                current = current.Next;
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }

    public T Unqueue()
    {
        if (head == null)
            throw new InvalidOperationException("Queue is empty");
        T max = head.Data;
        head = head.Next;
        return max;
    }

    public T Peek()
    {
        if (head == null)
            throw new InvalidOperationException("Queue is empty");
        return head.Data;
    }

    public bool IsEmpty() => head == null;
}