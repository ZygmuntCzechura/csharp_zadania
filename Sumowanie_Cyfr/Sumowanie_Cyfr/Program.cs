using System;

namespace Sumowanie_Cyfr
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj cyfre: ");
            string cyfra = Console.ReadLine();
            Console.WriteLine("Wynik: {0}", Suma(cyfra));
        }
        public static int Suma(string cyfra)
        {
            int[] Cyfra_INT = new int[cyfra.Length];
            int suma = 0;
            for(int i=0;i<cyfra.Length;i++)
            {
                Cyfra_INT[i] = int.Parse(cyfra[i].ToString());
                suma = suma + Cyfra_INT[i];
            }
            return suma;
        }
    }
}