namespace Stack.Lib;

public class ArrayStack<T> : IStack<T>
{
    private T[] _items;
    private readonly int _count = 0;

    public ArrayStack(int capacity)
    {
        _items = new T[capacity];
    }

    public bool IsEmpty => _count == 0;

    public bool IsFull => _count == _items.Length;

    public int Count => _count;

    public int Capacity => _items.Length;

    public void Push(T item)
    {
        if (_count == _items.Length)
        {
            throw new InvalidOperationException();
        }
    }

    public T Pop()
    {
        throw new NotImplementedException();
    }

    public T Peek()
    {
        throw new NotImplementedException();
    }
}
