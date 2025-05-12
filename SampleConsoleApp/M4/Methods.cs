using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.M4
{
    public class Methods
    {
        public int CalcolaSomma(int[] numeri)
        {
            int somma = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }
            return somma;
        }

        public void ScriviSuFile(string contenuto)
        {
            File.WriteAllText("dati.txt", contenuto);
        }
    }
}
