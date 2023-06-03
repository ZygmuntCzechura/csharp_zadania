using System;

namespace Fib_iteracyjnie
{
    class Program
    {
        public static int fib(int n)
        {
            int suma = 0;
            int a = 1, b = 1;
            if (n < 3) return 1;
            else
            for (int i=3;i<=n;i++)
            {
                suma = b + a;
                a = b;
                b = suma;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj który element ciągu: ");
            int n = int.Parse(Console.ReadLine());
            int fibnumber =fib(n);
            Console.WriteLine($"{n} wyraz ciągu to: {fibnumber}");
        }
    }
}
