namespace L01.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSameValuesInArray
    {
        public static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> numbersStore = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNumber = input[i];

                if (!numbersStore.ContainsKey(currentNumber))
                {
                    numbersStore[currentNumber] = 0;
                }

                numbersStore[currentNumber] += 1;
            }

            foreach (var kvp in numbersStore)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
