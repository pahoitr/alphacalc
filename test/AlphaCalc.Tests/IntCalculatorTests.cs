using FluentAssertions;
using Xunit;

namespace AlphaCalc.Tests;

public class IntCalculatorTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 0, 1)]
    [InlineData(0, 1, 1)]
    [InlineData(1, 1, 2)]
    [InlineData(-1, 1, 0)]
    public void Sum_ReturnsExpected(int first, int second, int expected)
    {
        var actual = IntCalculator.Sum(first, second);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 0, 0)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(-1, 1, -1)]
    [InlineData(1, -1, -1)]
    [InlineData(1, 2, 2)]
    [InlineData(2, 1, 2)]
    [InlineData(3, 4, 12)]
    [InlineData(5, 10, 50)]
    public void Multiply_ReturnsExpected(int first, int second, int expected)
    {
        var actual = IntCalculator.Multiply(first, second);

        actual.Should().Be(expected);
    }
}