// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[,] corporate = 
{
  {"Robert", "Bavin"}, {"Simon", "Bright"},
  {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
  {"Sarah", "Deluchhi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
  {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
  {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for(int i = 0; i < corporate.GetLength(0); i++)
{
  // display internal email addresses
  DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
}

Console.WriteLine("");

for (int i = 0; i < external.GetLength(0); i++)
{
  // display external email addresses 
  DisplayEmail(first: corporate[i, 0], last: corporate[i, 1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
  string email = first.Substring(0, 2) + last;
  email = email.ToLower();
  Console.WriteLine($"{email}@{domain}");
}

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}