using System;

namespace Wektor
{
    class Program_Wektor
    {
        static int Wektor(int x)
        {

            return x;
        }


        static void Przesun(ref int Row_Liczba, ref int Col_Liczba, int Row_wek, int Col_wek, ref int liczba)
        {
            int[,] tablica = new int[10, 10];
            tablica[Row_Liczba + Row_wek, Col_Liczba + Col_wek] = liczba;
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(0); j++)
                {
                    Console.Write("{0,3}", tablica[i, j]);
                }
                Console.WriteLine();
            }
        }




        static void Main(string[] args)
        {
            int liczba = 11;
            int Row_Liczba, Col_Liczba, Row_Wek = 3, Col_Wek = 2;
            int[,] tablica = new int[10, 10];





            Console.WriteLine("Współrzędne liczby");
            Console.WriteLine("Podaj w jakim wierszu chcesz liczbę: ");
            Row_Liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj w jakim kolumnie chcesz liczbę: ");
            Col_Liczba = int.Parse(Console.ReadLine());

            Przesun(ref Row_Liczba, ref Col_Liczba, Row_Wek, Col_Wek, ref liczba);

        }
    }
}

