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
            PlayerShip = new string[] { "     __     ", "    //\\\\    ", "II  ||||  II","I\\\\\\<<>>///I","II   ^^   II" };
        }
        public string[] PlayerShip { get; set; }

        public void DrawShip(int startIndex, int top)
        {
            Console.SetCursorPosition(0, top);
            foreach (var line in PlayerShip)
            {
                var lineToDraw = line.PadLeft(startIndex);
                Console.WriteLine("{0}",lineToDraw);
            }
        }
    }
}
