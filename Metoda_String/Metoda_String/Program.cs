using System;

namespace Metoda_String
{
    class Program
    {
        public static int[] tablica(int rozmiar, int mnoznik)
        {
            int[] tablica = new int[rozmiar];


            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj {0} elemnet tablicy: ", i);
                tablica[i] = int.Parse(Console.ReadLine()) * mnoznik;
            }
            return tablica;
        }

        public static string[] tablica(int mnoznik)
        {
            Console.WriteLine("Podaj rozmiar: ");
            int rozmiars = int.Parse(Console.ReadLine());
            string[] tabstring = new string[rozmiars];
            

            for (int i = 0; i < rozmiars; i++)
            {
                Console.WriteLine("Podaj {0} elemnet tablicy: ", i);
                tabstring[i] = Console.ReadLine();
                string RepeatWyraz = string.Concat(Enumerable.Repeat(tabstring[i], mnoznik));

            }
            return tabstring;
        }



        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj rozmiar Tablicy: ");
                int rozmiar = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj Mnożnik: ");
                int mnoznik = int.Parse(Console.ReadLine());
                int[] wynik = tablica(rozmiar, mnoznik);
                Console.WriteLine();
                string[] wynik2 = tablica(mnoznik);
                Console.WriteLine("Wynik: ");
                foreach (int x in wynik)
                {
                    Console.Write(x + ", ");
                }

                Console.WriteLine("Wynik2: ");
                foreach (string x in wynik2)
                {
                    Console.Write(x + ", ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}