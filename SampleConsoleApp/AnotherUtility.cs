namespace SampleConsoleApp
{
    public static class AnotherUtility
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Product(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public static int Difference(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public static int Quotient(int a, int b)
        {
            int result = a / b;
            return result;
        }

        public static int Remainder(int a, int b)
        {
            int result = a % b;
            return result;
        }
    }
}
