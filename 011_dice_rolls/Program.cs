string greeting = "Hi there, welcome to my dice game\nThe rules are simple:\n"
                + "You have 3 dices. You roll 15 or more and you win.\n"
                + "Bonus 2 points for rolling dobules and +6 points for rolling triples."
                + "\nGood luck!";
foreach(char c in greeting)
{
    Thread.Sleep(77);
    Console.Write(c);
}
