// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Hello, World!");

Console.WriteLine("What is your favorite greeting?\n");
string greeting = Console.ReadLine().ToLower();

switch (greeting)
{
    case "hi":
        System.Console.WriteLine("Hi there!");
        break;
    case "bye":
        System.Console.WriteLine("Ok, if this is how you want it...bye!");
        break;
    case "greetings":
        System.Console.WriteLine("Greetings, true friend!");
        break;
    case "howdy":
        System.Console.WriteLine("Well howdy there, cowboy!");
        break;
    case "good day":
        System.Console.WriteLine("And a good day to you, Sir!");
        break;
    case "hello":
        System.Console.WriteLine("Hello, World!");
        break;
    default:
        System.Console.WriteLine("That must be some foreign greeting...");
        break;
}