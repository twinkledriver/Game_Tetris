using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tetris.GameLogic
{
    [Serializable]
    public class ButtonRecord
    {
        public List<String> buttonKey { get; set; }
        public ButtonRecord()
        {
            buttonKey = new List<string>();
        }
    }
}
