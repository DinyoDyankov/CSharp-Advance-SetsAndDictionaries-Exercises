namespace E05.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSymbols
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> symbolsContainer = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolsContainer.ContainsKey(input[i]))
                {
                    symbolsContainer[input[i]] = 0;
                }

                symbolsContainer[input[i]]++;
            }

            foreach (var kvp in symbolsContainer)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");   
            }
        }
    }
}
