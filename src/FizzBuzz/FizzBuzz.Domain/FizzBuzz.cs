namespace FizzBuzz.Domain;
public static class FizzBuzzGame
{
    public static string NumberCheck(int number)
    {
        string result = number switch
        {
            _ when number.IsDivisibleBy(15) => "FizzBuzz",
            _ when number.IfContainsNumber(5)
                 && number.IfContainsNumber(3) => "FizzBuzz",
            _ when number.IsDivisibleBy(3) => "Fizz",
            _ when number.IsDivisibleBy(5) => "Buzz",
            _ when number.IfContainsNumber(3) => "Fizz",
            _ when number.IfContainsNumber(5) => "Buzz",
            _ => number.ToString(),
        };

        return result;

        //if (number.IsDivisibleBy(15))
        //    return "FizzBuzz";
        //if (number.IfContainsNumber(5) && number.IfContainsNumber(3))
        //    return "FizzBuzz";
        //if (number.IsDivisibleBy(3))
        //    return "Fizz";
        //if (number.IsDivisibleBy(5))
        //    return "Buzz";
        //if (number.IfContainsNumber(3))
        //    return "Fizz";
        //if (number.IfContainsNumber(5))
        //    return "Buzz";


        //return number.ToString();
    }

    private static bool IsDivisibleBy(this int i, int divisiblyBy)
    {
        return i % divisiblyBy == 0;
    }

    private static bool IfContainsNumber(this int i, int number)
    {
        return i.ToString().Contains(number.ToString());
    }
}