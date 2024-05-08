using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string output = ReverseString(input);

        Console.WriteLine("Reversed string:");
        Console.WriteLine(output);
    }

    static string ReverseString(string input)
    {
        // Split the input string into words and remove empty entries
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Reverse the order of words
        Array.Reverse(words);

        // Join the words back into a single string with trimmed spaces
        string reversedString = string.Join(" ", words);

        return reversedString;
    }
}
