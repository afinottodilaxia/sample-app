// See https://aka.ms/new-console-template for more information
using SampleConsoleApp;
using System.Text.Json;

Console.WriteLine("Hello, World!");

// Utilizzo dei metodi della classe SampleUtility
SampleUtility.PrintMessage("Questo è un messaggio di esempio.");
int sum = SampleUtility.Add(5, 3);
int product = SampleUtility.Multiply(4, 2);

Console.WriteLine($"Somma: {sum}");
Console.WriteLine($"Prodotto: {product}");


// JSON Serialization/Deserializzazione
List<Person> persons = new List<Person>
{
    new Person { Id = 1, Name = "Alice" },
    new Person { Id = 2, Name = "Bob" }
};

string jsonString = JsonSerializer.Serialize(persons);
Console.WriteLine("JSON Serializzato: " + jsonString);

List<Person> deserialized = JsonSerializer.Deserialize<List<Person>>(jsonString);
Console.WriteLine("Oggetti Deserializzati:");
foreach (var p in deserialized)
{
    Console.WriteLine($"{p.Id} - {p.Name}");
}

// Esempio Singleton
Singleton.Instance.ShowMessage();

// Ordinamento: BubbleSort
List<int> numbers = new List<int> { 5, 3, 8, 1, 4 };
SortingAlgorithms.BubbleSort(numbers);
Console.WriteLine("Numeri Ordinati: " + string.Join(", ", numbers));

// Punto di partenza per esercitazioni con Copilot:
// 1. Prova a modificare il metodo BubbleSort per renderlo più efficiente.
// 2. Aggiungi nuovi metodi per la ricerca (es. ricerca binaria) e verifica i suggerimenti.

// Esempio di utilizzo di un metodo di estensione
string message = "Hello, World!";
string reversed = message.Reverse().Aggregate("", (acc, c) => acc + c);
Console.WriteLine("Messaggio Invertito: " + reversed);

// Lista di 10 numeri casuali
Random random = new Random();
List<int> randomNumbers = Enumerable.Range(0, 10).Select(_ => random.Next(1, 101)).ToList();

// Esempi per i metodi Derivative e Integral della classe SampleUtility
int x = 3;
string derivativeResult = SampleUtility.Derivative(x);
string integralResult = SampleUtility.Integral(x);

Console.WriteLine(derivativeResult);
Console.WriteLine(integralResult);
