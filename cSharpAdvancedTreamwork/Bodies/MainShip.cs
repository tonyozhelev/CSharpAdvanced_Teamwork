using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvancedTreamwork.Bodies
{
    public class MainShip
    {
        public MainShip()
        {
            PlayerShip = new string[] { "     __     ", "   ///\\\\\\   ", "    ||||    ", "II  ||||  II", "I\\\\\\<<>>///I","II   ^^   II" };
        }
        public string[] PlayerShip { get; set; }
        public int[] pos = new int[] { 30, 55 };
        public void DrawShip()
        {
            int[] coords = this.pos;
            Console.SetCursorPosition(0, coords[0]);
            foreach (var line in PlayerShip)
            {
                var lineToDraw = '\u2551' + line.PadLeft(coords[1]);
                Console.WriteLine("{0}",lineToDraw);
            }
        }

        public void MoveShip(ConsoleKeyInfo KeyInfo, MainShip ship, int[] coords)
        {
            Console.Clear();
            var UI = new UIfunctions();
            UI.DrawFrame(3,0);
            switch (KeyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    if (coords[1] < 108)
                    {
                        coords[1]++;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.LeftArrow:
                    if (coords[1] > 3)
                    {
                        coords[1]--;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.UpArrow:
                    if (coords[0] > 1)
                    {
                        coords[0]--;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.DownArrow:
                    if (coords[0] < 42)
                    {
                        coords[0]++;
                    }
                    ship.DrawShip();
                    break;
            }
        }
    }
}
