using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tetris.GameLogic
{
    [Serializable]
    public class BlockRecord
    {
        public List<下落图形基类> Blck { get; set; }
        public BlockRecord()
        {
            Blck = new List<下落图形基类>();
         }
    }
}
