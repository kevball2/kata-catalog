namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void StringIsEmpty_Return0()
        {
            int result = StringCalculator.Add("");
            result.Should().Be(0);
        }

        [Fact]
        public void IfStringHas1Integer_ReturnInteger()
        {

            int result = StringCalculator.Add("1");
            result.Should().Be(1);
        }

        [Fact]
        public void IfStringHas2Integers_ReturnSumOfIntegers()
        {

            int result = StringCalculator.Add("1,1");
            result.Should().Be(2);
        }

        [Fact]
        public void IfStringHas3Integers_ReturnSumOfIntegers()
        {

            int result = StringCalculator.Add("1,1,1");
            result.Should().Be(3);
        }

        [Fact]
        public void IfStringHasNewLineDelimiter_ReturnSumOfIntegers()
        {

            int result = StringCalculator.Add("5\n5,5");
            result.Should().Be(15);
        }

        [Fact]
        public void IfStringBeginsWithNewDelimiter_ReturnSumOfIntegers()
        {

            Action action = () => StringCalculator.Add("//;\n5\n5,5;5").Should();
            
            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("");
        }
    }
}