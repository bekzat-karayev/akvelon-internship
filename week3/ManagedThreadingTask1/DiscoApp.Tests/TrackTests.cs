using System;
using System.Collections.Generic;
using Xunit;

namespace DiscoApp.Tests
{
    public class TrackTests
    {
        [Fact]
        public void Track_ConstructsProperTrackInstance()
        {
            //Arrange
            var trackName = "Yesterday";
            var trackStyle = "Rock";

            //Act
            var track = new Track("Yesterday", "Rock");

            //Assert
            Assert.Equal(trackName, track.Name);
            Assert.Equal(trackStyle, track.Style);
        }
    }
}
