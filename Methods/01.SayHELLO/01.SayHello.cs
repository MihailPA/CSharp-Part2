using System;

namespace _01.SayHELLO
{
    class SayHello
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        PrintHello(name);
        }

        static void PrintHello(string name)
        {
        Console.WriteLine("Hello " + name);
        }
    }
}
