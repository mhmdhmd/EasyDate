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
            MonthOfYear month = MonthOfYear.Jan;
            DayOfMonth day = DayOfMonth.First;

            // Act
            var dailyDate = DailyDate.Init(year, month, day);

            // Assert
            dailyDate.Year.Should().Be(year);
            dailyDate.MonthOfYear.Should().Be(month);
            dailyDate.DayOfMonth.Should().Be(day);
        }

        [Fact]
        public void InMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            MonthOfYear newMonth = MonthOfYear.Feb;

            // Act
            var monthlyDate = dailyDate.InMonth(newMonth);

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.MonthOfYear.Should().Be(newMonth);
            monthlyDate.DayOfMonth.Should().Be(dailyDate.DayOfMonth);
        }

        [Fact]
        public void InCurrentMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            var currentMonth = (MonthOfYear)DateTime.Now.Month;

            // Act
            var monthlyDate = dailyDate.InCurrentMonth();

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.MonthOfYear.Should().Be(currentMonth);
            monthlyDate.DayOfMonth.Should().Be(dailyDate.DayOfMonth);
        }

        [Fact]
        public void InNextMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            var nextMonth = (MonthOfYear)DateTime.Now.AddMonths(1).Month;

            // Act
            var monthlyDate = dailyDate.InNextMonth();

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.MonthOfYear.Should().Be(nextMonth);
            monthlyDate.DayOfMonth.Should().Be(dailyDate.DayOfMonth);
        }

        [Fact]
        public void InPrevMonth_ShouldReturnMonthlyDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            var prevMonth = (MonthOfYear)DateTime.Now.AddMonths(-1).Month;

            // Act
            var monthlyDate = dailyDate.InPrevMonth();

            // Assert
            monthlyDate.Year.Should().Be(dailyDate.Year);
            monthlyDate.MonthOfYear.Should().Be(prevMonth);
            monthlyDate.DayOfMonth.Should().Be(dailyDate.DayOfMonth);
        }

        [Fact]
        public void DaysFromNow_ShouldReturnDailyDateWithCorrectDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int days = 10;
            var expectedDate = dailyDate.LetsGo().AddDays(days);

            // Act
            var newDailyDate = dailyDate.DaysFromNow(days);

            // Assert
            newDailyDate.Year.Should().Be(expectedDate.Year);
            newDailyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newDailyDate.DayOfMonth.Should().Be((DayOfMonth)expectedDate.Day);
        }

        [Fact]
        public void DaysAgo_ShouldReturnDailyDateWithCorrectDate()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int days = 10;
            var expectedDate = dailyDate.LetsGo().AddDays(-days);

            // Act
            var newDailyDate = dailyDate.DaysAgo(days);

            // Assert
            newDailyDate.Year.Should().Be(expectedDate.Year);
            newDailyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newDailyDate.DayOfMonth.Should().Be((DayOfMonth)expectedDate.Day);
        }

        [Fact]
        public void InYear_ShouldReturnDailyDateWithNewYear()
        {
            // Arrange
            var dailyDate = DailyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int newYear = 2024;

            // Act
            var newDailyDate = dailyDate.InYear(newYear);

            // Assert
            newDailyDate.Year.Should().Be(newYear);
            newDailyDate.MonthOfYear.Should().Be(dailyDate.MonthOfYear);
            newDailyDate.DayOfMonth.Should().Be(dailyDate.DayOfMonth);
        }
    }
}