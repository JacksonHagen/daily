Console.WriteLine("Welcome to Pangram Checker!\n\nEnter the phrase you would like to validate:");

string input = Console.ReadLine() ?? String.Empty;

if (IsPangram(input))
{ }

bool IsPangram(string phrase)
{
    if (input.Length < 26)
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
