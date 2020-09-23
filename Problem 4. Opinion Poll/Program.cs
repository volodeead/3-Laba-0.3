using System;

class Person
{
    private int age = 1;
    private string name = "NoName";

    public string Name
    {
        set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }
    public int Age
    {
        set
        {


            age = value;
        }
        get
        {
            return age;
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
        int N, j=0;
        Person[] arr;
        Person temp = new Person();
        N = Convert.ToInt32(Console.ReadLine());
        arr = new Person[N];
        for(int i=0; i<N; i++)
        {

            arr[i] = new Person();
            arr[i].Name = Console.ReadLine();
            arr[i].Age = Convert.ToInt32(Console.ReadLine());
            if (arr[i].Age > 30)
            {
                j++;
            }
            
        }
        Person[] sorted = new Person[j];

        for(int i=0, k=0; i<N; i++)
        {
            if (arr[i].Age > 30)
            {
                sorted[k] = new Person();
                sorted[k] = arr[i];
                k++;
            }
        }

        for(int i=0; i<j; i++)
        {
            for(int h=0; h<j; h++)
            {
                if (sorted[i].Name[0] < sorted[h].Name[0])
                {
                    temp = sorted[i];
                    sorted[i] = sorted[h];
                    sorted[h] = temp;
                }
            }
        }

        for(int i=0; i<j; i++)
        {
            Console.WriteLine($"Name: {sorted[i].Name} Age: {sorted[i].Age}");
        }

        Console.ReadKey();

        }
    }

