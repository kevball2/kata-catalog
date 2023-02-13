using System.Linq;

namespace StringCalculator.Domain;
public class StringCalculatorFunctions
{
    public static int Add(string numbers)
    {
        int result = 0;

        if (string.IsNullOrEmpty(numbers))
            return result;

        string[] delimitersString = { ",", "\n" };
        string[] numbersArray;
        List<string> negativeNumbers = new List<string>();

        if (!numbers.Contains("//"))
        {
            numbersArray = numbers.Split(delimitersString, StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in numbersArray)
            {
                if (int.TryParse(number, out int convertedNumber))
                {
                    if (convertedNumber >= 0 && convertedNumber <= 1000)
                    {
                        result += convertedNumber;
                    }
                    
                    if(convertedNumber < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                }
               
            }

        }

        if (numbers.Contains("//"))
        {
            int delimiterRange = numbers.IndexOf("\n");
            string customDelimiters = numbers.Substring(0, delimiterRange);
            string[] customDelimiter = AddCustomDelimiters(customDelimiters, delimitersString); 

            numbers = numbers.Substring(delimiterRange + 1, numbers.Length - (delimiterRange + 1));
            numbersArray = numbers.Split(customDelimiter, StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in numbersArray)
            {
                //int convertedNumber = Convert.ToInt32(number);
                //result += convertedNumber;
                if (int.TryParse(number, out int convertedNumber))
                {
                    if (convertedNumber >= 0 && convertedNumber <= 1000)
                    {
                        result += convertedNumber;
                    }

                    if (convertedNumber < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                }
            }
        }

        if(negativeNumbers.Count != 0)
        {
            throw new Exception(string.Format("Negatives not allowed: {0}", string.Join(", ",negativeNumbers)));
        }
        return result;

    }

    private static string[] AddCustomDelimiters(string newCustomDelimiters, string[] delimiterChars)
    {
        List<string> newDelimitersString = new List<string>();
        string[] customChars = {"["};
        string[] delimiters;
        if (newCustomDelimiters.Contains("//["))
        {
            newCustomDelimiters = newCustomDelimiters.Substring(2, newCustomDelimiters.Length - 3);
            delimiters = newCustomDelimiters.Split(customChars, StringSplitOptions.RemoveEmptyEntries);
            foreach(string item in delimiters)
            {
                if (item.Contains("]"))
                {
                    string delimiter = item.Substring(0, item.Length - 1);
                    newDelimitersString.Add(delimiter);
                }
                else
                {
                    string delimiter = item.Substring(0, item.Length);
                    newDelimitersString.Add(delimiter);
                }
            }     
        }
        else
        {
            newDelimitersString.Add(newCustomDelimiters.Substring(2, newCustomDelimiters.Length - 2));
        }

            return delimiterChars.Union(newDelimitersString).ToArray(); 
    }
    
}