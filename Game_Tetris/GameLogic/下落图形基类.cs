using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Game_Tetris.GameLogic
{
     [Serializable]
    public abstract class 下落图形基类
    {
         public Site site { get; set; }

         public 小方块[] Blocks { get; set; }

         public int x { get; set; }

         public int y { get; set; }

         public 下落图形基类(int x, int y)
         {
             this.x = x;
             this.y = y;
             Blocks = new 小方块[4];
         }

         public void Left()
         {
             for (int a = 0; a < 4; a++)
             {
                 Blocks[a].left();
              }
         }

         public void Right()
         {
             for (int a = 0; a < 4; a++)
             {
                 Blocks[a].Right();
             }
         }

         public void Down()
         {
             for (int a = 0; a < 4; a++)
             {
                 Blocks[a].Dnwn();
             }
         }

         public void Daw(Graphics gs)
         {
             for (int a = 0; a < 4; a++)
             {
                 Blocks[a].Graw(gs);
             }
         }

         public abstract void spin();

         public object Clone()
         {
             using (MemoryStream ms = new MemoryStream())
             {
                 BinaryFormatter bf = new BinaryFormatter();
                 bf.Serialize(ms, this);
                 ms.Position = 0;
                 return bf.Deserialize(ms);
             }
         }





    }
}
