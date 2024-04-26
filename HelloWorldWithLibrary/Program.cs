// See https://aka.ms/new-console-template for more information
using ClassLibrary1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        string username = Console.ReadLine();

        string message = Class1.GetMessage(username);
        
        Console.WriteLine(message);
    }
}
