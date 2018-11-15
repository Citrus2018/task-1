using System;

using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
             s= Console.ReadLine();
            s = Regex.Replace(s, "[!-@]", "", RegexOptions.IgnoreCase);
            s = Regex.Replace(s, "[[-`]", "", RegexOptions.IgnoreCase);
            s = Regex.Replace(s, "[{-Џ]", "", RegexOptions.IgnoreCase);
            s = Regex.Replace(s, "[ѐ-￿]", "", RegexOptions.IgnoreCase);
            Console.WriteLine(s);
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);        
            Console.WriteLine(arr);
            Array.Sort(arr);            
            Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
