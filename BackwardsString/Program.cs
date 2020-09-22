using System;

namespace BackwardsString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "Joe";
            for(int i = 2; i >= 0; i--)
            {
                Console.WriteLine($"{i}. {name[i]}");
            }
        }
    }
}
