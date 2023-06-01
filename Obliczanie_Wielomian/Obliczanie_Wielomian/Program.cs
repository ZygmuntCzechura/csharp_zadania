using System;

namespace Obliczanie_Wielomian
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj x: ");
            int x = int.Parse(Console.ReadLine());
            int wynik = Wielomian(x, n);
            Console.WriteLine("Wynik: {0}", wynik);
        }

        public static int Wielomian(int n,int x)
        {

            if (n == 0) return x;
            else
            {
                int suma = x + n;
                return suma + Wielomian(x, n - 1);
            }
            
        }
    }
}
