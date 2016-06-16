using System;

namespace _2.BankOfKurtovoKonare
{
    public static class Validation
    {
        public static void CheckForEmptyOrNull(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "The " + paramName + "cannot be null or empty.", paramName);
            }
        }

        public static void CheckForEmptyOrWhiteSpase(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(
                    "The " + paramName + "cannot be null or white space", paramName);
            }
        }
    }
}
