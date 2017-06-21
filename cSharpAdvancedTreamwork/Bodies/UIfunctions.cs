using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpAdvancedTreamwork.Conts;

namespace cSharpAdvancedTreamwork.Bodies
{
    public class UIfunctions
    {
        public void DrawFrame(int numLives, int score, int missed)
        {
            Console.WriteLine('\u2554' + new String('\u2550', Constants.PlayBoxWidth) + '\u2557');
            for (int i = 0; i < Constants.PlayBoxHeight; i++)
            {
                Console.WriteLine('\u2551' + new String(' ', Constants.PlayBoxWidth) + '\u2551');
            }

            Console.WriteLine('\u2560' + new String('\u2550', Constants.PlayBoxWidth) + '\u2563');
            Console.WriteLine('\u2551' + "       " + string.Format("Lives: " + new string('\u2665', numLives)).PadRight(16) +
                '\u2551' + new String('#', 40) + '\u2551' + "   " + string.Format("Missed: {0}", missed) + "   " + string.Format("Score: {0:d15}", score).PadRight(25) + '\u2551');
            Console.WriteLine('\u255A' + new String('\u2550', Constants.PlayBoxWidth) + '\u255D');
        }

        public void DrawStartScreen()
        {
            Console.WriteLine('\u2554' + new String('\u2550', Constants.PlayBoxWidth) + '\u2557');
            for (int i = 0; i < 48; i++)
            {
                Console.WriteLine('\u2551' + new String(' ', Constants.PlayBoxWidth) + '\u2551');
            }

            Console.WriteLine('\u255A' + new String('\u2550', Constants.PlayBoxWidth) + '\u255D');

            Console.SetCursorPosition(28, 9);
            Console.Write("   _____ ____  ___   _________________ __  __________ ");
            Console.SetCursorPosition(28, 10);
            Console.Write("  / ___// __ \\/   | / ____/ ____/ ___// / / /  _/ __ \\");
            Console.SetCursorPosition(28, 11);
            Console.Write("  \\__ \\/ /_/ / /| |/ /   / __/  \\__ \\/ /_/ // // /_/ /");
            Console.SetCursorPosition(28, 12);
            Console.Write(" ___/ / ____/ ___ / /___/ /___ ___/ / __  // // ____/ ");
            Console.SetCursorPosition(28, 13);
            Console.Write("/____/_/   /_/  |_\\____/_____//____/_/ /_/___/_/ ");

            Console.SetCursorPosition(28, 16);
            Console.Write("      _____ __  ______  ____  ________________ ");
            Console.SetCursorPosition(28, 17);
            Console.Write("     / ___// / / / __ \\/ __ \\/_  __/ ____/ __ \\");
            Console.SetCursorPosition(28, 18);
            Console.Write("     \\__ \\/ /_/ / / / / / / / / / / __/ / /_/ /");
            Console.SetCursorPosition(28, 19);
            Console.Write("    ___/ / __  / /_/ / /_/ / / / / /___/ _, _/ ");
            Console.SetCursorPosition(28, 20);
            Console.Write("   /____/_/ /_/\\____/\\____/ /_/ /_____/_/ |_| ");

            Console.SetCursorPosition(43, 25);
            Console.Write("Press any key to play");

            var ship = new MainShip();
            ship.DrawShip();
        }

        public static void UpdateScore(ref int score)
        {
            //ako go naprawim long ne se sabira na finalniq ekran :D
            if (score < int.MaxValue - 10)
            {
                score += 10;
            }
            Console.SetCursorPosition(Constants.PlayBoxWidth - 24, Constants.PlayBoxHeight + 2);
            Console.Write(string.Format("Score: {0:d15}", score));
        }

        public static void GameOver(UIfunctions UI, MainShip ship, List<Enemies> enemies,int score,ref int missed)
        {
           
            Console.Clear();
            var toBeDeleted = new List<Enemies>();
            foreach (var enemy in enemies)
            {
                toBeDeleted.Add(enemy);
            }
            ship.DeleteEnemies(toBeDeleted);


            ship.position.x = Constants.MainShipSpawnPositionX;
            ship.position.y = Constants.MainShipSpawnPositionY;
            if (missed >= 3)
            {
                
                Console.SetCursorPosition(40, 20);
                Console.WriteLine($"You missed {missed} enemies!");
                missed = Constants.MissedShips;
            }
            else
            {
                Console.SetCursorPosition(40, 20);
                Console.WriteLine("You got hit!");
            }
            Console.ReadKey();
            Console.Clear();
            ship.lives--;
          

            UI.DrawFrame(ship.lives,score,missed);
        }

        public static void FinalScreen(int score)
        {
            Console.Clear();
            Console.WriteLine("Congratulations!!!\n\nFinal Score:");
            var cursorPosX = 4;
            var cursorPosY = 15;

            foreach (var ch in score.ToString())
            {
                switch (ch)
                {
                    case '0':
                        AsciiNums.WriteZero(cursorPosX,cursorPosY);
                        break;
                    case '1':
                        AsciiNums.WriteOne(cursorPosX, cursorPosY);
                        break;
                    case '2':
                        AsciiNums.WriteTwo(cursorPosX, cursorPosY);
                        break;
                    case '3':
                        AsciiNums.WriteThree(cursorPosX, cursorPosY);
                        break;
                    case '4':
                        AsciiNums.WriteFour(cursorPosX, cursorPosY);
                        break;
                    case '5':
                        AsciiNums.WriteFive(cursorPosX, cursorPosY);
                        break;
                    case '6':
                        AsciiNums.WriteSix(cursorPosX, cursorPosY);
                        break;
                    case '7':
                        AsciiNums.WriteSeven(cursorPosX, cursorPosY);
                        break;
                    case '8':
                        AsciiNums.WriteEight(cursorPosX, cursorPosY);
                        break;
                    case '9':
                        AsciiNums.WriteNine(cursorPosX, cursorPosY);
                        break;
                    default:
                        break;
                }
                cursorPosX += 10;
            }
            
        }
    }
}
