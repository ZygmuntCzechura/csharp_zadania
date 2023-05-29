namespace Silnia_Rekurencja
{
    class Program
    {

        static int Silnia(int n)
        {
            if (n <= 1) return 1;
            else return n * Silnia(n - 1);
        }



        static void Main(string[] args)
        {
            int silnia;
            while (true)
            {
                Console.Write("Podaj liczbę z której silnia: ");
                silnia = int.Parse(Console.ReadLine());
                Console.WriteLine(Silnia(silnia));
            }
        }
    }
}