namespace FizzBuzz.Tests;

// FizzBuzz is a simple number game in which you count, but replace certain numbers with the words "Fizz" and/or "Buzz",
// adhering to certain rules.

// Create a FizzBuzz() method that prints out the numbers 1 through 100, separated by newlines.
// Instead of numbers divisible by 3, the method should output "Fizz".
// Instead of numbers divisible by 5, the method should output "Buzz".
// Instead of numbers divisible by 3 and 5, the method should output "FizzBuzz".
// Extra Credit
// Instead of numbers with a three in them, print "Fizz".
// Instead of numbers with a five in them, print "Buzz".
// Instead of numbers with a three and a five in them, print "FizzBuzz".

public class FizzBuzzTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(4)]
    [InlineData(7)]

    public void NumberNotDivisibleBy3or5_ReturnNumberAsString(int number)
    {
        string result = FizzBuzzGame.NumberCheck(number);

        result.Should().Be(number.ToString());
    }
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void NumberDivisibleBy3_ReturnFizzAsString(int number)
    {

        string result = FizzBuzzGame.NumberCheck(number);
        result.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void NumberDivisibleBy5_ReturnBuzzAsString(int number)
    {

        string result = FizzBuzzGame.NumberCheck(number);
        result.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(60)]
    public void NumberDivisibleBy3And5_ReturnFizzBuzzAsString(int number)
    {

        string result = FizzBuzzGame.NumberCheck(number);
        result.Should().Be("FizzBuzz");
    }

    [Theory]
    [InlineData(13)]
    [InlineData(23)]
    [InlineData(33)]
    public void NumberContains3_ReturnFizzAsString(int number)
    {

        string result = FizzBuzzGame.NumberCheck(number);
        result.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(52)]
    [InlineData(56)]
    [InlineData(59)]
    public void NumberContains5_ReturnBuzzAsString(int number)
    {

        string result = FizzBuzzGame.NumberCheck(number);
        result.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(53)]
    [InlineData(35)]
    public void NumberContains5And3_ReturnFizzBuzzAsString(int number)
    {

        string result = FizzBuzzGame.NumberCheck(number);
        result.Should().Be("FizzBuzz");
    }

}

