using System;

namespace DataStructures.Collections.Stack
{
    public class Stack<T>
    {
        private T[] _collection;
        private int _size;
        
        public Stack()
        {
            _collection = new T[0];
            _size = 0;
        }

        public T Pop()
        {
            if (_collection.Length == 0)
            {
                throw new InvalidOperationException(StackExceptionsStrings.EmptyStack);
            }

            return _collection[_size];
        }
    }
}