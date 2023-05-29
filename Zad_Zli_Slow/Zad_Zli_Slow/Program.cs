using System;
using System.Text;


public class Test
{
    public static void Main()
    {
        
        string tekst = "Kiedy idzie się po miód z balonikiem to trzeba się starać żeby pszczoły nie wiedziały po co się idzie-odpowiedział Puchatek";
        string zliczone = ZliczoneSlowo(tekst);
        Console.WriteLine("\n{0}", zliczone);
        Console.ReadKey();
    }


    static string ZliczoneSlowo(string tekst)
    {
        if (tekst == null) return null;
        if (tekst == "") return "";


        string[] Slowo = tekst.Split(" ");
        Array.Sort(Slowo);

        StringBuilder sb = new StringBuilder();
        int licz = 0;
        for (int i = 0; i < Slowo.Length; i++)
        {

            if (sb.Length == 0)
            {
                sb = sb.Append(Slowo[i]);
                licz = 1;
            }
            else if (Slowo[i] == Slowo[i - 1])
            {
                licz++;
            }
            else
            {
                    sb = sb.Append(" = ");
                    sb = sb.Append(licz.ToString());
                    sb = sb.Append("\n");
                    sb = sb.Append(Slowo[i]);
                    licz = 1;
            }
        }

        
            sb = sb.Append(" = ");
            sb = sb.Append(licz.ToString());
          
        

        return sb.ToString();
    }
}
