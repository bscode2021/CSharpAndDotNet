using System.Xml;

object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metars tall.");

// int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

// storing a sring in a dynamics object 
// string has a Length property
dynamic something = "Ahmed";

// int does not have a Length property
something = 12;

// and array of any type has a Length property
something = new[] { 3, 5, 7 };

// this compiles but would throw an exception at run-time 
// if you later store a data type that does not have a 
// property named Length
Console.WriteLine($"Length is {something.Length}");

var population = 66_000_000; // 66 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // Booleans have value of true or false

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();
// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}"); 
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");

string[] myArray;

myArray = new string[4];

// storing items at index positions
myArray[0] = "Kate";
myArray[1] = "Jack";
myArray[2] = "Rebecca";
myArray[3] = "Tom";

// looping through the names
for (int i = 0; i < myArray.Length; i++)
{
    // output the item at index position i
    Console.WriteLine(myArray[i]);
}

string[] names2 = new string[] { "Kate", "Jack", "Rebecca", "Tom" };
int[] broevi = new int[] { 12, 33, 1, 5, 6 };
int[] broevi2 = new int[5];

Console.WriteLine($"{names2}{broevi}{broevi2}");