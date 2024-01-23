// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
  int openingPosition = message.IndexOf('(');
  if (openingPosition == -1)
  {
    break; 
  }

  openingPosition += 1;
  int closingPosition = message.IndexOf(')');
  int length = closingPosition - openingPosition;
  Console.WriteLine(message.Substring(openingPosition, length));


  message = message.Substring(closingPosition + 1);
}

string message1 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message1}");
char[] openSymbols = {'{', '[', '('};
int startPosition1 = 5;
int openingPosition1 = message1.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message1.Substring(openingPosition1)}");

openingPosition1 = message1.IndexOfAny(openSymbols, startPosition1);
Console.WriteLine($"Found WITH using startPosition {startPosition1}: {message1.Substring(openingPosition1)}");
