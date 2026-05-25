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



/* Primer ejercicio 

string? readResult;
string valueEntered = "";
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter a int between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    if (readResult !=null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numericValue);

    if (validNumber == true)
    {
        if (numericValue <= 5 || numericValue >= 10)
        {
            validNumber = false;
            Console.WriteLine("Error, the number must be between 5 and 10");
        }
    }
    else
    {
        Console.WriteLine($"You entered a invalid number, try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted."); */

/* Segundo ejercicio 

string roleName = "";
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a role (admin, manager or user):");

do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        roleName = readResult.Trim().ToLower();
    }
    if (roleName == "admin" || roleName == "manager" || roleName == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The role you entered ({roleName}) is not valid. Please, try again");
    }
} while (validEntry == false);

Console.WriteLine($"Welcome {roleName}");*/

