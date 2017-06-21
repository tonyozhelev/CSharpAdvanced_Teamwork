using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvancedTreamwork.Bodies
{
    class AsciiNums
    {
        public static string[] Zero = { "   ____   ","  / __ \\  "," / / / /  ","/ /_/ /   ","\\____/    "};
        public static string[] One = { "   ___    ","  <  /    ","  / /     "," / /      ","/_/       " };
        public static string[] Two = { "   ___    ","  |__ \\   ","  __/ /   "," / __/    ","/____/    "};
        public static string[] Three = { "   _____  ","  |__  /  ","   /_ <   "," ___/ /   ","/____/    "};
        public static string[] Four = {"   __ __  ","  / // /  "," / // /_  ","/__  __/  ","  /_/     " };
        public static string[] Five = {"    ______","   / ____/","  /___ \\  "," ____/ /  ","/_____/   " };
        public static string[] Six = {"   _____  ","  / ___/  "," / __ \\   ","/ /_/ /   ","\\____/    " };
        public static string[] Seven = {" _____    ","/__  /    ","  / /     "," / /      ","/_/       " };
        public static string[] Eight = {"   ____   ","  ( __ )  "," / __  |  ","/ /_/ /   ","\\____/    " };
        public static string[] Nine = { "   ____   ","  / __ \\  "," / /_/ /  "," \\__, /   ","/____/    "};
        
        public static void WriteZero(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Zero[0]);
            Console.SetCursorPosition(x, y+1);
            Console.Write(AsciiNums.Zero[1]);
            Console.SetCursorPosition(x, y+2);
            Console.Write(AsciiNums.Zero[2]);
            Console.SetCursorPosition(x, y+3);
            Console.Write(AsciiNums.Zero[3]);
            Console.SetCursorPosition(x, y+4);
            Console.Write(AsciiNums.Zero[4]);
        }

        public static void WriteOne(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.One[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.One[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.One[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.One[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.One[4]);
        }

        public static void WriteTwo(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Two[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Two[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Two[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Two[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Two[4]);
        }

        public static void WriteThree(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Three[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Three[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Three[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Three[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Three[4]);
        }

        public static void WriteFour(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Four[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Four[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Four[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Four[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Four[4]);
        }

        public static void WriteFive(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Five[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Five[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Five[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Five[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Five[4]);
        }

        public static void WriteSix(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Six[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Six[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Six[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Six[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Six[4]);
        }

        public static void WriteSeven(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Seven[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Seven[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Seven[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Seven[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Seven[4]);
        }

        public static void WriteEight(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Eight[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Eight[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Eight[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Eight[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Eight[4]);
        }

        public static void WriteNine(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(AsciiNums.Nine[0]);
            Console.SetCursorPosition(x, y + 1);
            Console.Write(AsciiNums.Nine[1]);
            Console.SetCursorPosition(x, y + 2);
            Console.Write(AsciiNums.Nine[2]);
            Console.SetCursorPosition(x, y + 3);
            Console.Write(AsciiNums.Nine[3]);
            Console.SetCursorPosition(x, y + 4);
            Console.Write(AsciiNums.Nine[4]);
        }

    }
}
