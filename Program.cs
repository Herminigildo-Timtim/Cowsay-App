using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.Write("Tell me what you want to say: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("You must enter a message!");
            return;
        }

        CowsayApp.Say(input);
    }
}
