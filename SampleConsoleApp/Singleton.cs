using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    // Esempio di Singleton
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton() { }
        public static Singleton Instance => _instance ??= new Singleton();
        public void ShowMessage() => Console.WriteLine("Singleton instance attivo!");
    }
}
