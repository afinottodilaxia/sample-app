using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Module3Methods
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
    }
}
