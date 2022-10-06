using static System.Console;

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
    byte age = byte.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch (FormatException ex)
{
    WriteLine($"FormatException says {ex.Message}");
}
catch (OverflowException ex)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("After parsing");