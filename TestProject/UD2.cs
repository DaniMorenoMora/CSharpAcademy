Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <=1)
{
    discountPercentage =20;
}
else if (daysUntilExpiration <=5)
{
    discountPercentage =10;
}
else
{
    discountPercentage =0;
}


if (daysUntilExpiration <=0)
{
    Console.WriteLine("Su suscripción ha expirado");
}
else if (daysUntilExpiration <=1)
{
    Console.WriteLine($"¡Su suscripción expira mañana! Renueve ahora para obtener un {discountPercentage}% de descuento!");
}
else if (daysUntilExpiration <=5)
{
    Console.WriteLine($"En {daysUntilExpiration} dias caducará su suscripción. Renueve ahora para obtener un {discountPercentage}% de descuento!");
}
else if (daysUntilExpiration <=10)
{
    Console.WriteLine($"Tu suscripción expira en {daysUntilExpiration} dias. ¡Renueve su suscripción ahora!");
}
else
{
    Console.WriteLine("");
}