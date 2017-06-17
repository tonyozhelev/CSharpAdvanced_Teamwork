using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpAdvancedTreamwork.Conts;

namespace cSharpAdvancedTreamwork.Bodies
{
   public class Enemies
    {
        public struct Coordinates
        {
            public int x;
            public int y;

            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public Enemies()
        {
            shipEnemy = new string[] { "(|) (|)", "<<|||>>", "   V   ", };
            var rnd=new Random();
            var x = rnd.Next(2, Constants.PlayBoxWidth - 8);
            var y =2;
            Position.x = x;
            Position.y = y;
        }

        public Coordinates Position;
        public string[] shipEnemy { get; set; }
        private bool killed = false;
        public void DrawShip()
        {

            Coordinates coordinates = this.Position;
            foreach (var line in shipEnemy)
            { 
                Console.SetCursorPosition(coordinates.x, coordinates.y);
                Console.WriteLine(line);
                coordinates.y++;
            }
        }
    }
}
