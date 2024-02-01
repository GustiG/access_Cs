// string greeting = "Hi there, welcome to my dice game\nThe rules are simple:\n"
//                 + "You have 3 dices. You roll 15 or more and you win.\n"
//                 + "Bonus 2 points for rolling dobules and +6 points for rolling triples."
//                 + "\nGood luck!";
// foreach (char c in greeting)
// {
//     Thread.Sleep(77);
//     Console.Write(c);
// }

using System.Threading.Channels;

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
int bonus = 0;

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    if(roll1 == roll2 && roll2 == roll3)
    {
        bonus += 6;
    }
    else
    {
        bonus += 2;
    }
}
Console.WriteLine($"You rolled: {roll1} + {roll2} + {roll3} = {total} points & {bonus} bonus.");
Console.WriteLine($"Your total is: {total+bonus}");

if ()