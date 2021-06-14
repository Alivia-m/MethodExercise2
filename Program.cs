using System;

namespace Method.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first");
            int b = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the first");
            int f = int.Parse(Console.ReadLine());

            int subtract = Subtract(e, f);
            Console.WriteLine($"The difference is: {subtract}");

            Console.WriteLine("Give me a number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply the first by");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The product is: {product }");

            Console.WriteLine("Give me a number");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide the first by");
            int j = int.Parse(Console.ReadLine());

            int quotient = Divide(g, j);
            Console.WriteLine($"The quotient is: {quotient}");

            Console.WriteLine("Give me a number");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide the first by");
            int n = int.Parse(Console.ReadLine());

            int remainder = Remainder(m, n);
            Console.WriteLine($"The remainder is: {remainder }");
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int e, int f)
        {
            return e - f;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int g, int j)
        {
            return g / j;
        }
        public static int Remainder(int m, int n)
        {
            return m % n;
        }
    }
}
