using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Game_Tetris.GameLogic;


namespace Game_Tetris
{
    public partial class Record : Form
    {
        public Form1 F;
        public Record(Form1 F)
        {
            this.DoubleBuffered = true;
            this.F = F;
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            int a = 0;
            foreach (GameRecord gg in F.grs)
            {
                a++;
                ListViewItem lvi = new ListViewItem(a.ToString());
                lvi.SubItems.Add(gg.name);
                lvi.SubItems.Add(gg.Result.ToString());
                lvi.SubItems.Add(gg.Date.ToString());
                lvShow.Items.Add(lvi);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 游戏回放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DateTime Date=Convert.ToDateTime(lvShow.SelectedItems[0].SubItems[3].Text);
            //GameRecordPlayer grp = new GameRecordPlayer(F,Date);//.Create();
            //grp.Show();
        }
    }
}
