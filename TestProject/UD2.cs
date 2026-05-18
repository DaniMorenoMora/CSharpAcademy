

int roll1 = 6;
int roll2 = 6;
int roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Tirada: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {    
        Console.WriteLine("¡Has sacado triples! +6 de bonificación al total!");
        total += 6; 
    }

    else
    {
        Console.WriteLine("¡Has sacado dobles! +2 de bonificación al total!");
    total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine($"Has sacado {total} ¡Has ganado un vehículo nuevo, yo ya no te veo en otro coche macho!");
}
    else if (total >= 10)
    {
        Console.WriteLine ($"Has sacado {total} ¡Ganaste un portatil Lenovo guapisimo!");
    }
    else if (total >= 7)
    {
        Console.WriteLine($"Has sacado {total} ¡Ganaste un viaje a Kenia (Alicante)");
    }
else
{
    Console.WriteLine($"Has sacado {total} ¡Has ganado un gatito gordito!");
}