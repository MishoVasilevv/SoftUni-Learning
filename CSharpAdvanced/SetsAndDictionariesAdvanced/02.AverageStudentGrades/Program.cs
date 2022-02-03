using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentStudent = inputArray[0];
                decimal currentStudentGrade = decimal.Parse(inputArray[1]);

                if (!students.ContainsKey(currentStudent))
                {
                    students.Add(currentStudent, new List<decimal>());
                }

                students[currentStudent].Add(currentStudentGrade);
            }

            foreach (var student in students)
            {
                //John ->; 5.20 3.20 (avg: 4.20)
                Console.WriteLine($"{student.Key} -> " +
                    $"{String.Join(" ", student.Value.Select(x => x.ToString("F2")))} " +
                    $"(avg: {student.Value.Average():F2})");
            }
        }
    }
}
