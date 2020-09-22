using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Int32.Parse(Console.ReadLine());

            if (age >= 18)
            {
                for (int i = 100; i > 95; i--)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, \n {i} bottles of beer! \n Take 1 down, Pass it around, \n {i} bottles of beer on the wall!");
                } 
                    /*for (int i = 100; i > 95; i--)
                    {
                        Console.WriteLine($"{i} bottles of beer on the wall," +
                            $" {i} bottles of beer!" +
                            $"Take 1 down, Pass it around," +
                            $" {i} bottles of beer on the wall!");
                    */
                }
            else if (age < 18)
            {
                for (int i = 100; i > 95; i--)
                {
                    Console.WriteLine($"{i} bottles of milk on the wall, \n {i} bottles of milk! \n Take 1 down, Pass it around, \n {i} bottles of milk on the wall!");
                }
            }
        }
    }
}
