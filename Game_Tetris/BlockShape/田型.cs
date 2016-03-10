using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Tetris.GameLogic
{
     [Serializable]
    class 田型:下落图形基类
    {
        public 田型(int x,int y):base(x,y) 
        {
            Blocks[0] = new 小方块(x,y);
            Blocks[1] = new 小方块(x+1,y);
            Blocks[2] = new 小方块(x,y+1);
            Blocks[3] = new 小方块(x+1,y+1);
        }
        public override void spin()
        {
           
        }
    }
}
