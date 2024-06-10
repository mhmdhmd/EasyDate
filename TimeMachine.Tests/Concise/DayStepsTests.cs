using FluentAssertions;

namespace TimeMachine.Tests.Concise;

public class DayStepsTests
{
    [Fact]
    public void After_ShouldAddDaysCorrectly()
    {
        // Arrange
        var daySteps = new DaySteps(10);
        var date = new DateTime(2023, 6, 10);

        // Act
        var result = daySteps.After(date);

        // Assert
        result.Should().Be(new DateTime(2023, 6, 20));
    }

    [Fact]
    public void Before_ShouldSubtractDaysCorrectly()
    {
        // Arrange
        var daySteps = new DaySteps(5);
        var date = new DateTime(2023, 6, 10);

        // Act
        var result = daySteps.Before(date);

        // Assert
        result.Should().Be(new DateTime(2023, 6, 5));
    }

    [Fact]
    public void Later_ShouldReturnCorrectFutureDate()
    {
        // Arrange
        var daySteps = new DaySteps(15);
        var now = DateTime.Now;

        // Act
        var result = daySteps.Later();

        // Assert
        result.Should().BeCloseTo(now.AddDays(15), precision: TimeSpan.FromSeconds(1));
    }

    [Fact]
    public void Ago_ShouldReturnCorrectPastDate()
    {
        // Arrange
        var daySteps = new DaySteps(20);
        var now = DateTime.Now;

        // Act
        var result = daySteps.Ago();

        // Assert
        result.Should().BeCloseTo(now.AddDays(-20), precision: TimeSpan.FromSeconds(1));
    }
}