﻿using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number from 1 to 10");
            int userNumber = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber*i}");
            }

            for (int i = 10; i >= 1; i --)
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber * 1}");
            }
        }
    }
}
