using Xunit;
using SingleNumberApp;

namespace SingleNumberApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(new int[] { 7 }, 7)]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 8, -2, 8, 3, 3, -14, -1, -2, -1}, -14)]
        public void GetNonRepeatedNumber_ArrayOfNumbers_ReturnsCorrectNumber(int[] nums, int expected)
        {
            // Arrange

            // Act
            var actual = Program.GetNonRepeatedNumber(nums);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}