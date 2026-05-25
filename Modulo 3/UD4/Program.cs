/* for puede usarse para hacer una iteración sabiendo de antemano el número de veces que queremos hacerlo. Puede usarse break para detener la iteración

for (int i = 0; i < 10; i ++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}*/

/* En un bucle for se pueden utilizar 3 parametros para definir el bucle. El primero defina e inicia la iteración, el segundo termina cuando finalizará la iteración
el tercero establece lo que ocurre al terminar cada iteración

string [] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}*/

/* En los bucles for, se puede renombrar un valor de un string, cosa que no puede hacerse en un foreach
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") 
        names[i] = "Sammy";

foreach (var name in names) 
    Console.WriteLine(name);*/

// El ejercicio FizzBuzz se utiliza para comprobar si se ha entendido bien los conceptos de for, if-elseif-else y %
for (int i = 0; i <=100; i++)
    {
        if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
        else if (i % 3 ==0)
        Console.WriteLine($"{i} - Fizz");
        else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
        else
        Console.WriteLine(i);
    }