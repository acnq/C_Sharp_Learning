﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
Console.WriteLine(message);
message = message.Replace("-", "");
Console.WriteLine(message);