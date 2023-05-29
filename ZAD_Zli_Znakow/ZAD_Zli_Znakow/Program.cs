using System;
using System.Text;

public class Test
{
    public static void Main()
    {
        Console.WriteLine("Podaj tekst: ");
        string tekst = Console.ReadLine();
        string zliczone = ZliczoneZnaki(tekst);
        Console.WriteLine(zliczone);
        Console.ReadKey();
    }

    static string ZliczoneZnaki(string tekst)
    {
        if (tekst == null) return null;
        if (tekst == "") return "";
        tekst = tekst.ToLower();

        char[] znaki = tekst.ToCharArray();
        Array.Sort(znaki);

        StringBuilder sb = new StringBuilder();
        int licz = 0;
        for(int i=0;i<znaki.Length;i++)
        {
            if (znaki[i] < 'a' || znaki[i] > 'z') continue;
            if(sb.Length==0)
            {
                sb = sb.Append(znaki[i]);
                licz = 1;
            }
            else if (znaki[i] == znaki[i-1])
            {
                licz++;
            }
            else
            {
                sb = sb.Append(" = ");
                sb = sb.Append(licz.ToString());
                sb = sb.Append("\n");
                sb = sb.Append(znaki[i]);
                licz = 1;
            }
        }
        sb = sb.Append(" = ");
        sb = sb.Append(licz.ToString());
        return sb.ToString();
    }









}