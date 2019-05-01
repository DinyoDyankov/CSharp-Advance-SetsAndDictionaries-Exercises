namespace E04.EvenTimes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class EvenTimes
    {
        public static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());

            Dictionary<string, int> numbers = new Dictionary<string, int>();

            for (int i = 0; i < rotation; i++)
            {
                string inputNumber = Console.ReadLine();

                if (!numbers.ContainsKey(inputNumber))
                {
                    numbers[inputNumber] = 0;
                }

                numbers[inputNumber]++;
            }

            foreach (var kvp in numbers)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
