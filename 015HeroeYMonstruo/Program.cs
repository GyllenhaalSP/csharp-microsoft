int heroHP = 10;
int monsterHP = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monsterHP -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} HP (HP {monsterHP})");

    if (monsterHP <= 0)
        continue;

    roll = dice.Next(1, 11);
    heroHP -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} HP (HP {heroHP})");
} while (heroHP > 0 && monsterHP > 0);

Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");