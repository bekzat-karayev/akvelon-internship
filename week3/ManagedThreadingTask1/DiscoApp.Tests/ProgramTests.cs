using System;
using System.Threading;
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
            var expected = "Tracklist has ended\r\nDancers go home\r\n" +
                "Press any key to close the disco\r\n";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            Program.CloseDisco();

            //Assert
            Assert.Equal(expected, stringWriter.ToString());
        }

        [Fact]
        public void PlayTrack_PrintsCorrectMessage()
        {
            //Arrange
            var expected = "Now DJ plays Esposito in LATINO style\r\n";
            var track = new Track("Esposito", "Latino");
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            Program.PlayTrack(track);

            //Assert
            Assert.Equal(expected, stringWriter.ToString());
        }

        [Fact]
        public void Dance_PrintsCorrectMessage()
        {
            //Arrange
            var expected = "Dancer is moving elbows\r\n";
            var track = new Track("Track 69", "Hardbass");
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            Thread.CurrentThread.Name = "Dancer";
            Program.Dance(track);

            //Assert
            Assert.Equal(expected, stringWriter.ToString());
        }

        [Fact]
        public void GenerateTrack_CreatesProperTrack()
        {
            //Arrange
            var id = 21;
            var trackRock = new Track("Track 21", "Rock");
            var trackLatino = new Track("Track 21", "Latino");
            var trackHardbass = new Track("Track 21", "Hardbass");

            //Act
            var track = Program.GenerateTrack(id);

            //Assert
            Assert.True(track.Name == trackRock.Name);
            Assert.True(track.Style == trackRock.Style || track.Style == trackLatino.Style
                || track.Style == trackHardbass.Style);
        }

        [Fact]
        public void PlayMusic_HandlesEmptyTracklist()
        {
            //Arrange
            var expected = "";
            var tracklist = new List<Track>();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //Act
            Program.PlayMusic(tracklist);

            //Assert
            Assert.Equal(expected, stringWriter.ToString());
        }

    }
}