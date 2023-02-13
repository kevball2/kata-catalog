namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            char[] delimiterChars = { ',', '\n' };
            if (string.IsNullOrEmpty(numbers))
                return 0;
            
            string delimiterString = numbers.Substring(0, 3);
            string customerDelimiterString;
            string[] numbersArray;
            int result = 0;

            if (delimiterString.Contains("//"))
            {
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

                return result;
            }
            
            numbersArray = numbers.Split(delimiterChars);
            
            foreach (var number in numbersArray)
            {
                int convertedNumber = Convert.ToInt32(number);
                result += convertedNumber;
            }

            return result;
        }

    }
}