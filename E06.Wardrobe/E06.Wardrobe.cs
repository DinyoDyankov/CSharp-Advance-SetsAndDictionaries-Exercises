namespace E06.Wardrobe
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Wardrobe
    {
        public static void Main()
        {
            int numberOfLineOfClothes = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLineOfClothes; i++)
            {
                string[] clothesForEachColor = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = clothesForEachColor[0];
                string[] allClothes = clothesForEachColor[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < allClothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(allClothes[j]))
                    {
                        wardrobe[color][allClothes[j]] = 0;
                    }

                    wardrobe[color][allClothes[j]]++;

                }
            }

            string[] colourAndItem = Console.ReadLine().Split();
            string colour = colourAndItem[0];
            string item = colourAndItem[1];

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var itemKVP in kvp.Value)
                {
                    if (kvp.Key == colour && itemKVP.Key == item)
                    {
                        Console.WriteLine($"* {itemKVP.Key} - {itemKVP.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {itemKVP.Key} - {itemKVP.Value}");
                    }
                }
            }
        }
    }
}
