Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Tirada: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("¡Has sacado dobles! +2 de bonificación al total!");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine($"Has sacado {total} ¡Ganaste!");
}

if (total < 15)
{
    Console.WriteLine($"Has sacado {total} Lo siento, perdiste.");
}