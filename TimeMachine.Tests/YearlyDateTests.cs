using FluentAssertions;

namespace TimeMachine.Tests
{
    public class YearlyDateTests
    {
        [Fact]
        public void Init_ShouldCreateYearlyDate()
        {
            // Arrange
            int year = 2023;
            MonthOfYear month = MonthOfYear.Jan;
            DayOfMonth day = DayOfMonth.First;

            // Act
            var yearlyDate = YearlyDate.Init(year, month, day);

            // Assert
            yearlyDate.Year.Should().Be(year);
            yearlyDate.MonthOfYear.Should().Be(month);
            yearlyDate.DayOfMonth.Should().Be(day);
        }

        [Fact]
        public void OnDay_ShouldSetDayOfMonth()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            DayOfMonth newDay = DayOfMonth.Tenth;

            // Act
            var updatedDate = yearlyDate.OnDay(newDay);

            // Assert
            updatedDate.DayOfMonth.Should().Be(newDay);
        }

        [Fact]
        public void InMonth_ShouldSetMonthOfYear()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            MonthOfYear newMonth = MonthOfYear.Dec;

            // Act
            var updatedDate = yearlyDate.InMonth(newMonth);

            // Assert
            updatedDate.MonthOfYear.Should().Be(newMonth);
        }

        [Fact]
        public void YearsFromNow_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int years = 5;
            var expectedDate = yearlyDate.LetsGo().AddYears(years);

            // Act
            var newYearlyDate = yearlyDate.YearsFromNow(years);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.MonthOfYear.Should().Be(yearlyDate.MonthOfYear);
            newYearlyDate.DayOfMonth.Should().Be(yearlyDate.DayOfMonth);
        }

        [Fact]
        public void YearsAgo_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int years = 5;
            var expectedDate = yearlyDate.LetsGo().AddYears(-years);

            // Act
            var newYearlyDate = yearlyDate.YearsAgo(years);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.MonthOfYear.Should().Be(yearlyDate.MonthOfYear);
            newYearlyDate.DayOfMonth.Should().Be(yearlyDate.DayOfMonth);
        }

        [Fact]
        public void DaysFromNow_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int days = 10;
            var expectedDate = yearlyDate.LetsGo().AddDays(days);

            // Act
            var newYearlyDate = yearlyDate.DaysFromNow(days);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newYearlyDate.DayOfMonth.Should().Be((DayOfMonth)expectedDate.Day);
        }

        [Fact]
        public void DaysAgo_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int days = 10;
            var expectedDate = yearlyDate.LetsGo().AddDays(-days);

            // Act
            var newYearlyDate = yearlyDate.DaysAgo(days);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newYearlyDate.DayOfMonth.Should().Be((DayOfMonth)expectedDate.Day);
        }

        [Fact]
        public void MonthsFromNow_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int months = 5;
            var expectedDate = yearlyDate.LetsGo().AddMonths(months);

            // Act
            var newYearlyDate = yearlyDate.MonthsFromNow(months);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newYearlyDate.DayOfMonth.Should().Be(yearlyDate.DayOfMonth);
        }

        [Fact]
        public void MonthsAgo_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, MonthOfYear.Jan, DayOfMonth.First);
            int months = 5;
            var expectedDate = yearlyDate.LetsGo().AddMonths(-months);

            // Act
            var newYearlyDate = yearlyDate.MonthsAgo(months);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.MonthOfYear.Should().Be((MonthOfYear)expectedDate.Month);
            newYearlyDate.DayOfMonth.Should().Be(yearlyDate.DayOfMonth);
        }
    }
}
