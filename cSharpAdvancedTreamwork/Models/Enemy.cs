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
            //shipEnemy = new string[] { "(|) (|)", "<<|||>>", "   V   ", };
            shipEnemy = 'V';
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
        public char shipEnemy { get; set; }
        public void DrawShip()
        {
            Console.SetCursorPosition(Coords.x, Coords.y);
            Console.WriteLine(shipEnemy);
        }

        public void DeleteShip()
        {
            Console.SetCursorPosition(Coords.x, Coords.y);
            string line = " ";
            Console.WriteLine(line);
        }
        public void Move()
        {
            //this.Position.y += 1;
            //Coordinates coordinates = this.Position;

            //Console.SetCursorPosition(coordinates.x, coordinates.y);
            //Console.WriteLine(shipEnemy);

        }


    }
}
