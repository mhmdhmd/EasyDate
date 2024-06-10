using FluentAssertions;

namespace TimeMachine.Tests.Concise;

public class YearStepsTests
{
    [Fact]
    public void After_ShouldAddYearsCorrectly()
    {
        // Arrange
        var yearSteps = new YearSteps(2);
        var date = new DateTime(2022, 6, 10);

        // Act
        var result = yearSteps.After(date);

        // Assert
        result.Should().Be(new DateTime(2024, 6, 10));
    }

    [Fact]
    public void Before_ShouldSubtractYearsCorrectly()
    {
        // Arrange
        var yearSteps = new YearSteps(3);
        var date = new DateTime(2022, 6, 10);

        // Act
        var result = yearSteps.Before(date);

        // Assert
        result.Should().Be(new DateTime(2019, 6, 10));
    }

    [Fact]
    public void Later_ShouldReturnCorrectFutureDate()
    {
        // Arrange
        var yearSteps = new YearSteps(1);
        var now = DateTime.Now;

        // Act
        var result = yearSteps.Later();

        // Assert
        result.Should().BeCloseTo(now.AddYears(1), precision: TimeSpan.FromSeconds(1));
    }

    [Fact]
    public void Ago_ShouldReturnCorrectPastDate()
    {
        // Arrange
        var yearSteps = new YearSteps(1);
        var now = DateTime.Now;

        // Act
        var result = yearSteps.Ago();

        // Assert
        result.Should().BeCloseTo(now.AddYears(-1), precision: TimeSpan.FromSeconds(1));
    }
}