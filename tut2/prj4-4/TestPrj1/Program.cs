// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string first = "Hello";
string second = "World";
Console.WriteLine("{0} {1}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"      Shares: {productShares:N3} Product");
Console.WriteLine($"      Sub Total: {subtotal:C}");
Console.WriteLine($"      Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadRight(10);

Console.WriteLine(formattedLine);