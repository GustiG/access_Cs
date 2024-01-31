// If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
// If all three dice you roll result in the same value, you get six bonus points for rolling triples.
// If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.

Random dice = new Random();
int dice1 = dice.Next(1, 7);
int dice2 = dice.Next(1, 7);
int dice3 = dice.Next(1, 7);
Console.WriteLine("Roll 3 dices above 15 and win. +2 bonus for rolling a double, +6 bonus for rolling a triple.");
Thread.Sleep(333);

Console.WriteLine($"{dice1}, {dice2}, {dice3}");

int bonus = 0;

if(dice1 == dice2)
{
    bonus += 2;
    if(dice1 == dice2 && dice2 == dice3)
    {
        bonus += 4;
    }
}
else if(dice1 == dice2 || dice1 == dice3 || dice2 == dice3) 
{
    bonus += 2;
}

int total = dice1 + dice2 + dice3 + bonus;

if(total > 15)
{
    Console.Write($"You win with {total} points from which {bonus} bonus.");
}
else
{
    Console.WriteLine($"You lost with {total} points.");
}
