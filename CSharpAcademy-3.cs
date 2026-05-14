// Modulo 3
// Ejercicio 1
Console.WriteLine("Generating invoices for customer  \"Contoso Corp\"...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");

// Ejercicio 2 y 3
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "ACME";
string message = "Ver el resultado";
string russianMessage ="Ver el resultado en ruso";
string russianExtension = "ru-RU";

Console.WriteLine($@"View English output:
        c:\Excercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}:
        c:\Excercise\{projectName}\{russianExtension}\data.txt");