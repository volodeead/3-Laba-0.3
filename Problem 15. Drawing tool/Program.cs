using System;
using System.Collections.Generic;

class DrawToll 
{
    public void Drav()
    {

    }
    
}
class Squre : DrawToll
{
    public void Drav(int n)
    {
        char[,] arr = new char[n, n + 2];
        for(int i=0; i <n; i++)
        {
            for(int j=0; j<n+2; j++)
            {
                arr[i, 0] = '|';
                arr[i, n+1] = '|';
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n+1 ; j++)
            {
                arr[0, j] = '-';
                arr[n-1, j] = '-';
            }
        }
        for(int i=0; i<n; i++)
        {
            for(int j=0; j<n+2; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
class Ractangle : DrawToll
{
    public void Drav(int n, int g)
    {
        char[,] ar = new char[n, g + 2];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < g + 2; j++)
            {
                ar[i, 0] = '|';
                ar[i, g+1] = '|';
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < g+1; j++)
            {
                ar[0, j] = '-';
                ar[n - 1, j] = '-';
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < g + 2; j++)
            {
                Console.Write(ar[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
 class Program
    {
        static void Main(string[] args)
        {
        Squre sqr = new Squre();
        Ractangle rac = new Ractangle();

        int g, p, e;
        Console.WriteLine("Квадрат розміру N:");
        g = Convert.ToInt32(Console.ReadLine());
        sqr.Drav(g);

        Console.WriteLine("Прямокутник висота і довжина відповідно:");
        p = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToInt32(Console.ReadLine());
        rac.Drav(p, e);
        Console.ReadKey();
        }
    }

