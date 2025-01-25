/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        string filePath = "/Users/Dommmy/cse212-hw/cse212-projects/week03/teach/basketball.csv";
        using var reader = new TextFieldParser(filePath);
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            //.............
            if (!players.ContainsKey(playerId))
                players[playerId] = points;
            players[playerId] += points;
        }
        //.............
        KeyValuePair<string, int>[] playersArray = players.ToArray();
        Array.Sort(playersArray, (x, y) => y.Value.CompareTo(x.Value));
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{i + 1}: {playersArray[i].Key} => {playersArray[i].Value}");

        // Console.WriteLine($"Players: {string.Join(", ", players)}");

        // var topPlayers = new string[10];
    }
}