// challenge: do this in 3 lines of code

Random coin = new Random();
int flip = coin.Next(2);
Console.WriteLine((flip == 0) ? "heads":"tail");

// 2 lines

// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

// Console.WriteLine(34.40M); // prints 34.40