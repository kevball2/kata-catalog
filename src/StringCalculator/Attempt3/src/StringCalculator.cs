namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            int result = 0;
            
            if (string.IsNullOrEmpty(numbers))
                return result;

            char[] delimiterChars = { ',', '\n' };
            string[] numbersArray;
            
            if (!numbers.Contains("//"))
            {
                numbersArray = numbers.Split(delimiterChars);

                foreach (var number in numbersArray)
                {
                    int convertedNumber = Convert.ToInt32(number);
                    result += convertedNumber;
                }

                //return result;

            }
            
            if (numbers.Contains("//"))
            {
                string delimiterString = numbers.Substring(0, 3);
                List<char> delimiterList = new List<char>(delimiterChars);
                delimiterList.Add(delimiterString[2]);
                char[] customDelimiterChars = delimiterList.ToArray();
                numbers = numbers.Substring(4);
                numbersArray = numbers.Split(customDelimiterChars);

                foreach (var number in numbersArray)
                {
                    int convertedNumber = Convert.ToInt32(number);
                    result += convertedNumber;
                }

                // return result;
            }

            return result;

        }
    }
}