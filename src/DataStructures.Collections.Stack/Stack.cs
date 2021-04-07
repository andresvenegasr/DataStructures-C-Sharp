using System;

namespace DataStructures.Collections.Stack
{
    /// <summary>
    /// Stack data structure implementation.
    /// </summary>
    /// <typeparam name="T">T represents the object type to store in the stack collection</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// Defines the collection default size
        /// </summary>
        private const int _defaultSize = 5;
        /// <summary>
        /// Storage for the items in the stack
        /// </summary>
        private readonly T[] _collection;
        /// <summary>
        /// Number of the items in the collection
        /// </summary>
        private readonly int _size;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack{T}"/> class.
        /// </summary>
        public Stack()
        {
            _collection = new T[_defaultSize];
            _size = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack{T}"/> class and has the specified initial size of the collection.
        /// If the initial size is less than default capacity, sets the initial size with the default capacity.
        /// </summary>
        /// <param name="initialSize">Initial stack size</param>
        /// <exception cref="ArgumentOutOfRangeException">Throws if initialSize is less than zero.</exception>
        public Stack(int initialSize)
        {
            if (initialSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialSize), StackExceptionsStrings.ArgumentOutOfRange_NegativeNumber);
            }

            if (initialSize == 0)
            {
                initialSize = 1;
            }

            _collection = new T[initialSize];
            _size = 0;
        }

        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException(StackExceptionsStrings.EmptyStack);
            }

            return _collection[_size];
        }
    }
}