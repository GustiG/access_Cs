var names = new List<string> { "Scott", "Ana", "Felipe" };

names.Sort();

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}

var numbers = new List<int> { 45, 56, 99, 48, 67, 78 };
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");
numbers.Sort();
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}


// name.Sort() 
// name.IndexOf();