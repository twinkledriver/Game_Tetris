using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Game_Tetris.GameLogic
{
     [Serializable]
    public class 游戏规则类
    {
         int[] number = new int[2];
         public static figure f;
         public static Site site;
         public GamePlayer gps;

         public List<小方块> Blocks { get; set; }

         public 游戏规则类(GamePlayer gps)
         {
             this.gps = gps;
             Blocks = new List<小方块>();
         }
         public 游戏规则类()
         {
             Blocks = new List<小方块>();
         }
         public void RecodeBlock(下落图形基类 obj)
         {
             foreach (小方块 item in obj.Blocks)
             {
                 Blocks.Add(item);
             }
             for (int i = 0; i < 25; i++)
             {
                 if (IsClear(i))
                 {
                     ClearLevel(i);
                     LevelAdd(i);
                 }
             }

         }
         public void contray()
         {
             try
             {
                 if (File.Exists(@"UserRecordData\GameUserRecord.bin"))
                 {
                     BinaryFormatter bf = new BinaryFormatter();//二进制格式化
                     bf.Serialize(fs, this.gps.us);
                 }
             }
             catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }
         }

         public bool GameOver() 
         {
             bool tf = false;
             foreach (小方块 x in Blocks)
             {
                 if (x.Y <= 0)
                 {
                     tf = true;
                     break;
                 }
             }
                 return tf;
             }

        private void LevelAdd(int level)
        {
            foreach (小方块 item in this.Blocks)
            {
                if (item.Y < level)
                {
                    item.Y++;
                }
            }
        }
          private void ClearLevel(int level)
        {
            for (int i = this.Blocks.Count - 1; i >= 0; i--)
            {
                if (this.Blocks[i].Y == level)
                {
                    this.Blocks.RemoveAt(i);
                }
            }
            
        }
         }
    }
}
