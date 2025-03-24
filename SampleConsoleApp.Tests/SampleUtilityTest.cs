using SampleConsoleApp;
using System;
using System.IO;

namespace SampleConsoleApp.Tests
{
    public class SampleUtilityTest
    {
        [Fact]
        public void PrintMessage_ShouldPrintMessage()
        {
            // Arrange
            string expectedMessage = "Hello, World!";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                SampleUtility.PrintMessage(expectedMessage);

                // Assert
                var result = sw.ToString().Trim();
                Assert.Equal(expectedMessage, result);
            }
        }
        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = SampleUtility.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
