using System;
using ChordCalculator.Core;
using Xunit;

namespace ChordCalculator.Tests
{
    public class ScaleTests
    {
        [Fact]
        public void ShouldCreateCMajorScale()
        {
            //Arrange and act
            var cMajor = new MajorScale(NoteFactory.Do);

            //Assert
            Assert.Equal("C - D - E - F - G - A - B - C", cMajor.Content());
        }

        [Fact]
        public void ShouldCreateAMinorScale()
        {
            //Arrange and act
            var aMinor = new MinorScale(NoteFactory.La);

            //Assert
            Assert.Equal("A - B - C - D - E - F - G - A", aMinor.Content());
        }
    }
}
