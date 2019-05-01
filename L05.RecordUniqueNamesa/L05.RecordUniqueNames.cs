namespace L05.RecordUniqueNamesa
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());

            HashSet<string> namesDatabase = new HashSet<string>();

            for (int i = 0; i < rotation; i++)
            {
                string currentName = Console.ReadLine();

                namesDatabase.Add(currentName);
            }

            foreach (var name in namesDatabase)
            {
                Console.WriteLine(name);
            }
        }
    }
}
