using System;
using DataStructures.Collections.Stack;
using Xunit;

namespace DataStructures.Stack.Tests
{
    public class StackTests
    {
        [Fact]
        public void Should_throws_ArgumentOutOfRange_if_initialSize_is_less_than_zero()
        {
            // assert
            var argumentOutOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(() => new Stack<object>(-10));
            Assert.Equal("Non-Negative number required (Parameter 'initialSize')", argumentOutOfRangeException.Message);
        }
        
        [Fact]
        public void Should_throws_InvalidOperationException_if_stack_is_empty()
        {
            var stack = new Stack<int>(6);

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }
    }
}