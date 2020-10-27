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

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                // Write to the console "numbers" at index i
            }
        }
    }
}
