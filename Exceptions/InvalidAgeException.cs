namespace exception_handling.Exceptions;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}
