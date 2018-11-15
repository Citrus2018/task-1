using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку : ");
            string s = Console.ReadLine();
            string str = "";
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                    str += s[i];
            }
            Console.WriteLine();
            Console.WriteLine("Строка с удаленными не-буквами : " + str);

            s = "";
            for (i = str.Length - 1; i >= 0; i--)
            {
                s += str[i];
            }
            Console.WriteLine();
            Console.WriteLine("Перевернутая строка : " + s);

            char[] ss = new char[s.Length];
            for (i = 0; i < s.Length; i++)
            {
                ss[i] = str[i];
            }

            for (i = str.Length - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                    if (ss[j] > ss[j + 1])
                    {
                        char buf = ss[j];
                        ss[j] = ss[j + 1];
                        ss[j + 1] = buf;
                    }
            Console.WriteLine("Отсортированная строка: ");
            for (i = 0; i < str.Length; i++)
                Console.Write(ss[i] + "");
            Console.ReadLine();
        }
    }
}
