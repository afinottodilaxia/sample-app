using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Module2
{
    internal class Methods
    {
        /// <summary>
        /// Calcola il quadrato di un numero intero.
        /// </summary>
        /// <param name="numero">Il numero intero di cui si vuole calcolare il quadrato.</param>
        /// <returns>Il quadrato del numero in input.</returns>
        /// <exception cref="ArgumentNullException">Se il numero è nullo.</exception>
        public static int CalcolaQuadrato(int? numero)
        {
            if (numero == null)
                throw new ArgumentNullException(nameof(numero), "L'input non può essere nullo.");
            return numero.Value * numero.Value;
        }



        // Questo metodo prende una lista di stringhe, 
        // le elabora convertendole in maiuscolo e le unisce in un'unica stringa di output.
        public string ElaboraLista(List<string> items)
        {
            string risultato = "";

            for (int i = 0; i < items.Count; i++)
            {
                // Converti ogni elemento in maiuscolo e aggiungi una virgola se non è l'ultimo elemento
                risultato += items[i].ToUpper() + (i < items.Count - 1 ? ", " : "");
            }

            return risultato;
        }
    }
}
