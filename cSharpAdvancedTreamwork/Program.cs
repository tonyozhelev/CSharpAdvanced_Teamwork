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
            var lives = Constants.StartingLives;
            var score = Constants.StartingScore;
            var missed = Constants.MissedShips;
            UI.DrawFrame(lives, score, missed);
            
            var ship = new MainShip();
            var gameOver = false;
            
            int redo = 0;
            ship.DrawShip();

            Stopwatch time = new Stopwatch();
            time.Start();

            do
            {
                if (time.Elapsed.Milliseconds % 100 == 0)
                {
                    bool updateFrame = false;
                    if (time.Elapsed.Seconds % 2 == 0 && time.Elapsed.Milliseconds == 0)
                    {
                        ship.SpawnEnemiyShips();
                    }
                    if ((time.Elapsed.Seconds * 1000 + time.Elapsed.Milliseconds) % 500 == 0)
                    {
                        
                        Enemies.MoveEnemies(ship.EnemyShips,ref missed,ref updateFrame);
                        
                        //game over check
                        gameOver = Enemies.CheckForCollision(ship.EnemyShips, ship);
                        if (missed >= 3)
                        {
                            gameOver = true;
                        }
                        if (gameOver)
                        {
                            if (Constants.StartingLives > 0)
                            {
                                UIfunctions.GameOver(UI, ship, ship.EnemyShips,lives,score,ref missed);
                                ship.DrawShip();
                                gameOver = false;
                            }
                            else
                            {
                                UIfunctions.FinalScreen(score);
                                break;
                            }
                        }
                        //end of game over check
                    }
                    if (updateFrame)
                    {
                        Console.SetCursorPosition(77, 48);
                        Console.WriteLine(missed);
                    }
                    ship.UpdateEnemies();

                }
                else if(time.Elapsed.Milliseconds % 50 == 0)
                {
                    ship.UpdateBullets(ref score);
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo KeyInfo;
                    while (!Console.KeyAvailable)
                    {
                        //ship.UpdateBullets();
                        ship.UpdateEnemies();
                        Thread.Sleep(50);
                    }
                    KeyInfo = Console.ReadKey(true);
                    ship.MoveShip(KeyInfo, ship, ref ship.position);
                    //game over check
                    gameOver = Enemies.CheckForCollision(ship.EnemyShips, ship);
                    if (gameOver)
                    {
                        if (Constants.StartingLives > 0)
                        {
                            UIfunctions.GameOver(UI, ship, ship.EnemyShips, lives, score, ref missed);
                            ship.DrawShip();
                            gameOver = false;
                        }
                        else
                        {
                            UIfunctions.FinalScreen(score);
                            break;
                        }
                    }
                    // end of game over check
                    continue;

                }



            } while (redo == 0);


            Console.ReadKey(true);

        }

    }
}
