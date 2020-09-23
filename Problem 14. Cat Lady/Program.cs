using System;
using System.Collections.Generic;

  class Cat
{
   public string name = "";

}
class Siamese : Cat
{
    public double earSize = 0;

    public override string ToString()
    {
        return Convert.ToString(earSize);
    } 
}
class Cymric : Cat
{
    public double furSize = 0;

    public override string ToString()
    {
        return Convert.ToString(furSize);
    }
}
class StreetExtraordinaire : Cat
{
    public int meavPow = 0;

    public override string ToString()
    {
        return Convert.ToString(meavPow);
    }
}
 class Program
    {
        static void Main(string[] args)
        {

        List<Cat> cats = new List<Cat>();

        string comand = "";

        while (comand != "End")
            
        {
            comand = Console.ReadLine();
            if (comand == "End")
            {
                break;
            }

            if (comand == "Siamese")
            {
                Siamese time1 = new Siamese();
                time1.name = Console.ReadLine();
                time1.earSize = Convert.ToDouble(Console.ReadLine());
                cats.Add(time1);
            }
            if(comand == "Cymric")
            {
                Cymric time2 = new Cymric();
                time2.name = Console.ReadLine();
                time2.furSize = Convert.ToDouble(Console.ReadLine());
                cats.Add(time2);
            }
            if(comand == "StreetExtraordinaire")
            {
                StreetExtraordinaire time3 = new StreetExtraordinaire();
                time3.name = Console.ReadLine();
                time3.meavPow = Convert.ToInt32(Console.ReadLine());
                cats.Add(time3);
            }
        }
        Console.WriteLine("Wats Cat Name:");
        comand = Console.ReadLine();

        for (int i = 0; i < cats.Count; i++)
        {
            if (cats[i].name == comand)
            {

                Console.WriteLine($"{cats[i].GetType()} {cats[i].name} {cats[i].ToString()}");
            }
           
        }
        Console.ReadLine();

        

        
        



        }
    }

