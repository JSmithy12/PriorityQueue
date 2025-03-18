using System;

public interface IPriorityQueue<T> where T : IComparable<T>
{
	void Add(T, item);
	void Remove();
	T Peek();
	bool isEmpty();
}
