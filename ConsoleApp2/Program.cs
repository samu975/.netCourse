// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello! this is a simple app to add two values together. ");
Console.WriteLine("Please enter the first number");
int firstNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Please enter the second number");
int secondNumber = Convert.ToInt16(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("The sum between " + firstNumber + " and " + secondNumber + " is: " + result);

