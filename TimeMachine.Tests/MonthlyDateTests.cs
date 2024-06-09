using FluentAssertions;

namespace TimeMachine.Tests
{
    public class MonthlyDateTests
    {
        [Fact]
        public void Init_ShouldCreateMonthlyDate()
        {
            // Arrange
            int year = 2023;
            MonthOfYear month = MonthOfYear.Jan;
            DayOfMonth day = DayOfMonth.First;

            // Act
            var monthlyDate = MonthlyDate.Init(year, month, day);

            // Assert
            monthlyDate.Year.Should().Be(year);
            monthlyDate.MonthOfYear.Should().Be(month);
            monthlyDate.DayOfMonth.Should().Be(day);
        }

        [Fact]
        public void OnDay_ShouldSetDayOfMonth()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            DayOfMonth newDay = DayOfMonth.Tenth;

            // Act
            var updatedDate = monthlyDate.OnDay(newDay);

            // Assert
            updatedDate.DayOfMonth.Should().Be(newDay);
        }

        [Fact]
        public void AtYear_ShouldSetYear()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int newYear = 2024;

            // Act
            var updatedDate = monthlyDate.AtYear(newYear);

            // Assert
            updatedDate.Year.Should().Be(newYear);
        }

        [Fact]
        public void MonthsFromNow_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int months = 5;
            var expectedDate = monthlyDate.LetsGo().AddMonths(months);

            // Act
            var newMonthlyDate = monthlyDate.MonthsFromNow(months);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newMonthlyDate.DayOfMonth.Should().Be(monthlyDate.DayOfMonth);
        }

        [Fact]
        public void MonthsAgo_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int months = 5;
            var expectedDate = monthlyDate.LetsGo().AddMonths(-months);

            // Act
            var newMonthlyDate = monthlyDate.MonthsAgo(months);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newMonthlyDate.DayOfMonth.Should().Be(monthlyDate.DayOfMonth);
        }

        [Fact]
        public void InMonth_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            MonthOfYear newMonth = MonthOfYear.Dec;

            // Act
            var newMonthlyDate = monthlyDate.InMonth(newMonth);

            // Assert
            newMonthlyDate.Year.Should().Be(monthlyDate.Year);
            newMonthlyDate.MonthOfYear.Should().Be(newMonth);
            newMonthlyDate.DayOfMonth.Should().Be(monthlyDate.DayOfMonth);
        }

        [Fact]
        public void DaysFromNow_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int days = 10;
            var expectedDate = monthlyDate.LetsGo().AddDays(days);

            // Act
            var newMonthlyDate = monthlyDate.DaysFromNow(days);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newMonthlyDate.DayOfMonth.Should().Be((DayOfMonth)expectedDate.Day);
        }

        [Fact]
        public void DaysAgo_ShouldReturnUpdatedMonthlyDate()
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int days = 10;
            var expectedDate = monthlyDate.LetsGo().AddDays(-days);

            // Act
            var newMonthlyDate = monthlyDate.DaysAgo(days);

            // Assert
            newMonthlyDate.Year.Should().Be(expectedDate.Year);
            newMonthlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newMonthlyDate.DayOfMonth.Should().Be((DayOfMonth)expectedDate.Day);
        }
    }
}
