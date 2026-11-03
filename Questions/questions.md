Exercise 1.1: a custom exception. Write class InvalidAgeException : Exception with a 
constructor that takes a message. Write int ParseAge(string text) that throws it with “Age must be
a number” if the text is not a number, and with “Age must be between 0 and 120” if the number is 
outside that range (use int.TryParse). Loop over "25", "abc", "-3" and "200". For each, print 
<text> is valid, 
or catch the exception and print Invalid: <message>.
Expected output:
25 is valid
Invalid: Age must be a number
Invalid: Age must be between 0 and 120
Invalid: Age must be between 0 and 120

Exercise 1.2: find the two problems. A colleague wrote this. Name what is wrong with each method, 
and rewrite them properly.
void A() { try { Save(); } catch (Exception) { } }
void B() { try { Save(); } catch (Exception ex) { throw ex; } }

void A(): Nothing inside catch(Exception): Exception fails silently.

void B():