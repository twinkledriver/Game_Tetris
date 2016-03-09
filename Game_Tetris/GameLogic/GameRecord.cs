using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tetris.GameLogic
{
    [Serializable]
    public class GameRecord
    {
        public int Result { get; set; }
        public String name { get; set; }
        public DateTime Date { get; set; }
        public ButtonRecord Br { get; set; }
        public BlockRecord Blocks { get; set; }
    }
}
