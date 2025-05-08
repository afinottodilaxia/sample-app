// See https://aka.ms/new-console-template for more information
using SampleConsoleApp;

Console.WriteLine("Hello, World!");

// Utilizzo dei metodi della classe SampleUtility
SampleUtility.PrintMessage("Questo è un messaggio di esempio.");
int sum = SampleUtility.Add(5, 3);
int product = SampleUtility.Multiply(4, 2);

Console.WriteLine($"Somma: {sum}");
Console.WriteLine($"Prodotto: {product}");
