using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMachine.Enums;

namespace TimeMachine.Tests
{
    public class MonthTests
    {
        [Fact]
        public void Init_Returns_MonthInstance_WithCorrectMonthAndDay()
        {
            // Arrange
            var expectedMonth = Months.Aug;
            var expectedDayOfMonth = DayOfMonth.Fifteenth;

            // Act
            var month = Month.Init(expectedMonth, expectedDayOfMonth);

            // Assert
            month.Should().NotBeNull();
            month.Should().BeOfType<Month>();
            month.MonthOfYear.Should().Be(expectedMonth);
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
            month.Year.Should().Be(DateTime.Now.Year);
        }

        [Fact]
        public void AtYear_Sets_Year_Correctly()
        {
            // Arrange
            var month = Month.Init(Months.Jan, DayOfMonth.First);
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
            var month = Month.Init(expectedMonth, expectedDayOfMonth).AtYear(expectedYear);
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
            var month = Month.Init(expectedMonth, DayOfMonth.Last).AtYear(expectedYear);
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
            var month = Month.Init(Months.Jul, DayOfMonth.First);
            var expectedDayOfMonth = DayOfMonth.Twentieth;

            // Act
            month.OnDay(expectedDayOfMonth);

            // Assert
            month.DayOfMonth.Should().Be(expectedDayOfMonth);
        }
    }
}
