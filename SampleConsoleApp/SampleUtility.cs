namespace SampleConsoleApp
{
    public static class SampleUtility
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public static int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }

        public static int Modulus(int a, int b)
        {
            int result = a % b;
            return result;
        }

        /// <summary>
        /// Calcola la derivata della funzione f(x) = x^2 + 2x + 5 in un punto specifico.
        /// </summary>
        /// <param name="x">Il valore del punto in cui calcolare la derivata.</param>
        /// <returns>Una stringa che rappresenta il risultato del calcolo della derivata.</returns>
        /// <remarks>
        /// La derivata della funzione f(x) = x^2 + 2x + 5 è f'(x) = 2x + 2.
        /// </remarks>
        public static string Derivative(int x)
        {
            int result = 2 * x + 2;
            return $"La derivata della funzione x^2 + 2x + 5 per x = {x} è {result}";
        }
        // Metodo per calcolare l'integrale della funzione x^2 + 2x + 5
        public static string Integral(int x)
        {
            double result = (1.0 / 3.0) * Math.Pow(x, 3) + Math.Pow(x, 2) + 5 * x;
            return $"L'integrale della funzione x^2 + 2x + 5 per x = {x} è {result}";
        }
    }
}
