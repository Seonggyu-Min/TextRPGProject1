using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG
{
    public static class Util
    {
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        public static void Print(string text, int delay = 0)
        {
            Console.WriteLine(text);
            Thread.Sleep(delay);
        }


        public static void Print(string text, ConsoleColor textColor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(text);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
    }
}
