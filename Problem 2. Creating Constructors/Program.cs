﻿using System;
class Person
{
    private string name = "No name";
    private int age = 1;

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

            if (value > 0)
                age = value;
        }
        get
        {
            return age;
        }
    }

    public void Def()
    {
        Console.WriteLine("Имя: {0}\nВозраст: {1}", name, age);
    }
    public void OnlAge(int year)
    {
        age = year;
    }
    public void FullAdd(string human, int year)
    {
        age = year;
        name = human;
    }

    
}
        

class Program
    {
        static void Main(string[] args)
        {
        Person a = new Person();
        Person b = new Person();
        Person c = new Person();

        a.Def();

        Console.WriteLine();

        b.OnlAge(22);
        b.Def();

        Console.WriteLine();

        c.FullAdd("Vlad", 25);
        c.Def();

        Console.ReadKey();


    }
    }

