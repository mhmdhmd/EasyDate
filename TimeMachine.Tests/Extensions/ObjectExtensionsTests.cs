using FluentAssertions;

namespace TimeMachine.Tests.Extensions;

public class ObjectExtensionsTests
{
    [Theory]
    [InlineData(5, 1, 10, 5)]
    [InlineData(-1, 0, 10, 0)]
    [InlineData(15, 1, 10, 10)]
    public void Clamp_ShouldClampIntegerValues(int value, int min, int max, int expected)
    {
        var result = value.Clamp(min, max);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(5.5, 1.0, 10.0, 5.5)]
    [InlineData(-1.0, 0.0, 10.0, 0.0)]
    [InlineData(15.0, 1.0, 10.0, 10.0)]
    public void Clamp_ShouldClampDoubleValues(double value, double min, double max, double expected)
    {
        var result = value.Clamp(min, max);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("apple", "banana", "cherry", "banana")]
    [InlineData("zebra", "ant", "dog", "dog")]
    [InlineData("kiwi", "apple", "mango", "kiwi")]
    public void Clamp_ShouldClampStringValues(string value, string min, string max, string expected)
    {
        var result = value.Clamp(min, max);
        result.Should().Be(expected);
    }

    [Fact]
    public void Clamp_ShouldClampDateTimeValues()
    {
        var value = new DateTime(2024, 6, 14);
        var min = new DateTime(2024, 1, 1);
        var max = new DateTime(2024, 12, 31);
        var expected = new DateTime(2024, 6, 14);

        var result = value.Clamp(min, max);
        result.Should().Be(expected);

        value = new DateTime(2023, 12, 31);
        expected = min;

        result = value.Clamp(min, max);
        result.Should().Be(expected);

        value = new DateTime(2025, 1, 1);
        expected = max;

        result = value.Clamp(min, max);
        result.Should().Be(expected);
    }
}