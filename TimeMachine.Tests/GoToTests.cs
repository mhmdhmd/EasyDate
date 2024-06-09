using FluentAssertions;

namespace TimeMachine.Tests
{
    public class GoToTests
    {
        [Fact]
        public void FirstDay_ShouldReturnFirstDayOfCurrentMonth()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var result = GoTo.FirstDay();

            // Assert
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be((Month)now.Month);
            result.Day.Should().Be(Day.First);
        }

        [Fact]
        public void LastDay_ShouldReturnLastDayOfCurrentMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var lastDay = DateTime.DaysInMonth(now.Year, now.Month);

            // Act
            var result = GoTo.LastDay();

            // Assert
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be((Month)now.Month);
            result.Day.Should().Be((Day)lastDay);
        }

        [Fact]
        public void Day_ShouldReturnSpecifiedDayOfCurrentMonth()
        {
            // Arrange
            var now = DateTime.Now;
            var specifiedDay = Day.Tenth;

            // Act
            var result = GoTo.Day(specifiedDay);

            // Assert
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be((Month)now.Month);
            result.Day.Should().Be(specifiedDay);
        }

        [Fact]
        public void Today_ShouldReturnToday()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var result = GoTo.Today();

            // Assert
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be((Month)now.Month);
            result.Day.Should().Be((Day)now.Day);
        }

        [Fact]
        public void Yesterday_ShouldReturnYesterday()
        {
            // Arrange
            var yesterday = DateTime.Now.AddDays(-1);

            // Act
            var result = GoTo.Yesterday();

            // Assert
            result.Year.Should().Be(yesterday.Year);
            result.Month.Should().Be((Month)yesterday.Month);
            result.Day.Should().Be((Day)yesterday.Day);
        }

        [Fact]
        public void Tomorrow_ShouldReturnTomorrow()
        {
            // Arrange
            var tomorrow = DateTime.Now.AddDays(1);

            // Act
            var result = GoTo.Tomorrow();

            // Assert
            result.Year.Should().Be(tomorrow.Year);
            result.Month.Should().Be((Month)tomorrow.Month);
            result.Day.Should().Be((Day)tomorrow.Day);
        }

        [Fact]
        public void FirstMonth_ShouldReturnFirstMonthOfCurrentYear()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var result = GoTo.FirstMonth();

            // Assert
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be(Month.Jan);
            result.Day.Should().Be(Day.First);
        }

        [Fact]
        public void LastMonth_ShouldReturnLastMonthOfCurrentYear()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var result = GoTo.LastMonth();

            // Assert
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be(Month.Dec);
            result.Day.Should().Be(Day.First);
        }

        [Fact]
        public void Month_ShouldReturnSpecifiedMonthOfCurrentYear()
        {
            // Arrange
            var now = DateTime.Now;
            var specifiedMonth = Month.Jul;

            // Act
            var result = GoTo.Month(specifiedMonth);

            // Assert
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be(specifiedMonth);
            result.Day.Should().Be(Day.First);
        }

        [Fact]
        public void Year_ShouldReturnFirstDayOfSpecifiedYear()
        {
            // Arrange
            var specifiedYear = 2025;

            // Act
            var result = GoTo.Year(specifiedYear);

            // Assert
            result.Year.Should().Be(specifiedYear);
            result.Month.Should().Be(Month.Jan);
            result.Day.Should().Be(Day.First);
        }
    }
}
