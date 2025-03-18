using System;

public interface IPriorityQueue<T> where T : IComparable<T>
{
    void Add(T item, int priority); 
	void Remove();
	T Peek();
	bool isEmpty();
}
