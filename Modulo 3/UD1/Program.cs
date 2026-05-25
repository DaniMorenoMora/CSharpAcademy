/*string myValue1 = " a";
string myValue2 = "A ";
Console.WriteLine(myValue1.Trim().ToLower() == myValue2.Trim().ToLower());*/

/*Console.WriteLine("a" !="a");
Console.WriteLine("a" !="A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");*/

/*Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);*/

/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));*/

/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));*/

/*int a = 7;
int b = 6;
Console.WriteLine(a != b);
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);*/

/*int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");*/

/*Random coin = new Random();
int flip = coin.Next(0,2);
Console.WriteLine("Head or Tails!");
Console.WriteLine($"{(flip == 0 ? "Head" : "Tails")}");*/

string permission = "Admin|Manager";
int level = 55;

int userLevel = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine($"Welcome {(userLevel > level ? "Super" : "")} Admin");
}
else if (permission.Contains ("Manager"))
{
    Console.WriteLine($"{(userLevel > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges")}");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
