// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string name = "Samantha Jones";

int lengthOfFirst = name.IndexOf(' ');

int lengthOfLast = name.Length - lengthOfFirst - 1;

string firstName = name.Substring(startIndex: 0, length: lengthOfFirst);

string lastName = name.Substring(startIndex: name.Length - lengthOfLast, length: lengthOfLast);

Console.WriteLine($"First name: {firstName}, Last name: {lastName}");


ReadOnlySpan<char> nameAsSpan = name.AsSpan();


var firstNameAsSpan = nameAsSpan[0..lengthOfFirst];
var lastNameAsSpan = nameAsSpan[^lengthOfLast..^0];


Console.WriteLine("First name: {0}, Last name {1}", arg0: firstNameAsSpan.ToString(), arg1: lastNameAsSpan.ToString());

