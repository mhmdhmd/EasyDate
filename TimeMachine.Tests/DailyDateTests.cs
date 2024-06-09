using FluentAssertions;

namespace TimeMachine.Tests
{
    public class DailyDateTests
    {
        [Fact]
        public void Init_ShouldCreateDailyDate()
        {
            // Arrange
            int year = 2023;
            Month month = Month.Jan;
            Day day = Day.First;

            // Act
            var dailyDate = DailyDate.Init(year, month, day);

            // Assert
            dailyDate.Year.Should().Be(year);
            dailyDate.Month.Should().Be(month);
            dailyDate.Day.Should().Be(day);
        }

        [Fact]
        public void InMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, Month.Jan, Day.First);
            Month newMonth = Month.Feb;

            // Act
            var monthlyDate = dailyDate.InMonth(newMonth);

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.Month.Should().Be(newMonth);
            monthlyDate.Day.Should().Be(dailyDate.Day);
        }

        [Fact]
        public void InCurrentMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, Month.Jan, Day.First);
            var currentMonth = (Month)DateTime.Now.Month;

            // Act
            var monthlyDate = dailyDate.InCurrentMonth();

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.Month.Should().Be(currentMonth);
            monthlyDate.Day.Should().Be(dailyDate.Day);
        }

        [Fact]
        public void InNextMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, Month.Jan, Day.First);
            var nextMonth = (Month)DateTime.Now.AddMonths(1).Month;

            // Act
            var monthlyDate = dailyDate.InNextMonth();

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.Month.Should().Be(nextMonth);
            monthlyDate.Day.Should().Be(dailyDate.Day);
        }

        [Fact]
        public void InPrevMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, Month.Jan, Day.First);
            var prevMonth = (Month)DateTime.Now.AddMonths(-1).Month;

            // Act
            var monthlyDate = dailyDate.InPrevMonth();

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.Month.Should().Be(prevMonth);
            monthlyDate.Day.Should().Be(dailyDate.Day);
        }

        [Fact]
        public void DaysFromNow_ShouldReturnDailyDateWithCorrectDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, Month.Jan, Day.First);
            int days = 10;
            var expectedDate = dailyDate.LetsGo().AddDays(days);

            // Act
            var newDailyDate = dailyDate.DaysFromNow(days);

            // Assert
            newDailyDate.Year.Should().Be(expectedDate.Year);
            newDailyDate.Month.Should().Be((Month)expectedDate.Month);
            newDailyDate.Day.Should().Be((Day)expectedDate.Day);
        }

        [Fact]
        public void DaysAgo_ShouldReturnDailyDateWithCorrectDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, Month.Jan, Day.First);
            int days = 10;
            var expectedDate = dailyDate.LetsGo().AddDays(-days);

            // Act
            var newDailyDate = dailyDate.DaysAgo(days);

            // Assert
            newDailyDate.Year.Should().Be(expectedDate.Year);
            newDailyDate.Month.Should().Be((Month)expectedDate.Month);
            newDailyDate.Day.Should().Be((Day)expectedDate.Day);
        }

        [Fact]
        public void InYear_ShouldReturnDailyDateWithNewYear()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, Month.Jan, Day.First);
            int newYear = 2024;

            // Act
            var newDailyDate = dailyDate.InYear(newYear);

            // Assert
            newDailyDate.Year.Should().Be(newYear);
            newDailyDate.Month.Should().Be(dailyDate.Month);
            newDailyDate.Day.Should().Be(dailyDate.Day);
        }
    }
}