using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {

        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("Введіть текст:");
        string input = Console.ReadLine();

        if (IsEnglishText(input))
        {
            Console.WriteLine("Текст написаний англійською мовою.");
        }
        else
        {
            Console.WriteLine("Текст містить символи, які не належать англійській мові.");
        }
    }

    static bool IsEnglishText(string text)
    {
        string pattern = @"^[a-zA-Z0-9\s.,!?'\-]+$";
        return Regex.IsMatch(text, pattern);
    }
}
