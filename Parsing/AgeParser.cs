using exception_handling.Exceptions;

namespace exception_handling.Parsing;

static class AgeParser
{
    public static int ParseAge(string text)
    {
        if (!int.TryParse(text, out var age))
            throw new InvalidAgeException("Age must be a number");
        if (age < 0 || age > 120)
            throw new InvalidAgeException("Age must be between 0 and 120");
        return age;
    }
}
