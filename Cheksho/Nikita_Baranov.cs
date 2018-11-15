using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Изначальная строка: ");

            string Line = Console.ReadLine();
            string Pattern = @"[^a-zA-Zа-яА-Я]";
            string Target = "";
            Regex Regex = new Regex(Pattern);
            string Result = Regex.Replace(Line, Target);
            Console.WriteLine("Строка только с буквами: " + Result);

            string ReverseResult = new string(Result.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Ревёрснутая строка: " + ReverseResult);

            char[] CharResult = ReverseResult.ToCharArray();
            Array.Sort(CharResult);
            string SortedResult = new string(CharResult);
            Console.WriteLine("Отсортированная строка: " + SortedResult);
            Console.ReadLine();
        }
    }
}
