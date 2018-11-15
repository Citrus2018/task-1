using System;
using System.Text.RegularExpressions;

namespace Домашка
{
    class Program
    {
        static string removingNotAnAlphabet(string input)
        { 
            Regex format_string = new Regex("[^a-zA-Zа-яА-Я]");
            return format_string.Replace(input, "");
        }

        static string reversing(char[] ltrs)
        {
            Array.Reverse(ltrs);
            return new string(ltrs);
        }

        static string AlphabetSorting(char[] ltrs)
        {
            Array.Sort(ltrs);
            return new string(ltrs);
        }
            
        static void Main(string[] args)
        {
            Console.Write("Входная строка: ");
            string input_string = Console.ReadLine();

            string formated = removingNotAnAlphabet(input_string);
            Console.WriteLine("Строка, содержащая только буквы: " + formated);

            char[] letters = formated.ToCharArray();
            
            Console.WriteLine("Реверсированная строка: " + reversing(letters));

            Console.WriteLine("Строка, отсортированная по алфавиту: " + AlphabetSorting(letters));
            Console.ReadLine();
        }
    }
}
