using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string a = Console.ReadLine();
            a = Regex.Replace(a, "[0-9]", "", RegexOptions.IgnoreCase);
            Console.WriteLine(a);
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            Array.Sort(charArray);
            Console.WriteLine(charArray);
            String s = new string(charArray);
            

        }

        public static string ReadString { get; set; }
    }
}