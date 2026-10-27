using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace assignment;

public class Exercise3
{
    public static void Run()
    {
        Dictionary<string, string> phoneBook =
            new Dictionary<string, string>();

        // 1. Add four contacts
        phoneBook.Add("Ahmed", "01011111111");
        phoneBook.Add("Sara", "01022222222");
        phoneBook.Add("Ali", "01033333333");
        phoneBook.Add("Mona", "01044444444");

        // 2. Add or update using indexer syntax
        phoneBook["Omar"] = "01055555555";

        // 3. Add a duplicate using Add()
        try
        {
            phoneBook.Add("Ahmed", "01099999999");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Add error: " + ex.Message);
        }

        // 4. TryAdd a duplicate
        bool added = phoneBook.TryAdd("Ahmed", "01099999999");
        Console.WriteLine("TryAdd succeeded: " + added);

        // 5. Search for a missing contact
        Console.WriteLine("Does Karim exist? " + phoneBook.ContainsKey("Karim"));

        // 6. Get a contact with a fallback
        string phone = phoneBook.TryGetValue("Karim", out string number) ? number : "Not Found";

        Console.WriteLine("Karim's phone: " + phone);

        // 7. Print all keys, then all values
        Console.WriteLine("Names: " + string.Join(", ", phoneBook.Keys));

        Console.WriteLine("Numbers: " + string.Join(", ", phoneBook.Values));
    }
}
