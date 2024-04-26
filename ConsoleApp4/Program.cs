// See https://aka.ms/new-console-template for more information
using ClassLibrary1;

Console.WriteLine("Please enter your name");
string userName = Console.ReadLine();

Console.WriteLine(Class1.GetMessage(userName));