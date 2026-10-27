using System;
using System.Collections.Generic;
using System.Text;
namespace assignment;

public class Exercise4
{
    public static void Run()
    {
        // 1. Create a case-insensitive HashSet
        HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        emails.Add("ahmed@test.com");
        emails.Add("AHMED@test.com");
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.Com");

        // 2. Print Count
        Console.WriteLine("Unique emails count: " + emails.Count);

        // 3. Create Set A and Set B
        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

        // Use copies so each operation starts with the original sets
        HashSet<int> union = new HashSet<int>(setA);
        union.UnionWith(setB);
        Console.WriteLine("Union: " + string.Join(", ", union));

        HashSet<int> intersection = new HashSet<int>(setA);
        intersection.IntersectWith(setB);
        Console.WriteLine("Intersection: " + string.Join(", ", intersection));

        HashSet<int> difference = new HashSet<int>(setA);
        difference.ExceptWith(setB);
        Console.WriteLine("A Except B: " + string.Join(", ", difference));

        // 4. Check subset
        HashSet<int> smallSet = new HashSet<int> { 1, 2 };
        Console.WriteLine("Is subset: " + smallSet.IsSubsetOf(setA));
    }
}
