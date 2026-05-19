string originalMessage = "The quick brown fox jumps over the lazy dog.";

// Convert the message into a char array
char[] message = originalMessage.ToCharArray();

// Reverse the chars
Array.Reverse(message);
int letterCount = 0;

// Count the o's
foreach (char letter in message) 
    {
     if (letter == 'o') 
        {
         letterCount++; 
         } 
     }

// Convert it back to a string
string newMessage = new String(message);

// Print it out
Console.WriteLine(newMessage);

Console.WriteLine($"'o' appears {letterCount} times.");