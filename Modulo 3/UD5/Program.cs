/*Random random = new Random();
int current = random.Next(1,11);

do
{
    current = random.Next(1,11);

    if (current >= 8) continue;

    Console.WriteLine(current);
}

while (current != 7);*/

/*while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next (1,11);
}
Console.WriteLine($"Last number: {current}");*/

/*int heroCurrentHealth = 10;
int monsterCurrentHealth = 10;
Random random = new Random();

do
{
    int atack = random.Next(1,11);
    Console.WriteLine($"The hero strikes and makes {atack} damage to the monster");
    monsterCurrentHealth -= atack;
    Console.WriteLine($"The monster health is now {monsterCurrentHealth}");

    // Si es true, continua el loop, si es false, continua el código y si es necesario, volvera a evaluarse el loop
    if (monsterCurrentHealth <= 0) continue;

    Console.WriteLine($"The monster strikes and makes {atack} damage to the hero");
    heroCurrentHealth -= atack;
    Console.WriteLine($"The hero health is now {heroCurrentHealth}");
}
 while (heroCurrentHealth > 0 && monsterCurrentHealth > 0);

 Console.WriteLine (heroCurrentHealth > monsterCurrentHealth ? "Hero wins!" : "Monster wins!");*/


/*string? readResult;
string valueEntered = "";
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter a number between 5 and 10");


do
{
    readResult = Console.ReadLine();

    // Si el resultado es del tipo correcto, seguimos el código
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    // Si no lo es, intentamos leer el número entero
    validNumber = int.TryParse(readResult, out numericValue);

    if (validNumber == true)
    {
        //Si no cumple con estas caracteristicas, validNumber vuelve a ser false
       if (numericValue < 5 || numericValue > 10)
        {
            validNumber = false;
            Console.WriteLine("Please, enter a valid number (between 5 and 10)");
        }
    }
    else
    {
        Console.WriteLine("Please, enter a number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Congratulations! {numericValue} is valid");*/

/*string? readResult;
string userRole = "";
bool validResult = false;

Console.WriteLine("Enter a valid role (Admin, Manager or User)");

do
{
    readResult = Console.ReadLine();
    userRole = readResult.Trim().ToLower();

    if (userRole == "admin" || userRole == "manager" || userRole == "user")
    {
        validResult = true;
    }
    else
    {
        Console.WriteLine("Invalid role. Please, try again");
    }
} while (!validResult);

Console.WriteLine($"Welcome {userRole}");*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", 
                                    "I like all three of the menu choices" };
int stringsCount = myStrings.Length; // La da de valor 2

int periodLocation = 0;
string myString = "";

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    //Localiza el "." dentro del string indicado y devuelve su posición
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1) // Se repite el loop hasta que no detecte ningun "."
    {
        mySentence = myString.Remove(periodLocation); //Borra desde el punto encontrado hasta el final
        myString = myString.Substring(periodLocation + 1); //Crea un nuevo string empezando desde el punto + 1 posición
        myString = myString.TrimStart(); //Elimina los espacios del principio del string
        periodLocation = myString.IndexOf("."); // Cambia el periodLocation Busca el siguiente punto del string generado y vuelve a ejecutar el bucle

        Console.WriteLine(mySentence); // Devuelve el string generado en consola
    }

    mySentence = myString.Trim(); // Limpia los espacios innecesarios
    Console.WriteLine(mySentence); // Devuelve en consola la última linea 
}

