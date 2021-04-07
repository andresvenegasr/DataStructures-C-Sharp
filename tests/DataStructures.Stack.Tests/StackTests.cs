using System;
using DataStructures.Collections;
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
        public void Should_inserts_element_at_the_top_of_the_stack()
        {
            // Act
            Stack<object> stack = new Stack<object>();
            
            // Assert
            stack.Push("A");
            stack.Push(1);
            stack.Push(typeof(double));
            
            Assert.Equal(3, stack.Count);
        }
        
        [Fact]
        public void Should_throws_InvalidOperationException_if_stack_is_empty()
        {
            var stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Theory]
        [InlineData("ABCDE", "EDFC")]
        [InlineData(1234, 4321)]
        [InlineData(null, null)]
        public void Should_get_last_element_added(object firstItem, object secondItem)
        {
            // Arrange
            Stack<object> stack = new Stack<object>();
            
            // Act
            stack.Push(firstItem);
            stack.Push(secondItem);
            
            // Assert
            Assert.Equal(secondItem, stack.Pop());
            Assert.Equal(firstItem, stack.Pop());
            Assert.Equal(0, stack.Count);
        }
    }
}