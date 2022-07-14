// See https://aka.ms/new-console-template for more information
//#error version
using System.Reflection;

System.Data.DataSet ds;
HttpClient client;
List<string> list;

Assembly? assembly = Assembly.GetEntryAssembly();

// loop through the assemblies that this app reference
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details
    Assembly a = Assembly.Load(name);

    // declare a variable to count the number of methods 
    int methodCount = 0;

    // Loop through all the types in the assem      bly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of methods
        methodCount += t.GetMethods().Count();
    }

    // output the count of types and their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assambly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name);

    // let the heightInMetres variable become equal to the value 1.88
    double heightInMetres = 1.88;
    Console.WriteLine($"The variable {heightInMetres.GetType()} has the value {heightInMetres}.");
}

// For text, a single letter, such as an A, is stored as a char type.
//char letter = 'A'; // assigning literal characters
//char digit = '1';
//char symbol = '$';
// char userChoice = GetSomeKeystroke(); // assigning from a fictitious function
char letter = 'A';
char digit = '1';
char symbol = '$';
// char userChoice = Console.ReadKey().KeyChar;
char userChoice = 'h';

Console.WriteLine($"{nameof(letter)} : {letter} \r\n " +
    $"{nameof(digit)} : {digit} \r\n " +
    $"{nameof(symbol)} : {symbol} \r\n " +
    $"{nameof(userChoice)} : {userChoice}");

// For text, multiple letters, such as Bob, are stored as a string type and are assigned using double quotes around the literal value
string firstName = "Bob";
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";

Console.WriteLine($"{nameof(firstName)} : {firstName} \r\n " +
    $"{nameof(lastName)} : {lastName} \r\n " +
    $"{nameof(phoneNumber)} : {phoneNumber}");

string fullNameWithTabSeparator = "Bob\tSmith";

Console.WriteLine(fullNameWithTabSeparator);

string filePath = "C:\\televisions\\sony\\bravia.txt";
string filePath2 = @"C:\televisions\sony\bravia.txt";

Console.WriteLine($"{filePath} \r\n {filePath2}");