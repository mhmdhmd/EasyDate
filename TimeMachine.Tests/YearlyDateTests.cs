using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMachine.Enums;

namespace TimeMachine.Tests
{
    public class YearlyDateTests
    {
        [Fact]
        public void Init_Returns_YearlyDateInstance_WithCorrectYear()
        {
            // Arrange
            var expectedYear = 2024;

            // Act
            var yearlyDate = YearlyDate.Init(expectedYear);

            // Assert
            yearlyDate.Should().NotBeNull();
            yearlyDate.Should().BeOfType<YearlyDate>();
            yearlyDate.Year.Should().Be(expectedYear);
            yearlyDate.MonthOfYear.Should().Be(Months.Jan);
            yearlyDate.DayOfMonth.Should().Be(DayOfMonth.First);
        }

        [Fact]
        public void InMonth_Sets_MonthOfYear_Correctly()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2024);
            var expectedMonth = Months.May;

            // Act
            yearlyDate.InMonth(expectedMonth);

            // Assert
            yearlyDate.MonthOfYear.Should().Be(expectedMonth);
        }

        [Fact]
        public void OnDay_Sets_DayOfMonth_Correctly()
        {
            // Arrange
            var yearlyDate = YearlyDate.Init(2024);
            var expectedDayOfMonth = DayOfMonth.Twentieth;

            // Act
            yearlyDate.OnDay(expectedDayOfMonth);

            // Assert
            yearlyDate.DayOfMonth.Should().Be(expectedDayOfMonth);
        }

        [Fact]
        public void LetsGo_Returns_CorrectDateTime_ForSpecificDay()
        {
            // Arrange
            var expectedYear = 2024;
            var expectedMonth = Months.Mar;
            var expectedDayOfMonth = DayOfMonth.Tenth;
            var yearlyDate = YearlyDate.Init(expectedYear).InMonth(expectedMonth).OnDay(expectedDayOfMonth);
            var expectedDateTime = new DateTime(expectedYear, (int)expectedMonth, (int)expectedDayOfMonth);

            // Act
            var dateTime = yearlyDate.LetsGo();

            // Assert
            dateTime.Should().Be(expectedDateTime);
        }

        [Fact]
        public void LetsGo_Returns_CorrectDateTime_ForLastDay()
        {
            // Arrange
            var expectedYear = 2024;
            var expectedMonth = Months.Feb;
            var yearlyDate = YearlyDate.Init(expectedYear).InMonth(expectedMonth).OnDay(DayOfMonth.Last);
            var lastDayOfMonth = DateTime.DaysInMonth(expectedYear, (int)expectedMonth);
            var expectedDateTime = new DateTime(expectedYear, (int)expectedMonth, lastDayOfMonth);

            // Act
            var dateTime = yearlyDate.LetsGo();

            // Assert
            dateTime.Should().Be(expectedDateTime);
        }
    }
}
