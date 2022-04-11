using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using DiscoApp;

namespace DiscoApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void CreateTracklist_ReturnsListOfTracks()
        {
            // Arrange
            var type = typeof(List<Track>);

            // Act
            var list = Program.CreateTracklist();

            // Assert
            Assert.Equal(type, list.GetType());
        }

        [Fact]
        public void OpenDisco_PrintsCorrectMessage()
        {
            //Arrange
            var expected = "Disco opens\r\nDancers enter disco\r\nDJ creates tracklist\r\n";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            Program.OpenDisco();

            //Assert
            Assert.Equal(expected, stringWriter.ToString());
        }

        [Fact]
        public void CloseDisco_PrintsCorrectMessage()
        {
            //Arrange
            var expected = "Tracklist has ended\r\nDancers go home\r\nPress any key to close the disco\r\n";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            Program.CloseDisco();

            //Assert
            Assert.Equal(expected, stringWriter.ToString());
        }
    }
}