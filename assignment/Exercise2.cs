using System;
using System.Collections.Generic;
using System.Text;
namespace assignment;

public class Exercise2
{
    public static void Run()
    {
        SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

        // 1. Add players
        leaderboard.Add(500, "Ahmed");
        leaderboard.Add(200, "Sara");
        leaderboard.Add(800, "Ali");
        leaderboard.Add(350, "Mona");

        // 2. Print sorted entries
        foreach (var player in leaderboard)
        {
            Console.WriteLine($"{player.Key} = {player.Value}");
        }

        // 3. Access first key and value
        Console.WriteLine("First score: " + leaderboard.First().Key);
        Console.WriteLine("First player: " + leaderboard.First().Value);

        // 4. Check if score 500 exists
        Console.WriteLine("Score 500 exists: " + leaderboard.ContainsKey(500));

        // 5. Safely get player with score 999
        if (leaderboard.TryGetValue(999, out string playerName))
            Console.WriteLine("Player: " + playerName);
        else
            Console.WriteLine("No player found for score 999.");

        // 6. Remove score 200
        leaderboard.Remove(200);

        Console.WriteLine("Updated leaderboard:");
        foreach (var player in leaderboard)
        {
            Console.WriteLine($"{player.Key} = {player.Value}");
        }
    }
}
