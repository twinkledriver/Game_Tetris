using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Game_Tetris.GameLogic
{
     [Serializable]
    public class 小方块
    {
         public int X { get; set; }
         public int Y {get; set;  }

         public void Graw(Graphics gs)
         {
             gs.FillRectangle(Brushes.Green, X * 20, Y * 20, 19, 19);
         }

         public 小方块(int x, int y)
         {
             this.X = x;
             this.Y = y;
         }

         public void Right()
         {
             X++;
         }

         public void left()
         {
             X--;
         }

         public void Dnwn()
         {
             Y++;
         }
    }
}
