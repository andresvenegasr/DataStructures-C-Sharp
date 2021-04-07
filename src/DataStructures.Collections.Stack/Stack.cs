using System;

namespace DataStructures.Collections
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
        private T[] _collection;
        /// <summary>
        /// Number of the items in the collection
        /// </summary>
        private int _size;

        /// <summary>
        /// Gets the number of the elements in the stack
        /// </summary>
        public virtual int Count => _size;

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

        /// <summary>
        /// Add items to the top of the stack.
        /// </summary>
        /// <param name="item"><see cref="T"/> to add in the collection</param>
        public void Push(T item)
        {
            _collection[_size++] = item;
        }

        /// <summary>
        /// Removes and returns the object at the top of the <see cref="Stack{T}"/>.
        /// </summary>
        /// <returns><see cref="T"/> object</returns>
        /// <exception cref="InvalidOperationException">Throws if the stack is empty.</exception>
        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException(StackExceptionsStrings.EmptyStack);
            }

            return _collection[--_size];
        }
    }
}