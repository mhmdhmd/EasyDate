using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMachine.Enums;

namespace TimeMachine.Tests
{
    public class GoToTests
    {
        [Fact]
        public void FirstDay_Returns_DailyDate_WithFirstDayOfMonth()
        {
            // Act
            var dailyDate = GoTo.FirstDay();

            // Assert
            dailyDate.Should().NotBeNull();
            dailyDate.DayOfMonth.Should().Be(DayOfMonth.First);
        }

        [Fact]
        public void LastDay_Returns_DailyDate_WithLastDayOfMonth()
        {
            // Act
            var dailyDate = GoTo.LastDay();

            // Assert
            dailyDate.Should().NotBeNull();
            dailyDate.DayOfMonth.Should().Be(DayOfMonth.Last);
        }

        [Theory]
        [InlineData(DayOfMonth.First)]
        [InlineData(DayOfMonth.Tenth)]
        [InlineData(DayOfMonth.Last)]
        public void Day_Returns_DailyDate_WithSpecifiedDayOfMonth(DayOfMonth dayOfMonth)
        {
            // Act
            var dailyDate = GoTo.Day(dayOfMonth);

            // Assert
            dailyDate.Should().NotBeNull();
            dailyDate.DayOfMonth.Should().Be(dayOfMonth);
        }

        [Fact]
        public void Today_Returns_CurrentDateTime()
        {
            // Act
            var today = GoTo.Today();

            // Assert
            today.Should().BeCloseTo(DateTime.Now, TimeSpan.FromSeconds(1));
        }

        [Fact]
        public void FirstMonth_Returns_MonthlyDate_WithFirstMonthAndFirstDay()
        {
            // Act
            var monthlyDate = GoTo.FirstMonth();

            // Assert
            monthlyDate.Should().NotBeNull();
            monthlyDate.MonthOfYear.Should().Be(Months.Jan);
            monthlyDate.DayOfMonth.Should().Be(DayOfMonth.First);
        }

        [Fact]
        public void LastMonth_Returns_MonthlyDate_WithLastMonthAndFirstDay()
        {
            // Act
            var monthlyDate = GoTo.LastMonth();

            // Assert
            monthlyDate.Should().NotBeNull();
            monthlyDate.MonthOfYear.Should().Be(Months.Dec);
            monthlyDate.DayOfMonth.Should().Be(DayOfMonth.First);
        }

        [Theory]
        [InlineData(Months.Jan)]
        [InlineData(Months.Jun)]
        [InlineData(Months.Dec)]
        public void Month_Returns_MonthlyDate_WithSpecifiedMonthAndFirstDay(Months month)
        {
            // Act
            var monthlyDate = GoTo.Month(month);

            // Assert
            monthlyDate.Should().NotBeNull();
            monthlyDate.MonthOfYear.Should().Be(month);
            monthlyDate.DayOfMonth.Should().Be(DayOfMonth.First);
        }

        [Theory]
        [InlineData(2021)]
        [InlineData(2022)]
        [InlineData(2023)]
        public void Year_Returns_YearlyDate_WithSpecifiedYear(int year)
        {
            // Act
            var yearlyDate = GoTo.Year(year);

            // Assert
            yearlyDate.Should().NotBeNull();
            yearlyDate.Year.Should().Be(year);
            yearlyDate.MonthOfYear.Should().Be(Months.Jan);
            yearlyDate.DayOfMonth.Should().Be(DayOfMonth.First);
        }
    }
}
