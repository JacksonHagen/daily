Console.WriteLine("Welcome to Pangram Checker!\n");

Console.WriteLine("Enter the phrase you would like to validate:");
string input = Console.ReadLine() ?? String.Empty;

if (IsPangram(input))
{
    Console.WriteLine("The input phrase is a Pangram!\n");
}
else
{
    Console.WriteLine("This input phrase is not a Panagram.\n");
}


bool IsPangram(string phrase)
{
    if (phrase.Length < 26)
    {
        return false;
    }

    var letters = new HashSet<char>();

    foreach (char c in phrase.ToLower())
    {
        if (Char.IsLetter(c))
        {
            letters.Add(c);
        }
    }
    return letters.Count == 26;
}
