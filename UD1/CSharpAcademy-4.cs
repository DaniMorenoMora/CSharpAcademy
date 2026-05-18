// Modulo 4

//Ejercicio 1

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
decimal quotient = 7.00m / 5.00m;
int first = 7;
int second = 5;
decimal decimaQuotient = (decimal)first / (decimal)second;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Decimal Quotient: " + decimaQuotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// Ejercicio 2

int value = 1;

value = value +1;   
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value --;
Console.WriteLine("Third decrement: " + value);

// Desafio 1

int fahrenheit = 94;
decimal celsiusConversor = (fahrenheit - 32) * (5m / 9m);
decimal celsius = Math.Round(celsiusConversor,2);
Console.WriteLine($"The temperature is {celsius} Celsius");