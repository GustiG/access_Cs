for (int i = 0; i < 10; i++)    // from 0 to 9
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 10; i >= 0; i--)   // from 10 to 0
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

Console.WriteLine();

string[] names = ["Alex", "Eddie", "David", "Michael"];
for (int i = names.Length - 1; i >= 0; i--)             // returns the names in reverse order
{                                                       // (int i = 0; i < names.Length; i++) to iterate forward
    Console.WriteLine(names[i]);
}

// CHANGE A VARIABLE WHILE ITERATING

Console.WriteLine();

string[] names2 = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names2.Length; i++)
{
    if (names2[i] == "David")
    {
        names2[i] = "Sammy";
    }
}

foreach (var name in names2)
{
    Console.WriteLine(name);
}