// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string value1 = "102";
int result = 0;
if (int.TryParse(value1, out result))
{
  Console.WriteLine($"Measurement: {result}");
}
else
{
  Console.WriteLine($"Unable to convert '{value1}'");
}
if (result > 0)
  Console.WriteLine($"Measurement (w/ offset) : {50 + result}");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
double tot = 0;
string s = "";
foreach (var value in values)  
{
  if(double.TryParse(value, out double number))
  {
    tot += number;
    Console.WriteLine($"Measurement: {number}");
  }
  else
  {
    s += value; 
    Console.WriteLine($"Unable to convert '{value}'");
  }
}
Console.WriteLine($"Message: {s}");
Console.WriteLine($"Total: {tot}");