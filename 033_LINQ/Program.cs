// Specify the data source
List<int> scores = [97, 92, 81, 60]; // same as int[] scores = [1, 2] // OR var scores = new List<int> [1, 2]

// find all the scores that are over 80 (using declarative programming) -- without LINQ

for (int i = 0; i < scores.Count; i++)
{
    if (scores[i] > 80)
    {
        Console.WriteLine($"Found it {scores[i]}");
    }
}

// Define the query expression -- using LINQ
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query
foreach (int i in scoreQuery)
{
    Console.Write(i + " ");     // i + whitespace
}