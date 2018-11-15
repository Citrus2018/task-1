using System;
using System.Collections.Generic;


namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку : ");
            string str1 = Console.ReadLine();
            string str2 = "";
            int i;
            for (i = 0; i < str1.Length; i++)
            {
                if (char.IsLetter(str1[i]))
                    str2 += str1[i];
            }
            Console.WriteLine();
            Console.WriteLine("Строка с удаленными не-буквами : " + str2);
            str1 = "";
            for (i = str2.Length - 1; i >= 0; i--)
            {
                str1 += str2[i];
            }
            Console.WriteLine();
            Console.WriteLine("Перевернутая строка : " + str1);

            char[] str3 = new char[str1.Length];
            for (i = 0; i < str1.Length; i++)
            {
                str3[i] = str2[i];
            }


            for (i = str2.Length - 1; i >= 0; i--)
                for (int j = 0; j < i; j++)
                    if (str3[j] > str3[j + 1])
                    {
                        char buf = str3[j];
                        str3[j] = str3[j + 1];
                        str3[j + 1] = buf;
                    }
            Console.WriteLine();

            Console.Write("Строка в алф. порядкe: ");
            for (i = 0; i < str2.Length; i++)
                Console.Write(str3[i] + " ");
            Console.WriteLine();



        }

    }
}
