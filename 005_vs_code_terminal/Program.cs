string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());  // true

// Console.WriteLine("a" != "a");   false
// Console.WriteLine("a" != "A");   true
// Console.WriteLine(1 != 2);       true

// string myValue = "a";
// Console.WriteLine(myValue != "a"); false

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox")); // true
// Console.WriteLine(pangram.Contains("cow")); // false

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));    // false
Console.WriteLine(!pangram.Contains("cow"));    // true