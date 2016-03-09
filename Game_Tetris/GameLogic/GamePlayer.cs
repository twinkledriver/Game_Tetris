using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tetris.GameLogic
{
    [Serializable]
    public class GamePlayer
    {
        public List<GameRecord> us { get; set; }
        public GamePlayer()
        {
            us = new List<GameRecord>();
        }
    }
}
