var names = new List<string> { "Scott", "Ana", "Felipe " }; // var = local variable type / same as List<string names = new List<string>

names.Add("David");
names.Add("Damian");
names.Add("Maria");             

foreach (var name in names[2..4])   // iterate to the 2 - 4 range (2 is included, 4 is excluded)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// OR use for loop:

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}!"); // .ToUpper generates a new list, the string is immutable
}

Console.WriteLine(names[0]);    // first in the list
Console.WriteLine(names[2]);    // 3rd in the list
Console.WriteLine(names[names.Count -1]);    // last one OR
Console.WriteLine(names[^1]);   // count 1 from the back of the list




