using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpAdvancedTreamwork.Conts;

namespace cSharpAdvancedTreamwork.Bodies
{
    public class Enemy
    {
        private Coordinates Coords;
        private int lifes { get; set; }
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
        public Enemy()
        {
            shipEnemy = new string[] { "(|) (|)", "<<|||>>", "   V   ", };
            var rnd = new Random();
            var x = rnd.Next(2, Constants.PlayBoxWidth - 8);
            var y = 2;
            Position.x = x;
            Position.y = y;
            this.lifes = Lifes;
            this.Coords = Position;
        }
        public int Lifes { get; set; }
        public Coordinates Position;
        public string[] shipEnemy { get; set; }
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
        public void DeleteShip()
        {
             Console.SetCursorPosition(Coords.x, Coords.y);
            string line = " ";
            Console.WriteLine(line);
            Console.WriteLine(' ');
        }
        public void Move()
        {
            this.Position.y += 1;
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
