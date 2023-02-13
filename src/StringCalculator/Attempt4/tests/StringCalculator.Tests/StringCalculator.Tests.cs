using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StringCalculator.Tests;

public class StringCalculatorAdd
{
    [Fact]
    public void StringIsEmpty_Return0()
    {
        int result =  StringCalculatorFunctions.Add("");
        result.Should().Be(0);
    }

    [Fact]
    public void StringHas1Integer_ReturnInteger()
    {

        int result = StringCalculatorFunctions.Add("1");
        result.Should().Be(1);
    }

    [Fact]
    public void StringHas2Integers_ReturnSumOfIntegers()
    {

        int result = StringCalculatorFunctions.Add("1,1");
        result.Should().Be(2);
    }

    [Fact]
    public void StringHas3Integers_ReturnSumOfIntegers()
    {

        int result = StringCalculatorFunctions.Add("1,1,1");
        result.Should().Be(3);
    }

    [Fact]
    public void StringHasNewLineDelimiter_ReturnSumOfIntegers()
    {

        int result = StringCalculatorFunctions.Add("5\n5,5");
        result.Should().Be(15);
    }

    [Fact]
    public void StringBeginsWithNewDelimiter_ReturnSumOfIntegers()
    {

        int result = StringCalculatorFunctions.Add("//;\n5\n5,5;5");
        result.Should().Be(20);
    }

    [Fact]
    public void StringContainsNegativeNumbers1_ReturnListOfNegativeNumbers()
    {       
        Action test1 = () => StringCalculatorFunctions.Add("//;\n-1\n3,-5;5");
        test1.Should().Throw<Exception>()
            .WithMessage("Negatives not allowed: -1, -5");
    }

    [Fact]
    public void StringContainsNegativeNumbers2_ReturnListOfNegativeNumbers()
    {
        Action test2 = () => StringCalculatorFunctions.Add("-1,2");
        test2.Should().Throw<Exception>()
            .WithMessage("Negatives not allowed: -1");
    }

    [Fact]
    public void StringContainsNumberGreaterThan1000_IgnoreNumber()
    {
        int result = StringCalculatorFunctions.Add("1000,2");
        result.Should().Be(1002);
    }

    [Fact]
    public void StringContainsNumberGreaterThan1000WithCustomDelimiter_IgnoreNumber()
    {
        int result = StringCalculatorFunctions.Add("//+\n500,2+1005");
        result.Should().Be(502);
    }

    [Fact]
    public void StringBeginsWithNewDelimiterOfAnySize_ReturnSumOfIntegers()
    {
        int result = StringCalculatorFunctions.Add("//[|||]\n500,2|||100|||1");
        result.Should().Be(603);
    }

    [Fact]
    public void StringBeginsWithMultipleNewDelimiters_ReturnSumOfIntegers()
    {
        int result = StringCalculatorFunctions.Add("//[|][%]\n1|2%3");
        result.Should().Be(6);
    }

    [Fact]
    public void StringBeginsWithMultipleNewDelimitersWithDifferentLengths_ReturnSumOfIntegers()
    {
        int result = StringCalculatorFunctions.Add("//[|][++][%]\n1|2%3++4");
        result.Should().Be(10);
    }

    [Fact]
    public void StringBeginsWithMultipleNewDelimitersWithDifferentLengthsAndNegativeNumbers_ReturnListOfNegativeNumbers()
    {
        Action test = () => StringCalculatorFunctions.Add("//[|][++][%]\n1|2%3++-4++-5");
        test.Should().Throw<Exception>()
            .WithMessage("Negatives not allowed: -4, -5");
    }

}