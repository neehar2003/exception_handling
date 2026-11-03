using exception_handling.Exceptions;
using exception_handling.Parsing;

namespace exception_handling.Exercises;

//Exercise 1.1 - custom exception
static class Exercise1_1
{
    public static void Run()
    {
        foreach (var text in new[] { "25", "abc", "-3", "200" })
        {
            try
            {
                AgeParser.ParseAge(text);
                Console.WriteLine($"{text} is valid");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Invalid: {ex.Message}");
            }
        }
    }
}
