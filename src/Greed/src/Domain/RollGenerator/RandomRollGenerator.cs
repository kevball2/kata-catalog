using System.Security.Cryptography;

namespace Greed.Domain
{
    public class randomRollGenerator 
    {
        public static int newRoll()
        {
            return RandomNumberGenerator.GetInt32(1, 7);
        }

    }
}