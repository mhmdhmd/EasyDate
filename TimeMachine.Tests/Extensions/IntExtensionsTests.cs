using FluentAssertions;

namespace TimeMachine.Tests.Extensions;

public class IntExtensionsTests
{
    [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void January_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.January(year);
            result.Should().Be(new DateTime(year, 1, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void February_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.February(year);
            result.Should().Be(new DateTime(year, 2, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void March_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.March(year);
            result.Should().Be(new DateTime(year, 3, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void April_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.April(year);
            result.Should().Be(new DateTime(year, 4, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void May_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.May(year);
            result.Should().Be(new DateTime(year, 5, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void June_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.June(year);
            result.Should().Be(new DateTime(year, 6, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void July_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.July(year);
            result.Should().Be(new DateTime(year, 7, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void August_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.August(year);
            result.Should().Be(new DateTime(year, 8, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void September_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.September(year);
            result.Should().Be(new DateTime(year, 9, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void October_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.October(year);
            result.Should().Be(new DateTime(year, 10, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void November_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.November(year);
            result.Should().Be(new DateTime(year, 11, expectedDay));
        }

        [Theory]
        [InlineData(1, 2024, 1)]
        [InlineData(15, 2023, 15)]
        public void December_ShouldReturnCorrectDate(int day, int year, int expectedDay)
        {
            var result = day.December(year);
            result.Should().Be(new DateTime(year, 12, expectedDay));
        }
}