using System;

namespace Prostokat_Klasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat[] tab = new Prostokat[4];
            tab[0] = new Prostokat("Pros1", 5, 6);
            tab[1] = new Prostokat("Pros2", 7, 9);
            tab[2] = new Prostokat("Pros3", 4, 2);
            tab[3] = new Prostokat("Pros4", 5, 3);

            foreach (Prostokat p in tab)
            {
                p.Prezentuj();
            }
            Console.WriteLine($"Max: {Prostokat.MAX(tab)}");
            Console.ReadKey();
        }
    }
    public class Prostokat
    {
        private string nazwa { get; set; }
        private int dlugosc { get; set; }
        private int szerokosc { get; set; }

        public Prostokat(string naz, int dlu, int szer)
        {
            nazwa = naz;
            dlugosc = dlu;
            szerokosc = szer;
        }
        private int powierzchnia()
        {
            return dlugosc * szerokosc;

        }
        private int obwod()
        {
            return (2 * dlugosc) + (2 * szerokosc);
        }
        public static int MAX(Prostokat[] tab)
        {
            int Max = tab[0].powierzchnia();
            foreach (Prostokat liczba in tab)
            {
                if (liczba.powierzchnia() > Max)
                {
                    Max = liczba.powierzchnia();
                }
            }
            return Max;
        }
        public void Prezentuj()
        {
            Console.WriteLine($"nazwa: {nazwa}");
            Console.WriteLine($"powierzchnia: {powierzchnia()}");
            Console.WriteLine($"obwód: {obwod()}");
            Console.WriteLine();
        }
    }
}
