using cSharpAdvancedTreamwork.Bodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvancedTreamwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var ship = new MainShip();
            int redo = 0;
            int sides = 75;
            int vertical = 45;
            
            ConsoleKeyInfo KeyInfo;
            Console.CursorVisible = false;
            Console.SetWindowSize(150, 50);
            ship.DrawShip(sides, vertical);
            do
            {
                KeyInfo = Console.ReadKey(true);
                Console.Clear();

                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (sides < 149)
                        {
                            sides++;
                        }
                        ship.DrawShip(sides,vertical);
                        break;
                    case ConsoleKey.LeftArrow:
                        if (sides > 0)
                        {
                            sides--;
                        }
                        ship.DrawShip(sides, vertical);
                        break;
                    case ConsoleKey.UpArrow:
                        if (vertical > 0)
                        {
                            vertical--;
                        }
                        ship.DrawShip(sides, vertical);
                        break;
                    case ConsoleKey.DownArrow:
                        if (vertical < 50)
                        {
                            vertical++;
                        }
                        ship.DrawShip(sides, vertical);
                        break;
                }

            } while (redo == 0);

            ship.DrawShip(20,40);
            ship.DrawShip(20,10);
            
            Console.ReadKey(true);
        }
    }
}
