using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //List called "numbers" 
            var numbers = new List<int>();

            var thisNum = 0;

            do
            {
                thisNum++;
                numbers.Add(thisNum);
            } while (thisNum > 100);

            while (thisNum < 200)
            {
                thisNum++;
                numbers.Add(thisNum);
            }

            Console.WriteLine("Increase:");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}
