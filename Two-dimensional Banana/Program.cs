using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = Double.Parse(Console.ReadLine());
            double number2 = Double.Parse(Console.ReadLine());
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
