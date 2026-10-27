using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace assignment;

public class Exercise1
{
    public static void Run()
    {
        List<int> grades = new List<int>
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

        // 1. Print the collection, Count, first and last grade
        Console.WriteLine("Grades: " + string.Join(", ", grades));
        Console.WriteLine("Count: " + grades.Count);
        Console.WriteLine("First grade: " + grades.First());
        Console.WriteLine("Last grade: " + grades.Last());

        // 2. Sort ascending
        grades.Sort();
        Console.WriteLine("Sorted: " + string.Join(", ", grades));

        // 3. Get the first grade above 90
        int firstAbove90 = grades.First(g => g > 90);
        Console.WriteLine("First grade above 90: " + firstAbove90);

        // 4. Get all failing grades
        List<int> failing = grades.Where(g => g < 75).ToList();
        Console.WriteLine("Failing grades: " + string.Join(", ", failing));

        // 5. Remove all failing grades
        grades.RemoveAll(g => g < 75);
        Console.WriteLine("After removing failures: " + string.Join(", ", grades));

        // 6. Check if any grade equals 100
        Console.WriteLine("Has grade 100: " + grades.Contains(100));

        // 7. Convert grades to strings
        List<string> gradeLabels = grades
            .Select(g => $"Grade: {g}")
            .ToList();

        Console.WriteLine(string.Join(", ", gradeLabels));
    }
}
