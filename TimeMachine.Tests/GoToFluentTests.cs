using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMachine;

namespace TimeMachine.Tests
{
    public class GoToFluentTests
    {
        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForSpecificDayAndMonth()
        {
            // Arrange
            var expectedDate = new DateTime(2024, 5, 15);

            // Act
            var dateTime = GoTo.Day(DayOfMonth.Fifteenth).InMonth(Months.May).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForCurrentMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(now.Year, now.Month, 10);

            // Act
            var dateTime = GoTo.Day(DayOfMonth.Tenth).InCurrentMonth().LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForSpecificDayMonthAndYear()
        {
            // Arrange
            var expectedDate = new DateTime(2023, 11, 5);

            // Act
            var dateTime = GoTo.Year(2023).InMonth(Months.Nov).OnDay(DayOfMonth.Fifth).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForLastDayOfMonth()
        {
            // Arrange
            var expectedDate = new DateTime(2024, 2, 29); // Leap year

            // Act
            var dateTime = GoTo.Year(2024).InMonth(Months.Feb).OnDay(DayOfMonth.Last).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForFirstDayOfMonthInSpecifiedYear()
        {
            // Arrange
            var expectedDate = new DateTime(2022, 3, 1);

            // Act
            var dateTime = GoTo.Year(2022).InMonth(Months.Mar).OnDay(DayOfMonth.First).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForCurrentDayInSpecifiedYearAndMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(2025, now.Month, now.Day);

            // Act
            var dateTime = GoTo.Year(2025).InMonth((Months)now.Month).OnDay((DayOfMonth)now.Day).LetsGo();

            // Assert
            dateTime.Should().Be(expectedDate);
        }

        [Fact]
        public void FluentApi_CreatesCorrectDateTime_ForToday()
        {
            // Arrange
            var now = DateTime.Now;
            var expectedDate = new DateTime(now.Year, now.Month, now.Day);

            // Act
            var dateTime = GoTo.Today();

            // Assert
            dateTime.Should().BeCloseTo(expectedDate, TimeSpan.FromHours(24));
        }
    }
}
