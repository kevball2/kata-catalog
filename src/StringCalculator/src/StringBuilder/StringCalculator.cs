using System.ComponentModel;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if( string.IsNullOrEmpty(numbers))
                return 0;

            string[] numbersArray = numbers.Split(",");
            int result = 0;
            
            foreach (var number in numbersArray)
            {
                int convertedNumer = Convert.ToInt32(number);
                result += convertedNumer;
            }

            return result;
        }

       

    }
}