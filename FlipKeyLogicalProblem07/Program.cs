using System;
using System.Text;
using System.Linq;

class Program

{
    public static string ValidateInput(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return string.Empty;
        }
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return string.Empty;
            }
        }
        return input;
    }

    public static string CleanseAndInvert(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return string.Empty;
        }
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return string.Empty;
            }
        }

        input = input.ToLower();
        var sb = new StringBuilder();
        foreach (char c in input)
        {
            if (((int)c) % 2 != 0)
                sb.Append(c);
        }

        var reversed = new string(sb.ToString().Reverse().ToArray());

        var result = new StringBuilder();
        for (int i = 0; i < reversed.Length; i++)
        {
            if (i % 2 == 0)
                result.Append(char.ToUpper(reversed[i]));
            else
                result.Append(reversed[i]);
        }

        return result.ToString();
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine() ?? "";
        if (ValidateInput(input) == string.Empty)
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            string key = CleanseAndInvert(input);
            if (string.IsNullOrEmpty(key))
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine($"The generated key is - {key}");
        }
    }
}