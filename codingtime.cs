using System;

class Program
{
    static void Main()
    {
        Console.Write("How many hours did you code today? ");
        int hours = int.Parse(Console.ReadLine());

        if (hours < 1)
            Console.WriteLine("At least you opened the IDE — that's progress!");
        else if (hours < 3)
            Console.WriteLine("Nice, your brain is still safe.");
        else if (hours < 6)
            Console.WriteLine("Wow! You're really in the flow!");
        else if (hours < 10)
            Console.WriteLine("Careful... soon you'll start dreaming in bugs.");
        else
            Console.WriteLine("Matrix error detected... You have broken the system! 🟢");
    }
}
