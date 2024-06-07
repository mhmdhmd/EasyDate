using FluentAssertions;
using TimeMachine.Enums;

namespace TimeMachine.Tests
{
    public class DailyDateTests
    {
        [Fact]
        public void Init_Returns_DayInstance_WithCorrectDayOfMonth()
        {
            // Arrange
            var expectedDayOfMonth = DayOfMonth.First;

            // Act
            var day = DailyDate.Init(expectedDayOfMonth);

            // Assert
            day.Should().NotBeNull();
            day.Should().BeOfType<DailyDate>();
            day.DayOfMonth.Should().Be(expectedDayOfMonth);
        }

        [Fact]
        public void InMonth_Returns_MonthInstance_WithCorrectMonthAndDay()
        {
            // Arrange
            var expectedDayOfMonth = DayOfMonth.Tenth;
            var day = DailyDate.Init(expectedDayOfMonth);
            var expectedMonth = Months.Aug;

            // Act
            var month = day.InMonth(expectedMonth);

            // Assert
            month.Should().NotBeNull();
            month.Should().BeOfType<MonthlyDate>();
            month.MonthOfYear.Should().Be(expectedMonth);
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
        }

        [Fact]
        public void InCurrentMonth_Returns_MonthInstance_WithCorrectMonthAndDay()
        {
            // Arrange
            var expectedDayOfMonth = DayOfMonth.TwentyFifth;
            var day = DailyDate.Init(expectedDayOfMonth);
            var currentMonth = (Months)DateTime.Now.Month;

            // Act
            var month = day.InCurrentMonth();

            // Assert
            month.Should().NotBeNull();
            month.Should().BeOfType<MonthlyDate>();
            month.MonthOfYear.Should().Be(currentMonth);
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
        }
    }
}