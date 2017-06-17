using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using cSharpAdvancedTreamwork.Conts;
namespace cSharpAdvancedTreamwork.Bodies
{
    public class MainShip
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
        public MainShip()
        {
            PlayerShip = Constants.ShipPicture;
        }
        public string[] PlayerShip { get; set; }
        public Coordinates position = new Coordinates(Constants.MainShipSpawnPositionX, Constants.MainShipSpawnPositionY);
        public void DrawShip()
        {
            Coordinates coords = new Coordinates(this.position.x, this.position.y);

            foreach (var line in PlayerShip)
            {
                Console.SetCursorPosition(coords.x, coords.y);
                Console.WriteLine("{0}", line);
                coords.y++;
            }
        }

        public void DeleteShip()
        {
            Coordinates coords = new Coordinates(this.position.x, this.position.y);
            for (int i=0;i<Constants.MainShipHeight;i++)
            {
                Console.SetCursorPosition(coords.x, coords.y);
                Console.WriteLine(new string(' ',Constants.MainShipWidth));
                coords.y++;
            }
        }
        public void MoveShip(ConsoleKeyInfo KeyInfo, MainShip ship, ref Coordinates coords)
        {
            
            var UI = new UIfunctions();
            DeleteShip();
            switch (KeyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    if (coords.x <= Constants.PlayBoxWidth-Constants.MainShipWidth)
                    {
                        coords.x++;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.LeftArrow:
                    if (coords.x >Constants.FrameWidth)
                    {
                        coords.x--;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.UpArrow:
                    if (coords.y > Constants.FrameWidth)
                    {
                        coords.y--;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.DownArrow:
                    if (coords.y <=Constants.PlayBoxHeight-Constants.MainShipHeight)
                    {
                        coords.y++;
                    }
                    ship.DrawShip();
                    break;
            }
        }
    }
}
