namespace RomanNumerals.CustomException
{
    public class InputValueException : System.Exception
    {
        public InputValueException() : base() { }
        public InputValueException(string message) : base(message) { }
        public InputValueException(string message, System.Exception inner) : base(message, inner) { }
    }
}
