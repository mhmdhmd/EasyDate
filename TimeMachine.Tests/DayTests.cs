using FluentAssertions;
using TimeMachine.Enums;

namespace TimeMachine.Tests
{
    public class DayTests
    {
        [Fact]
        public void Init_Returns_DayInstance_WithCorrectDayOfMonth()
        {
            // Arrange
            var expectedDayOfMonth = DayOfMonth.First;

            // Act
            var day = Day.Init(expectedDayOfMonth);

            // Assert
            day.Should().NotBeNull();
            day.Should().BeOfType<Day>();
            day.DayOfMonth.Should().Be(expectedDayOfMonth);
        }

        [Fact]
        public void InMonth_Returns_MonthInstance_WithCorrectMonthAndDay()
        {
            // Arrange
            var expectedDayOfMonth = DayOfMonth.Tenth;
            var day = Day.Init(expectedDayOfMonth);
            var expectedMonth = Months.Aug;

            // Act
            var month = day.InMonth(expectedMonth);

            // Assert
            month.Should().NotBeNull();
            month.Should().BeOfType<Month>();
            month.MonthOfYear.Should().Be(expectedMonth);
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
        }

        [Fact]
        public void InCurrentMonth_Returns_MonthInstance_WithCorrectMonthAndDay()
        {
            // Arrange
            var expectedDayOfMonth = DayOfMonth.TwentyFifth;
            var day = Day.Init(expectedDayOfMonth);
            var currentMonth = (Months)DateTime.Now.Month;

            // Act
            var month = day.InCurrentMonth();

            // Assert
            month.Should().NotBeNull();
            month.Should().BeOfType<Month>();
            month.MonthOfYear.Should().Be(currentMonth);
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
        }
    }
}