using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int redo = 0;
            int sides = 100;
            int vertical = 45;
            var ourShip = "X";
            ConsoleKeyInfo KeyInfo;
            Console.CursorVisible = false;
            Console.SetWindowSize(200, 50);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
                
            do
            {
                KeyInfo = Console.ReadKey(true);
                Console.Clear();

                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        sides++;
                        Console.SetCursorPosition(sides, vertical);
                        Console.WriteLine(ourShip);
                        break;
                    case ConsoleKey.LeftArrow:
                        sides--;
                        Console.SetCursorPosition(sides, vertical);
                        Console.WriteLine(ourShip);
                        break;
                    case ConsoleKey.UpArrow:
                        vertical--;
                        Console.SetCursorPosition(sides, vertical);
                        Console.WriteLine(ourShip);
                        break;
                    case ConsoleKey.DownArrow:
                        vertical++;
                        Console.SetCursorPosition(sides, vertical);
                        Console.WriteLine(ourShip);
                        break;
                }

            } while (redo == 0);

            Console.ReadLine();
        }


    }
}
