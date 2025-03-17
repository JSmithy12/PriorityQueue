using System;

public interface IPriorityQueue<T> where T : IComparable<T>
{
	void Queue(T, item);
	T UnQueue();
	T Peek();
	bool isEmpty();
}
