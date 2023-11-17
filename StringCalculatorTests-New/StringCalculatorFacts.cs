using FluentAssertions;

public class StringCalculatorFacts
{
    [Fact]
    public void Add_PassedEmptyString_Returns_0()
    {
        const int expected = 0;

        int result = StringCalculator.StringCalculator.Add("");

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("3", 3)]
    [InlineData("99", 99)]

    public void Add_PassingSingleNumber_ReturnsNumber(string input, int expected)
    {
        int result = StringCalculator.StringCalculator.Add(input);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("1,1,1", 3)]
    [InlineData("1,1,1,1,1,1,1", 7)]

    public void Add_PassingMultipleNumbers_ReturnsSum(string input, int expected)
    {
        int result = StringCalculator.StringCalculator.Add(input);

        result.Should().Be(expected);
    }

    [Fact]
    public void Add_PassingNewLineArray_ReturnsSum()
    {
        const int expected = 3;

        int result = StringCalculator.StringCalculator.Add("1\n1\n1");

        result.Should().Be(expected);
    }

    [Fact]
    public void Add_WhenPassedSemiColonDelimiter_UsesDelimiterToCalculateSum()
    {
        const int expected = 3;

        int result = StringCalculator.StringCalculator.Add("//;\n1;2");

        result.Should().Be(expected);
    }

    [Fact]
    public void Add_WhenPassedPipeDelimiter_UsesDelimiterToCalculateSum()
    {
        const int expected = 3;

        int result = StringCalculator.StringCalculator.Add("//|\n1|2");

        result.Should().Be(expected);
    }
}