var names = new List<string> { "Scott", "Ana", "Felipe " }; // var = local variable type / same as List<string names = new List<string>

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// OR use for loop:

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}!");
}
