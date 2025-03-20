using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Tests
{
    public class SortingAlgorithmsTests
    {
        [Fact]
        public void BubbleSort_SortsListCorrectly()
        {
            // Arrange
            List<int> unsorted = new List<int> { 10, 5, 8, 3, 9 };
            var expected = new List<int> { 3, 5, 8, 9, 10 };

            // Act
            SortingAlgorithms.BubbleSort(unsorted);

            // Assert
            Assert.Equal(expected, unsorted);
        }
    }
}
