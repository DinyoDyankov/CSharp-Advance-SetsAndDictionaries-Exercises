namespace E03.PeriodicTable
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class PeriodicTable
    {
        public static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());

            HashSet<string> uniquePeriodicTableSymbols = new HashSet<string>();

            for (int i = 0; i < rotation; i++)
            {
                string[] inputOfElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < inputOfElements.Length; j++)
                {
                    uniquePeriodicTableSymbols.Add(inputOfElements[j]);
                }
            }

            var sortedPeriodicTable = uniquePeriodicTableSymbols.OrderBy(x => x);


            Console.WriteLine(string.Join(' ', sortedPeriodicTable));
        }
    }
}
