using System;
using System.Collections.Generic;
using Xunit;
using SelectMethod;

namespace SelectMethodTesting
{
    public class UnitTest1
    {
        [Fact]
        public void AddOneToEachItemFiveItems()
        {
            {
                //Arrange
                var numbers = new List<int> { 1, 2, 3, 4, 5 };
                //Act
                var changedNumbers = numbers.ToSelect(items => items + 1);
                //Assert
                var correctNumbers = new List<int> { 2, 3, 4, 5, 6 };
                Assert.Equal(correctNumbers, changedNumbers);
            }
        }

        [Fact]
        public void DetuctOneArrayFourItems()
        {
            //Arrange
            var numbers = new int[] { 2, 3, 4, 5 };
            //Act
            var changedNumbers = numbers.ToSelect(items => items - 1);
            //Assert
            var correctNumbers = new List<int> { 1, 2, 3, 4 };
         
            Assert.Equal(correctNumbers, changedNumbers);
        }

        [Fact]
        public void MultiplyByFive()
        {
            //Arrange
            var numbers = new List<int> { 1, 2, 3, 4, 5};
            //Act
            var changedNumbers = numbers.ToSelect(items => items * 5);
            //Assert
            var correctNumbers = new List<int> { 5, 10, 15, 20, 25};
            Assert.Equal(correctNumbers, changedNumbers);
        }
        [Fact]
        public void DivisionRemainder()
        {
            //Arrange
            var numbers = new List<int> { 2, 3, 4};
            //Act
            var changedNumbers = numbers.ToSelect(items => items % 3);
            //Assert
            var correctNumbers = new List<int> { 2, 0, 1};
            Assert.Equal(correctNumbers, changedNumbers);
        }

    }
}
