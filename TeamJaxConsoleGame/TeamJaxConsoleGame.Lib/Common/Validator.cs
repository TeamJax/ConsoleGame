namespace TeamJaxConsoleGame.Lib.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfNull(object value, string message)
        {
            if (value == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void ValidateIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
