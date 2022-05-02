using Xunit;
using SingleNumberApp;
using System.Collections;

namespace SingleNumberApp.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(new int[] { 7 }, 7)]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 8, -2, 8, 3, 3, -14, -1, -2, -1 }, -14)]
        public void GetNonRepeatedNumber_GivenArrayOfNumbers_ReturnsCorrectNumber(int[] nums, int expected)
        {
            // Arrange

            // Act
            var actual = Program.GetNonRepeatedNumber(nums);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateHashTable_GivenArrayOfNumbers_GeneratesExpectedHashtable()
        {
            // Arrange 
            var nums = new int[] { 4, 2, 0, 4, 0 };
            var expectedTable = new Hashtable();
            var generatedTable = new Hashtable();
            expectedTable.Add(4, "2");
            expectedTable.Add(2, "1");
            expectedTable.Add(0, "2");

            // Act
            generatedTable = Program.CreateHashtable(nums);

            // Assert
            Assert.Equal(expectedTable, generatedTable);
        }

        [Fact]
        public void LookupValueOne_GivenHashtable_ReturnsKeyThatHasValueOne()
        {
            // Arrange
            int expected = 2;
            int actual;
            var table = new Hashtable();
            table.Add(4, "2");
            table.Add(2, "1");
            table.Add(0, "2");

            // Act
            actual = Program.LookupValueOne(table);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}