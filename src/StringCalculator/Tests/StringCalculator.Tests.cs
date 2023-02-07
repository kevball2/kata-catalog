using System.ComponentModel.DataAnnotations;

namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void IfStringIsEmpty_Return0()
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
    }
}