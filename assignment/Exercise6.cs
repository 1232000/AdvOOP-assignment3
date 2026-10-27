using System;
using System.Collections.Generic;
using System.Text;
namespace assignment;

public class Exercise6
{
    public static void Run()
    {
        Stack<string> history = new Stack<string>();

        // 1. Push five URLs
        history.Push("google.com");
        history.Push("github.com");
        history.Push("stackoverflow.com");
        history.Push("youtube.com");
        history.Push("claude.ai");

        // 2. Peek at the current page
        Console.WriteLine("Current page: " + history.Peek());

        // 3. Go back three times
        for (int i = 0; i < 3; i++)
        {
            string leavingPage = history.Pop();
            Console.WriteLine("Leaving: " + leavingPage);
        }

        // 4. Print the current page
        Console.WriteLine("Current page after going back: " + history.Peek());

        // 5. Test TryPop on an empty stack separately
        Stack<string> emptyHistory = new Stack<string>();

        bool success = emptyHistory.TryPop(out string page);

        Console.WriteLine("TryPop succeeded: " + success);
        Console.WriteLine("Page: " + (page ?? "No page"));
    }
}
