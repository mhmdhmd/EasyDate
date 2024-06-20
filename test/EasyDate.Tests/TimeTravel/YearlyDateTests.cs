using FluentAssertions;

namespace EasyDate.Tests.TimeTravel
{
    public class YearlyDateTests
    {
        [Fact]
        public void Init_ShouldCreateYearlyDate()
        {
            // Arrange
            const int year = 2023;
            const Month month = Month.January;
            const Day day = Day.First;

            // Act
            var yearlyDate = YearlyDate.Init(year, month, day);

            // Assert
            yearlyDate.Year.Should().Be(year);
            yearlyDate.Month.Should().Be(month);
            yearlyDate.Day.Should().Be(day);
        }

        [Fact]
        public void OnDay_ShouldSetDayOfMonth()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const Day newDay = Day.Tenth;

            // Act
            var updatedDate = yearlyDate.OnDay(newDay);

            // Assert
            updatedDate.Day.Should().Be(newDay);
        }

        [Fact]
        public void InMonth_ShouldSetMonthOfYear()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const Month newMonth = Month.December;

            // Act
            var updatedDate = yearlyDate.InMonth(newMonth);

            // Assert
            updatedDate.Month.Should().Be(newMonth);
        }

        [Fact]
        public void YearsFromNow_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const int years = 5;
            var expectedDate = yearlyDate.LetsGo().AddYears(years);

            // Act
            var newYearlyDate = yearlyDate.YearsFromNow(years);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.Month.Should().Be(yearlyDate.Month);
            newYearlyDate.Day.Should().Be(yearlyDate.Day);
        }

        [Fact]
        public void YearsAgo_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const int years = 5;
            var expectedDate = yearlyDate.LetsGo().AddYears(-years);

            // Act
            var newYearlyDate = yearlyDate.YearsAgo(years);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.Month.Should().Be(yearlyDate.Month);
            newYearlyDate.Day.Should().Be(yearlyDate.Day);
        }

        [Fact]
        public void DaysFromNow_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const int days = 10;
            var expectedDate = yearlyDate.LetsGo().AddDays(days);

            // Act
            var newYearlyDate = yearlyDate.DaysFromNow(days);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.Month.Should().Be((Month)expectedDate.Month);
            newYearlyDate.Day.Should().Be((Day)expectedDate.Day);
        }

        [Fact]
        public void DaysAgo_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const int days = 10;
            var expectedDate = yearlyDate.LetsGo().AddDays(-days);

            // Act
            var newYearlyDate = yearlyDate.DaysAgo(days);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.Month.Should().Be((Month)expectedDate.Month);
            newYearlyDate.Day.Should().Be((Day)expectedDate.Day);
        }

        [Fact]
        public void MonthsFromNow_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const int months = 5;
            var expectedDate = yearlyDate.LetsGo().AddMonths(months);

            // Act
            var newYearlyDate = yearlyDate.MonthsFromNow(months);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.Month.Should().Be((Month)expectedDate.Month);
            newYearlyDate.Day.Should().Be(yearlyDate.Day);
        }

        [Fact]
        public void MonthsAgo_ShouldReturnUpdatedYearlyDate()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2023, Month.January, Day.First);
            const int months = 5;
            var expectedDate = yearlyDate.LetsGo().AddMonths(-months);

            // Act
            var newYearlyDate = yearlyDate.MonthsAgo(months);

            // Assert
            newYearlyDate.Year.Should().Be(expectedDate.Year);
            newYearlyDate.Month.Should().Be((Month)expectedDate.Month);
            newYearlyDate.Day.Should().Be(yearlyDate.Day);
        }
    }
}
