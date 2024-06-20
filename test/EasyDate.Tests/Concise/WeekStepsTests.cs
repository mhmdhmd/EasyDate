using FluentAssertions;

namespace EasyDate.Tests.Concise;

public class WeekStepsTests
{
    [Fact]
    public void After_ShouldAddWeeksCorrectly()
    {
        // Arrange
        var weekSteps = new WeekSteps(3);
        var date = new DateTime(2023, 6, 10);

        // Act
        var result = weekSteps.After(date);

        // Assert
        result.Should().Be(new DateTime(2023, 7, 1));
    }

    [Fact]
    public void Before_ShouldSubtractWeeksCorrectly()
    {
        // Arrange
        var weekSteps = new WeekSteps(2);
        var date = new DateTime(2023, 6, 10);

        // Act
        var result = weekSteps.Before(date);

        // Assert
        result.Should().Be(new DateTime(2023, 5, 27));
    }

    [Fact]
    public void Later_ShouldReturnCorrectFutureDate()
    {
        // Arrange
        var weekSteps = new WeekSteps(4);
        var now = DateTime.Now;

        // Act
        var result = weekSteps.Later();

        // Assert
        result.Should().BeCloseTo(now.AddDays(4 * 7), precision: TimeSpan.FromSeconds(1));
    }

    [Fact]
    public void Ago_ShouldReturnCorrectPastDate()
    {
        // Arrange
        var weekSteps = new WeekSteps(5);
        var now = DateTime.Now;

        // Act
        var result = weekSteps.Ago();

        // Assert
        result.Should().BeCloseTo(now.AddDays(-5 * 7), precision: TimeSpan.FromSeconds(1));
    }

    [Fact]
    public void FromNow_ShouldAddWeeksCorrectly()
    {
        // Arrange
        var weekSteps = new WeekSteps(10);
        var now = DateTime.Now;

        // Act
        var result = weekSteps.FromNow();

        // Assert
        result.Should().BeCloseTo(now.AddDays(10 * 7), precision: TimeSpan.FromSeconds(1));
    }
}