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
                     using (FileStream fs = new FileStream(@"UserRecordData\GameUserRecord.bin", FileMode.Open))
                     {
                         BinaryFormatter bf = new BinaryFormatter();
                         this.gps.us = (List<GameRecord>)bf.Deserialize(fs);
                     }
                 }
                 else
                 {
                     initialization();//如果没有该文件 则使用反序列化把内存中的数据提到硬盘上
                 }
             }
             catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }
         }

         public void initialization() //序列化
         {
             try
             {
                 using (FileStream fs = new FileStream(@"UserRecordData\GameUserRecord.bin", FileMode.Create))
                 {
                     BinaryFormatter bf = new BinaryFormatter();//二进制格式化
                     bf.Serialize(fs, this.gps.us);//将指定集合（对象）以二进制的格式存入指定路径
                     //fs.Close();
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
         public bool IsSpin(下落图形基类 obj)
         {
            下落图形基类 newObj=obj.Clone() as 下落图形基类;
             newObj.spin();
             bool isOk=true;
             foreach(小方块 item in obj.Blocks)
             {
                if (item.Y + 1 >= 22 ||
                    item.X + 1 >= 16 ||
                    item.X - 1 < 0 ||
                    GetBlockExist(item.X, item.Y + 1))
                {
                  isOk = false;
                    break;
                }
             }
                return isOk;
         }
          private bool IsClear(int level)
          {
            int count = 0;
               foreach (小方块 item in this.Blocks)
            {
                if (item.Y == level)
                {
                    count++;
                }
            }
                if(count==16)
            {
                PublicData.RowsNumber += 1;
                PublicData.RowsSum += 1;
            }
            return count == 16 ? true : false;
          }
          public bool IsRight(下落图形基类 obj)
        {
            bool isOk = true;
            foreach (小方块 item in obj.Blocks)
            {
                if (item.X + 1 > 15 || GetBlockExist(item.X + 1, item.Y))
                {
                    isOk = false;
                    break;
                }
            }
            return isOk;
        }
          public bool IsDown(下落图形基类 obj)
        {
            bool isOk = true;
            foreach (小方块 item in obj.Blocks)
            {
                if (item.Y + 1 >= 25 || GetBlockExist(item.X, item.Y + 1))
                {
                    isOk = false;
                    break;
                }
            }
            return isOk;
        }

          public bool IsLeft(下落图形基类 obj)
        {
            bool isOk = true;
            foreach (小方块 item in obj.Blocks)
            {
                if (item.X - 1 <0 || GetBlockExist(item.X-1, item.Y ))
                {
                    isOk = false;
                    break;
                }
            }
            return isOk;
        }

            public bool GetBlockExist(int x, int y)
        {
            bool isExist = false;
            foreach (小方块 item in this.Blocks)
            {
                if (item.X == x && item.Y == y)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

          public 下落图形基类 diamondsLocation() 
        {
            下落图形基类 obj = null;
            Random r = new Random();
            PublicData.RandomNumber=r.Next(1,10);//根据产生的随机数产生下落图形
            int location = r.Next(1,13); //图形下落的位置      
            site = Site.Up;
            number[0] = r.Next(1, 10);
            number[0] = number[1];
            number[1] = r.Next(1, 10);
            PublicData.RandomNumber=number[0];
            PublicData.RandomNumber2 = number[1];
            switch(number[0])
            {
                case 1:
                    obj = new 长条形(location, 0);
                    f= figure.长条形;
                    break;
                case 2:
                    obj = new Z型(location, 0);
                    f = figure.Z型;
                    break;
                case 3:
                    obj = new 田型(location, 0);
                    f = figure.田型;
                    break;
                case 4:
                    obj = new 土型(location, 0);
                    f = figure.土型;
                    break;
                case 5:
                    obj = new _7型(location, 0);
                    f = figure._7型;
                    break;
                case 6:
                    obj = new 反7型(location, 0);
                    f = figure.反7型;
                    break;
                case 7:
                    obj = new 反Z型(location, 0);
                    f = figure.反Z型;
                    break;
                default:
                    obj = new 长条形(location, 0);
                    f = figure.长条形;
                    break;
            }
            return obj;
       


         }
    }
}
