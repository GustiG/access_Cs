// See https://aka.ms/new-console-template for more information
Console.WriteLine("Create your username: ");
string username = Console.ReadLine();

Console.WriteLine($"Now {username}, create your password: ");
string password = Console.ReadLine();

Console.WriteLine("Repeat your password to make sure you remember it: ");
string secondPassword = Console.ReadLine();

if (password != secondPassword)
{
    Console.WriteLine($"You didn't enter the same password, {username}!");
}
else
{
    Console.WriteLine($"Good job, {username}. Your password is stored.");
}
