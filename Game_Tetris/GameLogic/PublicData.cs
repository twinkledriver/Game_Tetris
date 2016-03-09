using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tetris.GameLogic
{
    public class PublicData
    {
        public static int RowsNumber { get; set; }
        public static int RowsSum { get; set; }
        public static int RandomNumber { get; set; }
        public static int RandomNumber2 { get; set; }

        public void gpsSort(GameRecord[] grs, GamePlayer gps)
        {
            grs = new GameRecord[gps.us.Count];

            int a = 0;
            foreach (GameRecord dr in gps.us)
            { 
                grs[a]=dr;
                a++;
            }

            for(int j=0;j<grs.Length;j++)
            {
                for(int i=0;i<grs.Length-j-1;i++)
                {
                    if(grs[i].Result<grs[i+1].Result)
                    {
                        GameRecord gr;
                        gr=grs[i];
                        grs[i]=grs[i+1];
                        grs[i+1]=gr;
                    }
                }
            }
        }


        
    }
}
