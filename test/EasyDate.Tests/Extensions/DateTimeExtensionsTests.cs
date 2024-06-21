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

        [Fact]
        public void IsSaturday_ShouldReturnTrueIfDayIsSaturday()
        {
            // Arrange
            var date = ChangeDayOfWeek(DateTime.Now, DayOfWeek.Saturday);

            // Act
            var expected = date.IsSaturday();

            // Assert
            expected.Should().BeTrue();
        }
        
        [Fact]
        public void IsSunday_ShouldReturnTrueIfDayIsSunday()
        {
            // Arrange
            var date = ChangeDayOfWeek(DateTime.Now, DayOfWeek.Sunday);

            // Act
            var expected = date.IsSunday();

            // Assert
            expected.Should().BeTrue();
        }
        
        [Fact]
        public void IsMonday_ShouldReturnTrueIfDayIsMonday()
        {
            // Arrange
            var date = ChangeDayOfWeek(DateTime.Now, DayOfWeek.Monday);

            // Act
            var expected = date.IsMonday();

            // Assert
            expected.Should().BeTrue();
        }
        
        [Fact]
        public void IsTuesday_ShouldReturnTrueIfDayIsTuesday()
        {
            // Arrange
            var date = ChangeDayOfWeek(DateTime.Now, DayOfWeek.Tuesday);

            // Act
            var expected = date.IsTuesday();

            // Assert
            expected.Should().BeTrue();
        }
        
        [Fact]
        public void IsWednesday_ShouldReturnTrueIfDayIsWednesday()
        {
            // Arrange
            var date = ChangeDayOfWeek(DateTime.Now, DayOfWeek.Wednesday);

            // Act
            var expected = date.IsWednesday();

            // Assert
            expected.Should().BeTrue();
        }
        
        [Fact]
        public void IsThursday_ShouldReturnTrueIfDayIsThursday()
        {
            // Arrange
            var date = ChangeDayOfWeek(DateTime.Now, DayOfWeek.Thursday);

            // Act
            var expected = date.IsThursday();

            // Assert
            expected.Should().BeTrue();
        }
        
        [Fact]
        public void IsFriday_ShouldReturnTrueIfDayIsFriday()
        {
            // Arrange
            var date = ChangeDayOfWeek(DateTime.Now, DayOfWeek.Friday);

            // Act
            var expected = date.IsFriday();

            // Assert
            expected.Should().BeTrue();
        }
        
        public static DateTime ChangeDayOfWeek(DateTime originalDate, DayOfWeek newDayOfWeek)
        {
            int currentDayOfWeek = (int)originalDate.DayOfWeek;
            int targetDayOfWeek = (int)newDayOfWeek;

            int daysDifference = targetDayOfWeek - currentDayOfWeek;
            return originalDate.AddDays(daysDifference);
        }
    }
}
