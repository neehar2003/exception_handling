//Exercise 1.1 - custom exception

foreach(var text in new [] { "25", "abc", "-3", "200" })
{
    try
    {
        ParseAge(text);
        Console.WriteLine($"{text} is valid");
    }
    catch(InvalidAgeException ex)
    {
        Console.WriteLine($"Invalid: {ex.Message}");
    }
}

    

int ParseAge(string text)
{
    if (!int.TryParse(text, out var age))
 throw new InvalidAgeException("Age must be a number");
 if (age < 0 || age > 120)
 throw new InvalidAgeException("Age must be between 0 and 120");
 return age;
}

class InvalidAgeException : Exception
{
public InvalidAgeException(string message) : base(message){}
}


/*Exercise 1.2- A colleague wrote this. Name what is wrong with each method, 
and rewrite them properly.

void A() { try { Save(); } catch (Exception) { } }
void B() { try { Save(); } catch (Exception ex) { throw ex; } }

Answer:

> if save(); fails, nothing handles it.

> void B()
{
 try { Save(); }
 catch (Exception ex)
 {
 logger.LogError(ex, "Saving failed");
 throw; // keeps the original stack trace
 }
}

*/