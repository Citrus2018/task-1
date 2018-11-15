using System;
using System.Linq;

namespace Citrus {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Строка:");
            var s = Console.ReadLine();

            Console.WriteLine("Удалить всё кроме букв:");
            foreach (var c in s)
                if (!char.IsLetter(c)) Console.Write(c);
            Console.WriteLine("\n");



            Console.WriteLine("Перевернуть строку:");
            var chars = s.Reverse();
            foreach (var c in chars) Console.Write(c);
            Console.WriteLine("\n");



            Console.WriteLine("Сортировать строку:");
            var list = s.ToList();
            list.Sort();
            foreach (var c in list) Console.Write(c);
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
