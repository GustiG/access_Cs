/*
Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int hero = 10;
int monster = 10;
Random attack = new();

while (hero > 0 && monster > 0)
{
    int heroAttack = attack.Next(1, 11);
    monster -= heroAttack;
    System.Console.WriteLine($"The enemy lost {heroAttack} health. His remaining health is: {monster}");
    
    if (monster < 1)
    {
        System.Console.WriteLine("You won.");
        break;
    }
    int monsterAttack = attack.Next(1,11);
    hero -= monsterAttack;
    System.Console.WriteLine($"Your hero was hit for {monsterAttack} points. Current health is: {hero}");

    if (hero < 1)
    {
        System.Console.WriteLine("You lost.");
        break;
    }
}

// OFFICIAL ANSWER:

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
