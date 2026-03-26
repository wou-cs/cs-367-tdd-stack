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

        [Fact]
        public void IsFull_ForNewZeroStack_ShouldReturnTrue()
        {
            // Arrange
            var stack = new ArrayStack<int>(0);

            // Act
            var isFull = stack.IsFull;

            // Assert
            Assert.True(isFull);
        }

        [Fact]
        public void Count_ForNewStack_ShouldBeZero()
        {
            // Arrange
            var stack = new ArrayStack<int>(5);

            // Act
            var count = stack.Count;

            // Assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void Capacity_ForNewStack_ShouldEqualAllocation()
        {
            // Arrange
            const int STACKSIZE = 42;
            var stack = new ArrayStack<int>(STACKSIZE);

            // Act & Assert
            Assert.Equal(STACKSIZE, stack.Capacity);
        }

        [Fact]
        public void Count_AfterFirstPush_ShouldBeOne()
        {
            // Arrange
            var stack = new ArrayStack<int>(5);

            // Act
            stack.Push(7);

            // Assert
            Assert.Equal(1, stack.Count);
        }

        [Fact]
        public void Pop_AfterPush_ReturnsPushedValue()
        {
            // Arrange
            const int PUSHEDVALUE = 7;
            var stack = new ArrayStack<int>(5);

            // Act
            stack.Push(PUSHEDVALUE);
            var value = stack.Pop();

            // Assert
            Assert.Equal(PUSHEDVALUE, value);
        }
    }
}
