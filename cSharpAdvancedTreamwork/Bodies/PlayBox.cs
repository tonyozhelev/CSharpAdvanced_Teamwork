using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpAdvancedTreamwork.Conts;

namespace cSharpAdvancedTreamwork.Bodies
{
   public class PlayBox
    {
        public PlayBox()
        {
            for (int i = 0; i <Rows ; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    PlayBoxMatrix[i, j] = ' ';
                }
            }
        }
        public int Cols=Constants.PlayBoxWidth;
        public int Rows = Constants.PlayBoxHeight;

        public char[,] PlayBoxMatrix = new char[Constants.PlayBoxHeight, Constants.PlayBoxWidth];
        public void Update()
        {
           
            for (int i = 0; i < Rows; i++)
            {
                Console.SetCursorPosition(1, 1+i);
                for (int j = 0; j < Cols; j++)
                {
                    
                    Console.Write(this.PlayBoxMatrix[i,j]);
                   
                }
//                Console.WriteLine();
            }
        }
    }
}
