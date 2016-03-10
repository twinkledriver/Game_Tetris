using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Tetris.GameLogic
{
    [Serializable]
    class 反7型 : 下落图形基类
    {
        public 反7型(int x, int y): base(x, y) 
        {
            Blocks[0] = new 小方块(x+2, y);
            Blocks[1] = new 小方块(x + 1, y);
            Blocks[2] = new 小方块(x + 1, y + 1);
            Blocks[3] = new 小方块(x + 1, y + 2);
        }
        public override void spin()
        {
            switch (site)
            {
                case Site.Up://图形的状态如果向左的话就让图形向上转
                    Blocks[0].X = Blocks[2].X+2;
                    Blocks[0].Y = Blocks[2].Y + 1;
                    Blocks[1].X = Blocks[2].X + 1;
                    Blocks[1].Y = Blocks[2].Y + 1;
                    site = Site.Down;
                    break;
                case Site.Down:
                    Blocks[0].X = Blocks[2].X+2;
                    Blocks[0].Y = Blocks[2].Y;
                    Blocks[1].X = Blocks[2].X+1;
                    Blocks[1].Y = Blocks[2].Y;

                    site = Site.Left;
                    break;
                case Site.Left:
                    Blocks[0].X = Blocks[2].X - 1;
                    Blocks[0].Y = Blocks[2].Y;
                    Blocks[1].X = Blocks[2].X;
                    Blocks[1].Y = Blocks[2].Y + 2;
                    site = Site.Right;
                    break;
                case Site.Right:
                    Blocks[0].X = Blocks[2].X;
                    Blocks[0].Y = Blocks[2].Y-1;
                    Blocks[1].X = Blocks[2].X+1;
                    Blocks[1].Y = Blocks[2].Y-1;
                    site = Site.Up;
                    break;
            }
        }
    }
}
