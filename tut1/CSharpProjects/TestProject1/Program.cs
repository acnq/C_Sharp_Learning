// See https://aka.ms/new-console-template for more information
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

decimal myDecimal2 = 3.14m;
Console.WriteLine($"decimal: {myDecimal2}");

int myInt2 = (int)myDecimal2;
Console.WriteLine($"int: {myInt2}");

decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float: {myFloat}");

int first1 = 5;
int seconde1 = 7;
string message = first1.ToString() + seconde1.ToString();
Console.WriteLine(message);

string first2 = "5";
string second2 = "7";
int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result1 = Convert.ToInt32(value1) + Convert.ToInt32(value2);
Console.WriteLine(result1);