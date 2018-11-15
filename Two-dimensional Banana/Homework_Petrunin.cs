using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string default_str = Console.ReadLine();
            string formated = ("[^a-z A-Z а-я А-Я]");
            default_str = Regex.Replace(default_str, formated, "");
            char[] new_str = default_str.ToCharArray();
            Array.Reverse(new_str);
            Console.WriteLine(new_str);
            Array.Sort(new_str);
            Console.WriteLine(new_str);
            Console.ReadLine();
            
        }
    }
}
