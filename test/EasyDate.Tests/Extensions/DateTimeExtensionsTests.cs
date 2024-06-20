using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDate.Tests.Extensions
{
    public class DateTimeExtensionsTests
    {
        [Theory]
        [InlineData(14, 2)]
        [InlineData(12, 0)]
        [InlineData(6, 6)]
        [InlineData(18, 6)]
        [InlineData(0, 0)]
        [InlineData(11, 11)]
        public void AM_ShouldReturnCorrectDateTime(int hour, int expectedHour)
        {
            // Arrange
            var date = DateTime.Now.At(hour);

            // Act
            var result = date.AM();

            // Assert
            result.Hour.Should().Be(expectedHour);
        }

        [Theory]
        [InlineData(14, 14)]
        [InlineData(12, 12)]
        [InlineData(6, 18)]
        [InlineData(18, 18)]
        [InlineData(0, 12)]
        [InlineData(11, 23)]
        public void PM_ShouldReturnCorrectDateTime(int hour, int expectedHour)
        {
            // Arrange
            var date = DateTime.Now.At(hour);

            // Act
            var result = date.PM();

            // Assert
            result.Hour.Should().Be(expectedHour);
        }
    }
}
