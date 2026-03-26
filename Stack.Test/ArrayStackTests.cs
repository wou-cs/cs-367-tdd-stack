using System;
using Stack.Lib;

namespace Stack.Test
{
    public class ArrayStackTests
    {
        [Fact]
        public void IsEmpty_ForNewStack_ShouldReturnTrue()
        {
            // Arrange
            var stack = new ArrayStack<int>(5);

            // Act
            var result = stack.IsEmpty;

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Push_WhenStackIsFull_ShouldThrowException()
        {
            // Arrange
            var stack = new ArrayStack<int>(0);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Push(5));
        }
    }
}
