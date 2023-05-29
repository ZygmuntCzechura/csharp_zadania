using System;

namespace Prosty_Szyfr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst: ");
            string tekst = Console.ReadLine();
            char[]tekstpozaszyfrowaniu = new char [tekst.Length];
            for(int i=0;i<tekst.Length;i++)
            {
                Console.Write(tekst[i]);
            }

            Console.WriteLine();


            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] is 'G' || tekst[i] is 'g') { tekstpozaszyfrowaniu[i] = 'A'; }
                else
                if (tekst[i] is 'A' || tekst[i] is 'a') { tekstpozaszyfrowaniu[i] = 'G'; }
                else
                if (tekst[i] is 'D' || tekst[i] is 'd') { tekstpozaszyfrowaniu[i] = 'E'; }
                else
                if (tekst[i] is 'E' || tekst[i] is 'e') { tekstpozaszyfrowaniu[i] = 'D'; }
                else
                if (tekst[i] is 'R' || tekst[i] is 'r') { tekstpozaszyfrowaniu[i] = 'Y'; }
                else
                if (tekst[i] is 'Y' || tekst[i] is 'y') { tekstpozaszyfrowaniu[i] = 'R'; }
                else
                if (tekst[i] is 'P' || tekst[i] is 'p') { tekstpozaszyfrowaniu[i] = 'O'; }
                else
                if (tekst[i] is 'O' || tekst[i] is 'o') { tekstpozaszyfrowaniu[i] = 'P'; }
                else
                if (tekst[i] is 'L' || tekst[i] is 'l') { tekstpozaszyfrowaniu[i] = 'U'; }
                else
                if (tekst[i] is 'U' || tekst[i] is 'u') { tekstpozaszyfrowaniu[i] = 'L'; }
                else
                if (tekst[i] is 'K' || tekst[i] is 'k') { tekstpozaszyfrowaniu[i] = 'I'; }
                else
                if (tekst[i] is 'I' || tekst[i] is 'i') { tekstpozaszyfrowaniu[i] = 'K'; }
                else
                    tekstpozaszyfrowaniu[i] = tekst[i];
            }
            Console.WriteLine("Tekst zaszyfrowany: ");

            foreach (char x in tekstpozaszyfrowaniu)
            {
                Console.Write(x);
            }
            Console.ReadKey();









        }
    }
}
