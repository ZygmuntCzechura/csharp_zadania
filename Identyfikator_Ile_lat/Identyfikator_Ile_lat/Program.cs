using System;

namespace Identyfikator_Ile_lat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] Identyfikator = new string[2];
            int aktualnyRok = DateTime.Now.Year;

            for(int i=0;i<Identyfikator.Length;i++)
            {
                Console.WriteLine("Podaj Identyfikator: ");
                Identyfikator[i] = Console.ReadLine();
            }

            //string[]tekst = Identyfikator.Split(" ");

            foreach(string srodek in Identyfikator)
            {
                string[] id = srodek.Split('-');
                int rokZakupu = int.Parse(id[1]);
                int lataOdZakupu = aktualnyRok - rokZakupu;
                Console.WriteLine("identyfikator {0} ma {1} lat", srodek, lataOdZakupu);
            }
            
        }
    }
}
