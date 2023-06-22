using System;

namespace Punkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt[] tab = new Punkt[3];
            Console.WriteLine("Podaj wartości punktu 1: ");
            tab[0] = new Punkt(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Podaj wartości punktu 2: ");
            tab[1] = new Punkt(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Podaj wartości punktu 3: ");
            tab[2] = new Punkt(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
             foreach(Punkt p in tab)
            {
                p.Wyswietl();
            }
             if(Punkt.Prosta(tab)==0)
            {
                Console.WriteLine("Punkty leżą na jednej prostej");
            }
             else
                Console.WriteLine("Punkty nie leżą na jednej prostej");
            double dlugoscOdcinka = Odcinek.Dlugosc(tab);
            Console.WriteLine($"Odcinek punkt1 i punkt 2 ma długość: {dlugoscOdcinka} ");
            Console.ReadKey();
        }
    }
    public class Punkt
    {
        public double x { get; set;}
        public double y { get; set;}

        public Punkt(double Wspolzedna_x, double Wspolzedna_y)
        {
            x = Wspolzedna_x;
            y = Wspolzedna_y;
        }
        public static double Prosta(Punkt[]tab)
        {
            double Wynik;
            double A, B, C;
            A = tab[1].y - tab[0].y;
            B = tab[0].x - tab[1].x;
            C = tab[1].x * tab[0].y - tab[0].x * tab[1].y;
            Wynik = A * tab[2].x + B * tab[2].y + C;
            return Wynik;
        }
       
        public void Wektor()
        {

            double x_Wektor, y_Wektor;
            Console.WriteLine("Podaj wartość x Wektora: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość y Wektora: ");
            double z = double.Parse(Console.ReadLine());
            x_Wektor = x + n;
            y_Wektor = y + z;
            Console.WriteLine($"Wynik po przesunięciu: ({x_Wektor},{y_Wektor})");
        }
        public void Wyswietl()
        {
            Console.WriteLine($"Punkt :({x},{y})");

           /* Wektor();*/
        }
    }

    public class Odcinek : Punkt
    {
        public Odcinek(double Wspolzedna_x, double Wspolzedna_y) : base(Wspolzedna_x, Wspolzedna_y){}

        public static double Dlugosc(Punkt[]tab)
        {
            double wynik2;
            wynik2= Math.Sqrt(Math.Pow(tab[1].x - tab[0].x,2) + Math.Pow(tab[1].y - tab[0].y,2));
            return wynik2;
        }
    }
}
