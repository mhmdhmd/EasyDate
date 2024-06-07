using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMachine;

namespace TimeMachine.Tests
{
    public class MonthlyDateTests
    {
        [Fact]
        public void Init_Returns_MonthInstance_WithCorrectMonthAndDay()
        {
            // Arrange
            var expectedMonth = Months.Aug;
            var expectedDayOfMonth = DayOfMonth.Fifteenth;

            // Act
            var month = MonthlyDate.Init(expectedMonth, expectedDayOfMonth);

            // Assert
            month.Should().NotBeNull();
            month.Should().BeOfType<MonthlyDate>();
            month.MonthOfYear.Should().Be(expectedMonth);
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
            month.Year.Should().Be(DateTime.Now.Year);
        }

        [Fact]
        public void AtYear_Sets_Year_Correctly()
        {
            // Arrange
            var month = MonthlyDate.Init(Months.Jan, DayOfMonth.First);
            var expectedYear = 2025;

            // Act
            month.AtYear(expectedYear);

            // Assert
            month.Year.Should().Be(expectedYear);
        }

        [Fact]
        public void LetsGo_Returns_CorrectDateTime_ForSpecificDay()
        {
            // Arrange
            var expectedYear = 2024;
            var expectedMonth = Months.Mar;
            var expectedDayOfMonth = DayOfMonth.Tenth;
            var month = MonthlyDate.Init(expectedMonth, expectedDayOfMonth).AtYear(expectedYear);
            var expectedDateTime = new DateTime(expectedYear, (int)expectedMonth, (int)expectedDayOfMonth);

            // Act
            var dateTime = month.LetsGo();

            // Assert
            dateTime.Should().Be(expectedDateTime);
        }

        [Fact]
        public void LetsGo_Returns_CorrectDateTime_ForLastDay()
        {
            // Arrange
            var expectedYear = 2024;
            var expectedMonth = Months.Feb;
            var month = MonthlyDate.Init(expectedMonth, DayOfMonth.Last).AtYear(expectedYear);
            var lastDayOfMonth = DateTime.DaysInMonth(expectedYear, (int)expectedMonth);
            var expectedDateTime = new DateTime(expectedYear, (int)expectedMonth, lastDayOfMonth);

            // Act
            var dateTime = month.LetsGo();

            // Assert
            dateTime.Should().Be(expectedDateTime);
        }

        [Fact]
        public void OnDay_Sets_DayOfMonth_Correctly()
        {
            // Arrange
            var month = MonthlyDate.Init(Months.Jul, DayOfMonth.First);
            var expectedDayOfMonth = DayOfMonth.Twentieth;

            // Act
            month.OnDay(expectedDayOfMonth);

            // Assert
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10000)]
        public void AtYear_Throws_InvalidYearException_ForOutOfRangeYear(int year)
        {
            // Arrange
            var monthlyDate = MonthlyDate.Init(Months.May, DayOfMonth.Fifteenth);

            // Act
            Action act = () => monthlyDate.AtYear(year);

            // Assert
            act.Should().Throw<InvalidYearException>()
                .WithMessage($"The year {year} is out of the valid range (1-9999).");
        }
    }
}
