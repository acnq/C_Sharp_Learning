﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(",");
foreach (string item in items)
{
    Console.WriteLine(item);  
}