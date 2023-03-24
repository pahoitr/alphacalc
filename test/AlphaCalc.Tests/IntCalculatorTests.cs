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
}