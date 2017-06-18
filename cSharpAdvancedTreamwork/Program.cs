using cSharpAdvancedTreamwork.Bodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using cSharpAdvancedTreamwork.Conts;

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
            Console.ReadLine();
            Console.Clear();
            UI.DrawFrame(Constants.StartingLives, Constants.StartingScore);

            var ship = new MainShip();
            ship.Lifes = Constants.StartingLives;
            //Kakvo e tova po dqvolite :D #magiq

            int redo = 0;
            ship.DrawShip();
            
            Thread t=new Thread(()=>ship.SpawnEnemiyShips());
            t.Start();

            do
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
                ship.UpdateBullets();
                ship.UpdateEnemies();
                

            } while (redo==0);


            Console.ReadKey(true);
        
        }
    

   
       
    }
}
