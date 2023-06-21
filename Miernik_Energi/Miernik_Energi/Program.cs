using System;

namespace Miernik_Energi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj początkowy stan licznika: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj aktualny stan licznika: ");
            double y = double.Parse(Console.ReadLine());
            Miernik Stan1 = new Miernik(x,y);
            Console.WriteLine("Wynik: " + Stan1.Energia());
            Console.ReadKey();
        }
    }

    public class Miernik
    {
        private double Start_value { get; set; }
        private double Now_value { get; set; }

        public Miernik(double Svalue,double Nvalue)
        {
            Start_value = Svalue;
            Now_value = Nvalue;
        }

        public double Energia()
        {
            
            double n = Start_value - Now_value;

            return n;
        }
    }
}
