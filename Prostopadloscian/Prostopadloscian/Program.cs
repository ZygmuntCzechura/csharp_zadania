using System;
using System.Runtime.CompilerServices;

namespace Prostopadloscian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę prostopadlościanów: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine();

            Prost[] tab = new Prost[n];
            for(int i=0;i<tab.Length;i++)
            {
                Console.WriteLine($"Podaj wymiary {i+1} prostopadlościanu: ");
                tab[i] = new Prost();
                tab[i].PokazDane();
                Console.WriteLine();
            }

            Console.WriteLine();
            foreach(Prost p in tab)
            {
                p.Pokaz();
                Console.WriteLine();
            }
            int Maksymalna = Prost.Porownaj(tab);
            Console.WriteLine($"Największa objętość prostopadloscianu to: {Maksymalna}");
            Console.ReadKey();
        }
    }

    class Prost
    {
        public string nazwa { get; set; }
        public int dlugosc { get; set; }
        public int szerokosc { get; set; }
        public int wysokosc { get; set; }
        public int Obj { get; set; }

        // Konstruktor bezparametrowy
        public Prost()
        {
            nazwa = "";
            dlugosc = 0;
            wysokosc = 0;
            szerokosc = 0;
            
        }
        public void PokazDane()
        {
            Console.Write("Nazwa: ");
            nazwa = Console.ReadLine();

            Console.Write("Długość: ");
            dlugosc = int.Parse(Console.ReadLine());

            Console.Write("Wysokość: ");
            wysokosc = int.Parse(Console.ReadLine());

            Console.Write("Szerokość: ");
            szerokosc = int.Parse(Console.ReadLine());

            Obj = LiczObj();
        }

        public int LiczObj()
        {
            int ObjProst = wysokosc * szerokosc * dlugosc;

            return ObjProst;
        }





        public static int Porownaj(Prost[]tab)
        {
            int Max = tab[0].Obj;
            foreach(Prost liczba in tab)
            {
                if(liczba.Obj>Max)
                {
                    Max =liczba.Obj;
                }
            }
            return Max;
        }
        public void Pokaz()
        {
            Console.WriteLine($"{nazwa}: x= {dlugosc} y= {wysokosc} z={szerokosc} Objętość={Obj}");
            
        }
    }
}
