using PriorityQueue;

public class SortedLinkedPriorityQueue<T> : PriorityQueue<T>
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
        if (head == null || head.Priority < priority)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null && current.Next.Priority >= priority)
                current = current.Next;
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }

    public T Head()
    {
        if (head == null)
            throw new QueueUnderflowException();
        return head.Data;
    }

    public void Remove()
    {
        if (head == null)
            throw new QueueUnderflowException();
        head = head.Next;
    }

    public bool IsEmpty() => head == null;

    public override string ToString()
    {
        var result = "";
        Node current = head;
        while (current != null)
        {
            result += $"{current.Data}({current.Priority}) -> ";
            current = current.Next;
        }
        return result + "null";
    }
}