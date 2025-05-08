using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class ExampleClass
    {
        /// <summary>
        /// Trova il valore massimo in una lista di numeri interi.
        /// </summary>
        /// <param name="lista">Lista contenente i numeri interi da analizzare. Deve essere non vuota.</param>
        /// <returns>Il valore massimo presente nella lista.</returns>
        /// <exception cref="ArgumentException">
        /// Viene sollevata se la lista è vuota.
        /// </exception>
        /// <remarks>
        /// Questo metodo scorre l'intera lista e aggiorna il valore massimo trovato.
        /// Si prega di assicurarsi che la lista non contenga valori non numerici o nulli.
        /// </remarks>

        public static int TrovaMassimo(List<int> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("La lista non può essere vuota.");
            }
            int massimo = lista[0];
            foreach (int numero in lista)
            {
                if (numero > massimo)
                {
                    massimo = numero;
                }
            }
            return massimo;
        }
    }
}
