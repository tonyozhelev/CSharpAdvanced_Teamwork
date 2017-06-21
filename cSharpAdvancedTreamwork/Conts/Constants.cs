using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAdvancedTreamwork.Conts
{
    public static class Constants
    {
        //Main ship
        public const int MainShipWidth = 7;
        public const int MainShipHeight = 3;
        public const int MainShipSpawnPositionX = 48;
        public const int MainShipSpawnPositionY = 35;
        public const int MainShipSpeedX = 3;
        public const int MainShipSpeedY = 2;
        public static readonly string[] ShipPicture = new string[] { "  /|\\  ", " ||||| ", "\\<<.>>/" };
        //EnemyShip
        public const int EnemyShipWidth = 7;
        public const int EnemyShipHeight = 3;
        public static readonly string[] EnemyShipPicture = new string[] { "(|) (|)", "<<|||>>", "   V   ", };

        //PlayBox
        public const int PlayBoxWidth = 108;
        public const int PlayBoxHeight = 46;
        // Console window size
        public const int ConsoleWindowWidth = 110;
        public const int ConsoleWindowHeight = 51;
        //Frame 
        public const int FrameWidth = 1;
        //       public const char TopLeftCorner = '\u2554';
        //       public const char TopRightCorner = '\u2557';
        //       public const char BottomLeftCorner = '\u2560';
        //       public const char BottomRightCorner = '\u2563';
        //       public const char HorizontalBorder = '\u2550';
        //       public const char VerticalBorder = '\u2551';

        //Others
        public static int StartingScore = 0;
        public const int StartingLives = 3;

    }
}
