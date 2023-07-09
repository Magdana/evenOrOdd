using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("determining if a number  is even or odd");

        Console.Write("Enter the number  ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number you entered is even");
        }

        else 
            Console.WriteLine("The number you entered is odd");
    }
}