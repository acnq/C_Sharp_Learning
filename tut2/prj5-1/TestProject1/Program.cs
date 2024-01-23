// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
SayHello();
void SayHello()
{
  Console.WriteLine("Hello");
}

void DisplayRandomNumbers()
{
  Random random = new Random();

  for (int i = 0; i < 5; i++)
  {
    Console.Write($"{random.Next(1, 100)} ");
  }

  Console.WriteLine();
}

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();