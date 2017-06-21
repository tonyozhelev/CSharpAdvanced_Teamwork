using cSharpAdvancedTreamwork.Bodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using cSharpAdvancedTreamwork.Conts;
using System.Diagnostics;

namespace cSharpAdvancedTreamwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.CursorVisible = false;
            Console.SetWindowSize(Constants.ConsoleWindowWidth, Constants.ConsoleWindowHeight);

            var UI = new UIfunctions();

            UI.DrawStartScreen();
            Console.ReadKey();
            Console.Clear();
            UI.DrawFrame(Constants.StartingLives, Constants.StartingScore);

            var ship = new MainShip();
            //Kakvo e tova po dqvolite :D

            int redo = 0;
            ship.DrawShip();

            Stopwatch time = new Stopwatch();
            time.Start();

            do
            {
                if (time.Elapsed.Milliseconds % 100 == 0)
                {
                    if (time.Elapsed.Seconds % 1 == 0 && time.Elapsed.Milliseconds == 0)
                    {
                        ship.SpawnEnemiyShips();
                    }
                    if ((time.Elapsed.Seconds * 1000 + time.Elapsed.Milliseconds) % 300 == 0)
                    {
                        Enemies.MoveEnemies(ship.EnemyShips);
                    }

                    ship.UpdateBullets();
                    ship.UpdateEnemies();

                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo KeyInfo;
                    while (!Console.KeyAvailable)
                    {
                        ship.UpdateBullets();
                        ship.UpdateEnemies();
                        Thread.Sleep(50);
                    }
                    KeyInfo = Console.ReadKey(true);
                    ship.MoveShip(KeyInfo, ship, ref ship.position);
                    continue;
                }



            } while (redo == 0);


            Console.ReadKey(true);

        }

    }
}
