// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string ReverseWord(string word)
{
  string result = "";
  for (int i = word.Length - 1; i >= 0; i--)
  {
    result += word[i];
  }
  return result;
}

string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseSentence(string input)
{
  string result = "";
  string[] words = input.Split(" ");

  foreach (string word in words)
  {
    result += ReverseWord(word) + " ";
  }

  return result.Trim();
}

string inputStc = "there are snakes at the zoo";

Console.WriteLine(inputStc);
Console.WriteLine(ReverseSentence(inputStc));