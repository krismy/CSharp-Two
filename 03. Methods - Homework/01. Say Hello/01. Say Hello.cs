
using System;

class SayHello
{
    static void Main()
    {
        Console.WriteLine("What's your name ;)");
        string name = Console.ReadLine();
        PrintName(name);
    }

    private static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!",name);
    }
}

