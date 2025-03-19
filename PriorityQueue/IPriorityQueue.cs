using System;

public interface IPriorityQueue<T> where T : IComparable<T>
{
    void Add(T item, int priority);  // Add item with priority
    void Remove(); // Remove the highest-priority item
    T Peek(); // Returns the highest-priority item
    bool isEmpty(); // Check if the queue is empty
}
