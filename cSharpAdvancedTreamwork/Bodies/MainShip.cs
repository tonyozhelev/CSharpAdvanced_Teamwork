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
            EnemyShips = new List<Enemies>();
        }

        public List<Bullet> Bullets { get; set; }
        public List<Enemies> EnemyShips { get; set; }

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
                    if (coords.y - 1 > Constants.FrameWidth)
                    {
                        if (coords.y - Constants.MainShipSpeedY > Constants.FrameWidth)
                            coords.y -= Constants.MainShipSpeedY;
                        coords.y--;
                    }
                    ship.DrawShip();

                    break;
                case ConsoleKey.DownArrow:
                    if (coords.y < Constants.PlayBoxHeight - Constants.MainShipHeight)
                    {
                        if (coords.y + Constants.MainShipSpeedY <= Constants.PlayBoxHeight - Constants.MainShipHeight)
                            coords.y += Constants.MainShipSpeedY;
                        coords.y++;
                    }
                    ship.DrawShip();
                    break;

                case ConsoleKey.Spacebar:
                    Bullets.Add(new Bullet(ship.position.x + 3, ship.position.y - 1));
                    Console.WriteLine(Bullets.Count);
                    DrawShip();


                    break;
            }
        }

        public void SpawnEnemiyShips()
        {
            while (true)
            {
                var enemy = new Enemies();
                EnemyShips.Add(enemy);
                Thread.Sleep(6000);
            }
        }

        public void CheckForDeadEnemiesAndDelete(int x,int y)
        {
            var toBeDeleted=new List<Enemies>();
            var ships = EnemyShips;
            for  (int i =0;i<EnemyShips.Count; i++)
            {
                
                if (x>=EnemyShips[i].Position.x && x<=EnemyShips[i].Position.x+7 && y< EnemyShips[i].Position.y+3 && y> EnemyShips[i].Position.y)
                {

                    toBeDeleted.Add(EnemyShips[i]);
                    
                }
                
            }
            DeleteEnemies(toBeDeleted);

        }

        public void DeleteEnemies(List<Enemies> deleted)
        {
            foreach (var e in deleted)
            {
                
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(e.Position.x, e.Position.y + i);

                    Console.WriteLine(new String(' ', 7));
                }
                EnemyShips.Remove(e);


            }
        }

        public void UpdateEnemies()
        {
           
            for (int i=0; i<EnemyShips.Count;i++)
            {
                EnemyShips[i].DrawShip();
            }
        }

        public void UpdateBullets()
        {
            var Removed = new List<Bullet>();
            for (int i=0; i<Bullets.Count;i++)
            {
                var bul = Bullets[i];
                if (bul.y > 1)
                {
                    int prev = bul.y;
                    bul.y--;
                    var c = ReadCharacterAt(bul.x, bul.y);
                    if (c != ' ')
                    {

                        
                        Removed.Add(bul);
                        
                       CheckForDeadEnemiesAndDelete(bul.x,bul.y);
                        UpdateEnemies();
                        
                    }
                    else
                    {
                        Console.SetCursorPosition(bul.x, bul.y);
                        Console.WriteLine('*');
                        Console.SetCursorPosition(bul.x, prev);
                        Console.WriteLine(' ');
                    }
                }
                else
                {
                    Bullets.Remove(bul);
                    Console.SetCursorPosition(bul.x, bul.y);
                    Console.WriteLine(' ');
                    Console.WriteLine(Bullets.Count);
                }
            }
            foreach (var bulet in Removed)
            {
                Bullets.Remove(bulet);
                UpdateBullets();
            }
        }

        public static char? ReadCharacterAt(int x, int y)
        {
            IntPtr consoleHandle = GetStdHandle(-11);
            if (consoleHandle == IntPtr.Zero)
            {
                return null;
            }
            Coord position = new Coord
            {
                X = (short) x,
                Y = (short) y
            };
            StringBuilder result = new StringBuilder(1);
            uint read = 0;
            if (ReadConsoleOutputCharacter(consoleHandle, result, 1, position, out read))
            {
                return result[0];
            }
            else
            {
                return null;
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadConsoleOutputCharacter(IntPtr hConsoleOutput, [Out] StringBuilder lpCharacter,
            uint length, Coord bufferCoord, out uint lpNumberOfCharactersRead);

        [StructLayout(LayoutKind.Sequential)]
        public struct Coord
        {
            public short X;
            public short Y;
        }

        public void DeleteStar(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(' ');
        }

        public void DrawStar(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine('*');
        }
    }
}