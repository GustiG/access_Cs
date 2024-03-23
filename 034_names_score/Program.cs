// an array to hold the names and another to hold the scores
// user inserts name and score (enter noname 0 to quit)
// same name can't be used twice
// search for a name and display the score

var names  = new List<string> {};
var scores = new List<int>    {};

string name = "";
int score = 0;

Console.WriteLine("Enter a name and a score (write 'noname' to exit):\n");

do
{
    Console.Write("Name: ");
    name = Console.ReadLine();

    if (name.ToLower() == "noname") // Check if user wants to exit
        break;

    Console.Write("Score: ");
    int.TryParse(Console.ReadLine(), out score);

    names.Add(name);
    scores.Add(score);

} while (true);

Console.WriteLine("\nNames and Scores:");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{names[i]}: {scores[i]}");
}
    
