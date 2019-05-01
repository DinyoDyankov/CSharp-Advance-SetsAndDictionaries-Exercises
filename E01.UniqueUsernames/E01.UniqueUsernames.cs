namespace E01.UniqueUsernames
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class UniqueUsernames
    {
        public static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());

            HashSet<string> nameRegistry = new HashSet<string>();

            for (int i = 0; i < rotation; i++)
            {
                nameRegistry.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, nameRegistry));
        }
    }
}
