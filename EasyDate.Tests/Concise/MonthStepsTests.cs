using FluentAssertions;

namespace EasyDate.Tests.Concise;

public class MonthStepsTests
{
    [Fact]
    public void After_ShouldAddMonthsCorrectly()
    {
        // Arrange
        var monthSteps = new MonthSteps(3);
        var date = new DateTime(2023, 6, 10);

        // Act
        var result = monthSteps.After(date);

        // Assert
        result.Should().Be(new DateTime(2023, 9, 10));
    }

    [Fact]
    public void Before_ShouldSubtractMonthsCorrectly()
    {
        // Arrange
        var monthSteps = new MonthSteps(2);
        var date = new DateTime(2023, 6, 10);

        // Act
        var result = monthSteps.Before(date);

        // Assert
        result.Should().Be(new DateTime(2023, 4, 10));
    }

    [Fact]
    public void Later_ShouldReturnCorrectFutureDate()
    {
        // Arrange
        var monthSteps = new MonthSteps(6);
        var now = DateTime.Now;

        // Act
        var result = monthSteps.Later();

        // Assert
        result.Should().BeCloseTo(now.AddMonths(6), precision: TimeSpan.FromSeconds(1));
    }

    [Fact]
    public void Ago_ShouldReturnCorrectPastDate()
    {
        // Arrange
        var monthSteps = new MonthSteps(5);
        var now = DateTime.Now;

        // Act
        var result = monthSteps.Ago();

        // Assert
        result.Should().BeCloseTo(now.AddMonths(-5), precision: TimeSpan.FromSeconds(1));
    }
}