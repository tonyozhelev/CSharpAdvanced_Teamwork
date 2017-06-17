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
        public void DrawFrame(int numLives, int score)
        {
            Console.WriteLine('\u2554' + new String('\u2550',Constants.PlayBoxWidth) + '\u2557');
            for (int i = 0; i < Constants.PlayBoxHeight; i++)
            {
                Console.WriteLine('\u2551' + new String(' ', Constants.PlayBoxWidth) + '\u2551');
            }
            
            Console.WriteLine('\u2560' + new String('\u2550', Constants.PlayBoxWidth) + '\u2563');
            Console.WriteLine('\u2551' + "       " + string.Format("Lives: " + new string('\u2665', numLives)).PadRight(16) + 
                '\u2551' + new String('#', 55) + '\u2551' + "   " + string.Format("Score: {0:d15}" , score).PadRight(25) + '\u2551');
            Console.WriteLine('\u255A' + new String('\u2550', Constants.PlayBoxWidth) + '\u255D');
        }

        public void DrawStartScreen()
        {
            Console.WriteLine('\u2554' + new String('\u2550',Constants.PlayBoxWidth) + '\u2557');
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
            ship.Lifes = Constants.StartingLives;
            ship.DrawShip();
        }
    }
}
