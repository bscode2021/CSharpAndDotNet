using static System.Console;

string password = "ninja";


if (password.Length < 8)
{
    WriteLine("Your password is to short use at least 8 characters!");
}
else
{
    WriteLine("Your password is strong");
}

object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} * {j} = {i * j}");
}
else
{
    WriteLine("o is not int so o it cannot multiply!");
}

int number2 = (new Random()).Next(1, 7);

Random random = new Random();
int number = random.Next(1, 7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break; // jumps to end of switch statement
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // multiple case section
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // end of switch statement

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");


string path = @"C:\Users\boban\OneDrive\CA\Repositories\BSCode\CSharpAndDotNet\Chapter03";

Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

if (key.Key == ConsoleKey.R)
{
    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
}
else if (key.Key == ConsoleKey.W)   
{
    s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
} else
{
    s = MemoryStream.Null;
}

string message;

//switch (s)
//{
//    case FileStream writeableFile when s.CanWrite:
//        message = "The sream is a file that I can write to.";
//        break;
//    case FileStream readOnlyFile:
//        message = "The stream is a read-only file.";
//        break;
//    case MemoryStream ms:
//        message = "The stream is a memory address.";
//        break;
//    default: // always evalueted last despite its current position
//        message = "The stream is some other type.";
//        break;
//    case null:
//        message = "The stream is null.";
//        break;
//}

message = s switch
{
    FileStream writeableFile when s.CanWrite => "The sream is a file that I can write to.",
    FileStream readOnlyFile => "The stream is a read-only file.",
    MemoryStream ms => "The stream is a memory address.",
    null => "The stream is null.",
    _ => "The stream is some other type."
};

WriteLine(message);