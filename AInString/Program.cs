using System;

namespace AInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a word:");
            string word = Console.ReadLine().ToLower();
            char searchCriteria = 'a';
            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == searchCriteria)
                {
                    counter = counter + 1;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine($"There are {counter} a's in your text");
            }
            else
            {
                Console.WriteLine($"There are no a's in your text");
            }
        }
    }
}
