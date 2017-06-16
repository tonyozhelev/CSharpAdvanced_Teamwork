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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ConsoleKeyInfo KeyInfo;
            Console.CursorVisible = false;
            Console.SetWindowSize(110, 51);
            var lives = 3;
            var UI = new UIfunctions();

            UI.DrawStartScreen();
            Console.ReadLine();
            Console.Clear();
            UI.DrawFrame(lives,0);

            var ship = new MainShip();
            var enemy = new Enemies();

            int redo = 0;
            ship.DrawShip();
            
            do
            {
                enemy.DrawShip();
                KeyInfo = Console.ReadKey(true);
                ship.MoveShip(KeyInfo, ship, ship.pos);

            } while (redo == 0);
            
            Console.ReadKey(true);
        }
    }
}
