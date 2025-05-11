using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Module2Example
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nell'applicazione. Scegli un'opzione:");
            Console.WriteLine("1. Mostra data e ora");
            Console.WriteLine("2. Saluta l'utente");

            var scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.WriteLine(DateTime.Now);
                    break;
                case "2":
                    Console.Write("Inserisci il tuo nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"Ciao, {nome}!");
                    break;
                default:
                    Console.WriteLine("Opzione non valida.");
                    break;
            }
        }
    }
}
