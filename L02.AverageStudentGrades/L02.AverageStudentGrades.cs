namespace L02.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();

            for (int i = 0; i < rotation; i++)
            {
                string[] studentDataInput = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string studentName = studentDataInput[0];
                double studentGrade = double.Parse(studentDataInput[1]);

                if (!studentsData.ContainsKey(studentName))
                {
                    studentsData[studentName] = new List<double>();
                }

                studentsData[studentName].Add(studentGrade);
            }

            foreach (var kvp in studentsData)
            {
                Console.Write($"{kvp.Key} ->");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($" {grade:F2}");
                }


                Console.WriteLine($" (avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
