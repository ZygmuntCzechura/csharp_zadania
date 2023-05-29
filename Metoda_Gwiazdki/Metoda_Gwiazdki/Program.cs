using System;

namespace Metoda_Gwiazdki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Kolumny: ");
            int Kolumny = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Wiersze: ");
            int Wiersze = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char znak = keyInfo.KeyChar;
            Console.WriteLine('\n');
           int[,]wynik = Tablica(Kolumny, Wiersze,znak);
            Console.WriteLine();
           int[,] wynik2 = Tablica(Wiersze, Kolumny,znak);


        }

        static int[,] Tablica(int kolumna,int wiersz,char znak)
        {
            int[,] tablica = new int[wiersz, kolumna];
            for(int i=0;i<wiersz;i++)
            {
                for(int j=0;j<kolumna;j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
            return tablica;
        }
    }
}
