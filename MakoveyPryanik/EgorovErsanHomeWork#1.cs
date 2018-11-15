using System;
using System.Linq;

namespace LineOper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Line;
            Line = Console.ReadLine();
            string oLine;
            oLine = null;
            for (int i = 0; i < Line.Length; i++)
                if (Char.IsLetter(Line, i))
                    oLine += Line[i];
            Console.Write("     1. Удаление символов, не являющиемися буквами Line-oLine:       ");
            Console.WriteLine(oLine);
            string eniLo;
            eniLo = new string(oLine.ToCharArray().Reverse().ToArray());
            Console.Write("     2. Переворот oLine-eniLo:         ");
            Console.WriteLine(eniLo);
            string Leino;
            char[] charArray = oLine.ToCharArray();
            Array.Sort(charArray);
            Leino= new String(charArray);
            Console.Write("     3. Сортировка по алфавиту eniLo-Leino:           ");
            Console.WriteLine(Leino);
        }
    }
}