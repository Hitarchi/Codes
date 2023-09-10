using System;

class AlphabetCheck
{
    static void Main()
    {
        string inputString = "Your input string here!";
        int alphabetCount = CountAlphabetCharacters(inputString);
        Console.WriteLine($"Total alphabet characters: {alphabetCount}");
    }

    static int CountAlphabetCharacters(string inputString)
    {
        int count = 0;

        foreach (char c in inputString)
        {
            if(char.IsLetter(c))
            {
                count++;
            }
        }
        return count;
    }
}