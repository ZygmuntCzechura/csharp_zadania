namespace Algorytm2
{
    class Program
    {
        static int NWD(int a,int b)
        {
            int c;
            while(b!=0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }


        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj liczby: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("NWD = {0}",NWD(a, b));
            Console.ReadKey();
        }
    }
}