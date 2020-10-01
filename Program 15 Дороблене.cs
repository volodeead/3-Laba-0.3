using System;
using System.Collections.Generic;

 abstract class DrawTool 
{
    public int width;
    public int height;
    static public void DravTools(DrawTool tool)
    {
        tool.Drav();
    }
    public abstract void Drav();
    
}

 class Squre : DrawTool
{
    public int Width { get => width; set => base.width = value; }
    public int Height { get => width; }

    public override void Drav()
    {
        char[,] arr = new char[this.width, this.width + 2];
        for(int i=0; i < this.width; i++)
        {
            for(int j=0; j< this.width + 2; j++)
            {
                arr[i, 0] = '|';
                arr[i, this.width + 1] = '|';
            }
        }
        for (int i = 0; i < this.width; i++)
        {
            for (int j = 1; j < this.width + 1 ; j++)
            {
                arr[0, j] = '-';
                arr[this.width - 1, j] = '-';
            }
        }
        for(int i=0; i< this.width; i++)
        {
            for(int j=0; j< this.width + 2; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    
}
class Ractangle : DrawTool
{
    public int Width { get => width; set => base.width = value; }
    public int Height { get => height; set => base.height = value; }

    public override void Drav()
    {
        char[,] ar = new char[this.Width, this.Height + 2];
        
        for (int i = 0; i < this.Width; i++)
        {
            for (int j = 0; j < this.Height + 2; j++)
            {
                ar[i, 0] = '|';
                ar[i, this.Height + 1] = '|';
            }
        }
        for (int i = 0; i < this.Width; i++)
        {
            for (int j = 1; j < this.Height + 1; j++)
            {
                ar[0, j] = '-';
                ar[this.Width - 1, j] = '-';
            }
        }
        for (int i = 0; i < this.Width; i++)
        {
            for (int j = 0; j < this.Height + 2; j++)
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
        
        


        string comand;

        Console.WriteLine(" Input Sqr or Ract: ");

        comand = Console.ReadLine();

        int g, p, e;

        if (comand == "Squre")
        {
            Squre sqr = new Squre();
            Console.WriteLine("Квадрат розміру N:");
            g = Convert.ToInt32(Console.ReadLine());
            sqr.Width = g;
            DrawTool.DravTools(sqr);
        }

        if (comand == "Ractangle")
        {
            Ractangle rac = new Ractangle();
            Console.WriteLine("Прямокутник висота і довжина відповідно:");
            p = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            rac.Height = p;
            rac.Width = e;
            DrawTool.DravTools(rac);
        }

        
        

        Console.ReadKey();
        }
    }

