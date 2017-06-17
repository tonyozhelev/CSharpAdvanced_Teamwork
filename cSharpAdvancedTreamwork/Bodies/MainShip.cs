using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
            Bullets = new List<Bullet>();
        }

        public List<Bullet> Bullets { get; set; }
    
        public string[] PlayerShip { get; set; }

        public Coordinates position =
            new Coordinates(Constants.MainShipSpawnPositionX, Constants.MainShipSpawnPositionY);

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
            for (int i = 0; i < Constants.MainShipHeight; i++)
            {
                Console.SetCursorPosition(coords.x, coords.y);
                Console.WriteLine(new string(' ', Constants.MainShipWidth));
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
                    if (coords.x < Constants.PlayBoxWidth - Constants.MainShipWidth)
                    {
                        if (coords.x + Constants.MainShipSpeedX <= Constants.PlayBoxWidth - Constants.MainShipWidth)
                            coords.x += Constants.MainShipSpeedX;
                        coords.x++;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.LeftArrow:
                    if (coords.x - 1 > Constants.FrameWidth)
                    {
                        if (coords.x - Constants.MainShipSpeedX > Constants.FrameWidth)
                            coords.x -= Constants.MainShipSpeedX;
                        coords.x--;
                    }
                    ship.DrawShip();
                    break;
                case ConsoleKey.UpArrow:
                    if (coords.y -1> Constants.FrameWidth)
                    {
                        if (coords.y - Constants.MainShipSpeedY > Constants.FrameWidth)
                            coords.y -= Constants.MainShipSpeedY;
                        coords.y--;
                    }
                    ship.DrawShip();

                    break;
                case ConsoleKey.DownArrow:
                    if (coords.y  < Constants.PlayBoxHeight - Constants.MainShipHeight)
                    {
                        if (coords.y + Constants.MainShipSpeedY <= Constants.PlayBoxHeight - Constants.MainShipHeight)
                            coords.y += Constants.MainShipSpeedY;
                        coords.y++;
                    }
                    ship.DrawShip();
                    break;

                    case ConsoleKey.Spacebar:
                    Bullets.Add(new Bullet(ship.position.x+3,ship.position.y));
                    Console.WriteLine(Bullets.Count);
                    DrawShip();
                    
                  
                       
                    break;
            }
        }

        public void UpdateBullets()
        {
              
                foreach (Bullet bul in Bullets)
                {
                    if (bul.y > 2)
                    {
                        int prev = bul.y;
                        bul.y--;
                        Console.SetCursorPosition(bul.x, bul.y);
                        Console.WriteLine('*');
                        Console.SetCursorPosition(bul.x, prev);
                        Console.WriteLine(' ');
                    
                    }

                }
            
            

        }
        public void DeleteStar(int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(' ');
        }
        public void DrawStar(int x,int y)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine('*');
        }
      
    }
}