using System;

namespace Tablica_Mnoznik
{
    class Program
    {
        public static int[] tablica(int rozmiar, int mnoznik)
        {
            int[] tablica = new int[rozmiar];
           
 
            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj {0} elemnet tablicy: ",i);
                tablica[i] = int.Parse(Console.ReadLine()) * mnoznik;
            }
            return tablica;
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

                Console.WriteLine("Wynik: ");
                foreach (int x in wynik)
                {
                    Console.Write(x+", ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
              
        }
    }
}
