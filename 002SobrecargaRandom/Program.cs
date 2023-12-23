Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"Primera tirada: {roll1}");
Console.WriteLine($"Segunda tirada: {roll2}");
Console.WriteLine($"Tercera tirada: {roll3}");