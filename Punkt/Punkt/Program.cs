using System;

namespace Punkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartości punktu: ");
            Punkt punkt1 = new Punkt(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            punkt1.Wyswietl();
        }
    }

    public class Punkt
    {
        private int x { get; set;}
        private int y { get; set;}


        public Punkt(int Wspolzedna_x,int Wspolzedna_y)
        {
            x = Wspolzedna_x;
            y = Wspolzedna_y;
        }
        public void Wektor()
        {

            int x_Wektor, y_Wektor;
            Console.WriteLine("Podaj wartość x Wektora: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość y Wektora: ");
            int z = int.Parse(Console.ReadLine());
            x_Wektor = x + n;
            y_Wektor = y + z;
            Console.WriteLine($"Wynik po przesunięciu: ({x_Wektor},{y_Wektor})");
        }
        public void Wyswietl()
        { 
            Console.WriteLine($"Punkt: ({x},{y})");
            Wektor();
        }
    }
}
