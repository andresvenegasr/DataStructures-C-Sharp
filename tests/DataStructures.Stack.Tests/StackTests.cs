using System;
using DataStructures.Collections.Stack;
using Xunit;

namespace DataStructures.Stack.Tests
{
    public class StackTests
    {
        [Fact]
        public void Should_Throws_Exception_If_Is_Empty_When_Try_To_Use_Pop_Method()
        {
            var stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }
    }
}