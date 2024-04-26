// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("This is a simple app to know your weight in mars");

Console.WriteLine("Please enter your weight in Kg");
double weightInEarth = double.Parse(Console.ReadLine());

double earthGravity = 9.81;
double marsGravity = 3.71;

double weightInMars = (weightInEarth / earthGravity) * marsGravity;
weightInMars = Math.Round(weightInMars, 2);

Console.WriteLine("Your weight in mars is: " + weightInMars + "Kg");
