namespace Stack.Lib
{
    /// <summary>
    /// A Stack is a fixed-capacity, last-in-first-out (LIFO) data structure.
    /// </summary>
    /// <remarks>
    /// The Stack must know its capacity up front. Elements are pushed onto
    /// and popped from the top of the stack.
    /// </remarks>
    public interface IStack<T>
    {
        /// <summary>
        /// Pushes an item onto the top of the stack.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// 1. The stack exists
        /// 2. The stack is not full
        /// Post-conditions:
        /// 1. The item is on the top of the stack
        /// 2. Count is incremented by one
        /// 3. IsEmpty returns false
        /// Invariants:
        /// 1. Stack is full - should throw an InvalidOperationException
        /// </remarks>
        /// <param name="item">The item to push</param>
        void Push(T item);

        /// <summary>
        /// Removes and returns the item on the top of the stack.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// 1. The stack is not empty
        /// Post-conditions:
        /// 1. The top item is removed and returned
        /// 2. Count is decremented by one
        /// Invariants:
        /// 1. Stack is empty - should throw an InvalidOperationException
        /// </remarks>
        /// <returns>The item from the top of the stack</returns>
        T Pop();

        /// <summary>
        /// Returns the item on the top of the stack without removing it.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// 1. The stack is not empty
        /// Post-conditions:
        /// 1. The top item is returned
        /// 2. The stack is not modified
        /// Invariants:
        /// 1. Stack is empty - should throw an InvalidOperationException
        /// </remarks>
        /// <returns>The item on the top of the stack</returns>
        T Peek();

        /// <summary>
        /// Returns whether the stack is empty.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// 1. The stack exists
        /// Post-conditions:
        /// 1. Returns true if Count is 0, false otherwise
        /// </remarks>
        bool IsEmpty { get; }

        /// <summary>
        /// Returns whether the stack is full (Count equals Capacity).
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// 1. The stack exists
        /// Post-conditions:
        /// 1. Returns true if Count equals Capacity, false otherwise
        /// </remarks>
        bool IsFull { get; }

        /// <summary>
        /// Returns the current number of items in the stack.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// 1. The stack exists
        /// Post-conditions:
        /// 1. A non-negative integer is returned
        /// </remarks>
        int Count { get; }

        /// <summary>
        /// Returns the maximum number of items the stack can hold.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// 1. The stack exists
        /// Post-conditions:
        /// 1. A positive integer is returned
        /// </remarks>
        int Capacity { get; }
    }
}
