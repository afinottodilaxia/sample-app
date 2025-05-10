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
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.", nameof(b));
            }
            int result = a / b;
            return result;
        }

        public static int Modulus(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Modulus by zero is not allowed.", nameof(b));
            }
            int result = a % b;
            return result;
        }
    }
}
