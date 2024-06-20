using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDate.Tests
{
    public class MonthTests
    {
        [Fact]
        public void January_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var january = new January();

            // Assert
            january.Number.Should().Be(1);
        }

        [Fact]
        public void February_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var February = new February();

            // Assert
            February.Number.Should().Be(2);
        }

        [Fact]
        public void March_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var March = new March();

            // Assert
            March.Number.Should().Be(3);
        }

        [Fact]
        public void April_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var April = new April();

            // Assert
            April.Number.Should().Be(4);
        }

        [Fact]
        public void May_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var May = new May();

            // Assert
            May.Number.Should().Be(5);
        }

        [Fact]
        public void June_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var June = new June();

            // Assert
            June.Number.Should().Be(6);
        }

        [Fact]
        public void July_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var July = new July();

            // Assert
            July.Number.Should().Be(7);
        }

        [Fact]
        public void August_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var August = new August();

            // Assert
            August.Number.Should().Be(8);
        }

        [Fact]
        public void September_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var September = new September();

            // Assert
            September.Number.Should().Be(9);
        }

        [Fact]
        public void October_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var October = new October();

            // Assert
            October.Number.Should().Be(10);
        }

        [Fact]
        public void November_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var November = new November();

            // Assert
            November.Number.Should().Be(11);
        }

        [Fact]
        public void December_ShouldSetMonthNumberCorrectly()
        {
            // Arrange
            var December = new December();

            // Assert
            December.Number.Should().Be(12);
        }
    }
}
