// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

openingPosition += 1;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition2 = message.LastIndexOf('(');

openingPosition2 += 1;
int closingPosition2 = message.LastIndexOf(')');
int length2 = closingPosition2- openingPosition2;
Console.WriteLine(message.Substring(openingPosition2, length));

