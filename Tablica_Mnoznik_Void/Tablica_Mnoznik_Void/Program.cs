using System;

namespace Tablica_Mnoznik_Void
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar: ");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] mojaTablica = new int[rozmiar];

            MojaMetoda(mojaTablica);
           
        }
        static void MojaMetoda(int[] tablica)
        {
            Console.WriteLine("Podaj mnożnik: ");
            int mnoznik = int.Parse(Console.ReadLine());
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Podaj {0} element tablicy: ", i);
                tablica[i] = int.Parse(Console.ReadLine())*mnoznik;
            }
            
            foreach(int x in tablica)
            {
                Console.Write(x + ", ");
            }
        }
    }


}

