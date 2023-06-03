using System;

namespace fib_rekurencja
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile elementów ciągu: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Wyraz ciągu ma wartość: {0}",fib(n));
           
        }

        public static int fib(int n)
        {
            if (n < 3) return 1;
            else return fib(n - 2) + fib(n - 1);
        }
    }
}
