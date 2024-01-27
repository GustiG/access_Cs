// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type in an integer to check if it's even or odd: ");
int number = Convert.ToInt32(Console.ReadLine());

Thread.Sleep (255);
string answer = (number % 2 == 0) ? "even" : "odd";
Console.WriteLine($"{number} is {answer}");


