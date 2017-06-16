using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvancedTreamwork.Bodies
{
    class Enemies
    {
        public Enemies()
        {
            shipEnemy = new string[] { "(|) (|)", "<<|||>>", "   V   ", };
        }
        public string[] shipEnemy { get; set; }
        public int[] pos = new int[] { 5, 2 };
        public void DrawShip()
        {
            int[] coords = this.pos;
            Console.SetCursorPosition(0, coords[0]);
            foreach (var line in shipEnemy)
            {
                var lineToDraw = '\u2551' + line.PadLeft(coords[1]);
                Console.WriteLine("{0}", lineToDraw);
            }
        }
    }
}
