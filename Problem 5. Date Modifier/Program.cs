using System;
using System.Text;

class DateModifier
{
    public int DateMod(char[] date1, char[] date2)
    {
        StringBuilder d11 = new StringBuilder("00") ; StringBuilder m11 = new StringBuilder("00"); StringBuilder y11 = new StringBuilder("0000");
        StringBuilder d22 = new StringBuilder("00"); StringBuilder m22 = new StringBuilder("00"); StringBuilder y22 = new StringBuilder("0000");

        string d111; string m111; string y111;
        string d222; string m222; string y222;

        int diff, days1, days2;

        int d1, d2;
        int m1, m2;
        int y1, y2;

        for(int i = 0; i < 4; i++)
        {
            y11[i] = date1[i];
        }
        for(int i = 0; i < 4; i++)
        {
            y22[i] = date2[i];
        }

        for (int i = 5, j=0; i < 7; i++,j++)
        {
            m11[j] = date1[i];
        }
        for (int i = 5, j = 0; i < 7; i++, j++)
        {
            m22[j] = date2[i];
        }

        for (int i = 8, j = 0; i < 10; i++, j++)
        {
            d11[j] = date1[i];
        }
        for (int i = 8, j = 0; i < 10; i++, j++)
        {
            d22[j] = date2[i];
        }

        d111 = Convert.ToString(d11);
        d222 = Convert.ToString(d22);

        m111 = Convert.ToString(m11);
        m222 = Convert.ToString(m22);

        y111 = Convert.ToString(y11);
        y222 = Convert.ToString(y22);

        d1 = Convert.ToInt32(d111); m1 = Convert.ToInt32(m111); y1 = Convert.ToInt32(y111);
        d2 = Convert.ToInt32(d222); m2 = Convert.ToInt32(m222); y2 = Convert.ToInt32(y222);

        days1 = (y1 * 365) + (y1 / 4);
        days2 = (y2 * 365) + (y2 / 4);

        for(int i=1; i<=m1; i++)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
            {
                days1 += 31;
            }
            if (i == 4 || i == 6 || i == 9 || i == 11)
            {
                days1 += 30;
            }
            if(i == 2)
            {
                days1 += 28;
            }
        }

        for (int i = 1; i <= m2; i++)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
            {
                days2 += 31;
            }
            if (i == 4 || i == 6 || i == 9 || i == 11)
            {
                days2 += 30;
            }
            if (i == 2)
            {
                days2 += 28;
            }
        }
        days1 += d1;
        days2 += d2;

        diff = days1 - days2;
        return diff;
    }
}

class Program
    {
        static void Main(string[] args)
        {
        char[] your1 = new char[10];
        char[] your2 = new char[10];

        string a, b;
        
        for(int i=0; i<10; i++)
        {
            your1[i] = Console.ReadKey().KeyChar;
        }
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            your2[i] = Console.ReadKey().KeyChar;
        }

        a = Convert.ToString(your1);
        b = Convert.ToString(your2);

        DateModifier rizn = new DateModifier();

        Console.WriteLine();
        Console.WriteLine(rizn.DateMod(your1, your2));
        Console.ReadKey();


        }
    }

