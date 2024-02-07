using System;
using System.Text.RegularExpressions;

public class EmailValidator
{
    public static bool IsValidEmail(string email)
    {
        // Regular expression pattern for validating email addresses
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Check if the email matches the pattern
        return Regex.IsMatch(email, pattern);
    }

    public static void Main(string[] args)
    {
        // Example usage:
        string email = "example@example.com";
        if (IsValidEmail(email))
        {
            Console.WriteLine("Email is valid.");
        }
        else
        {
            Console.WriteLine("Email is invalid.");
        }
    }
}