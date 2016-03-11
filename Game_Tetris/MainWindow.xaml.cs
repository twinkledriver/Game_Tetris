using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using Game_Tetris.GameLogic;

namespace Game_Tetris
{
    [Serializable]
    public partial class Form1 : Form
    {
        public int Result;//保存最高分

        public GameRecord[] grs;//排序后的游戏记录对象数组

        public int time;// 统计已过时间

        public String name { get; set; }//接收从GameUserRecord窗口传回的名字

        public bool tf = false;

        public Graphics gs;//绘图类

        public Graphics ggss;//创建下一个图形panel的画板

        public 下落图形基类 obj = null;

        public 游戏规则类 regulation = null;

        public GamePlayer gps;//初始化存储玩家记录的集合

        public GamePlayer gss;//初始化存储玩家记录的集合

        public ButtonRecord BR;//此类中包含有存储着每局游戏用户的按键操作

        public BlockRecord Blr;//此类中包含有存储着游戏的图形

        public List<下落图形基类> listb = new List<下落图形基类>();


        public Form1()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            InitializeComponent();
        }

        public int OK()
        {
            return this.timer1.Interval;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel.BackgroundImage = Properties.Resources.zhujiemian;
            gps = new GamePlayer();
            rbo1.Checked = true;
            //copyMusic();
            this.KeyPreview = true;
            ggss = this.panelNext.CreateGraphics();//同下
            gs = this.Panel.CreateGraphics();//把整个panel控件作为一个绘图的区域
            regulation = new 游戏规则类(gps);
            //gps.us.Clear();
            //regulation.initialization();
            regulation.contrary();//反序列化

            // txtName.Clear();

            if (gps.us.Count > 0)//大于0说明集合中有元素
            {
                grs = new GameRecord[gps.us.Count];
                gpsSort();//对象数组排序
                MaxResult();
            }
        }

        /// <summary>
        /// 传一个对象数组和GamePlayer类的对象过来，将GameRecord类的List<GameRecord>集合转成对象数组给grs
        /// </summary>
        /// <param name="grs"></param>
        /// <param name="gps"></param>
        public void gpsSort()
        {
            grs = new GameRecord[gps.us.Count];

            int a = 0;
            foreach (GameRecord dr in gps.us)
            {
                grs[a] = dr;
                a++;
            }

            for (int j = 0; j < grs.Length; j++)
            {
                for (int i = 0; i < grs.Length - j - 1; i++)
                {
                    if (grs[i].Result < grs[i + 1].Result)
                    {
                        GameRecord gr;
                        gr = grs[i];
                        grs[i] = grs[i + 1];
                        grs[i + 1] = gr;
                    }
                }
            }
        }


        /// <summary>
        /// 获取游戏记录中的最高分，并把值给lable标签
        /// </summary>
        public void MaxResult()
        {
            Result = grs[0].Result;
            lblMaxResult.Text = Result.ToString();
        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)//开始
        {
            if (txtName.Text == "请输入玩家姓名" || txtName.Text == "")
            {
                MessageBox.Show("请输入玩家姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbo1.Checked)
            {
                timer1.Interval = 350;
            }
            else if (rbo2.Checked)
            {
                timer1.Interval = 300;
            }
            else if (rbo3.Checked)
            {
                timer1.Interval = 200;
            }
            Blr = new BlockRecord();
            BR = new ButtonRecord();//游戏开始重新开辟在内存中开辟空间
            lblNext.Visible = true;
            txtName.Enabled = false;
            lblTitle.Visible = false;
            ClearAndShow();
            panelNext.Visible = true;
            timer1.Enabled = true;
            rbo1.Enabled = false;
            rbo2.Enabled = false;
            rbo3.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            timed.Enabled = true;
            tf = true;

        }
        /// <summary>
        /// 刷新并显示新的俄罗斯方块游戏面板
        /// </summary>
        private void ClearAndShow()
        {

            tf = true;
            this.RefreshUI();
            obj = regulation.diamondsLocation();
            obj.Daw(gs);
            gainFigure(PublicData.RandomNumber2);
        }

        /// <summary>
        /// 刷新下一块图形的画板
        /// </summary>
        public void RefreshPanelNext(Graphics gps)
        {
            gps.Clear(Color.Black);
        }

        public void gainFigure(int num)
        {

            下落图形基类 obj;
            switch (num)
            {
                case 1:
                    obj = new 长条形(2, 2);
                    break;
                case 2:
                    obj = new Z型(2, 2);
                    break;
                case 3:
                    obj = new 田型(3, 2);
                    break;
                case 4:
                    obj = new 土型(2, 2);
                    break;
                case 5:
                    obj = new _7型(3, 1);
                    break;
                case 6:
                    obj = new 反7型(2, 1);
                    break;
                case 7:
                    obj = new 反Z型(2, 2);
                    break;
                default:
                    obj = new 长条形(2, 2);
                    break;
            }
            RefreshPanelNext(ggss);
            obj.Daw(ggss);
        }

        //界面刷新
        private void RefreshUI()
        {
            RefreshPanelNext(gs);
            //加载保存到游戏规则类里的小方块那里的小方块
            foreach (小方块 item in regulation.Blocks)
            {
                item.Graw(gs);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  timer1.Enabled = true;
        }

        /// <summary>
        /// 根据所选难度加分
        /// </summary>
        private void AddResult()
        {
            if (rbo1.Checked)
            {
                lblResult.Text = (PublicData.RowsSum * 100).ToString();
            }
            else if (rbo2.Checked)
            {
                lblResult.Text = (PublicData.RowsSum * 120).ToString();
            }
            else if (rbo3.Checked)
            {
                lblResult.Text = (PublicData.RowsSum * 140).ToString();
            }
        }

        /// <summary>
        /// 游戏结束了保存玩家记录
        /// </summary>
        private void GameEnding()
        {
            RefreshPanelNext(ggss);
            panelNext.Visible = false;
            timer1.Enabled = false;
            tf = false;
            timed.Enabled = false;
            time = 0;
            DialogResult dr = MessageBox.Show("游戏结束，是否保存记录?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            String na = txtName.Text;
            int res = Convert.ToInt16(lblResult.Text);
            afterwards();
            if (dr == DialogResult.Yes)
            {   //保存记录
                GameRecord gr = new GameRecord() { name = na, Result = res, Date = DateTime.Now, Br = BR, Blocks = Blr };
                this.gps.us.Add(gr);
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                gpsSort();//对象数组排序
                MaxResult();
            }

        }

        /// <summary>
        /// 用作游戏结束后做一些善后的处理
        /// </summary>
        public void afterwards()
        {
            lblResult.Text = "0";
            lbltimed.Text = "00:00:00";
            lblTitle.Visible = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            tf = false;
            rbo1.Enabled = true;
            rbo2.Enabled = true;
            rbo3.Enabled = true;
            regulation.Blocks.Clear();
            txtName.Text = "请输入玩家姓名";
            txtName.Enabled = true;
            Panel.BackgroundImage = Properties.Resources.zhujiemian;
        }

        /// <summary>
        /// 下落音效
        /// </summary>
        private void DropSoundEffect()
        {
            this.GameMusic.URL = @"SlidingBlocksMusic\AK47A.WAV";
        }
        /// <summary>
        /// 根据方块的消沉数播放不同的音效
        /// </summary>
        private void Judge()
        {
            if (PublicData.RowsNumber == 1)
            {
                GameMusic.URL = @"SlidingBlocksMusic\one.mp3";
            }
            else if (PublicData.RowsNumber == 2)
            {
                GameMusic.URL = @"SlidingBlocksMusic\two.mp3";
            }
            else if (PublicData.RowsNumber == 3)
            {
                GameMusic.URL = @"SlidingBlocksMusic\three.mp3";
            }
            else if (PublicData.RowsNumber == 4)
            {
                GameMusic.URL = @"SlidingBlocksMusic\four.mp3";
            }
            PublicData.RowsNumber = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (obj != null)
            {
                if (regulation.IsDown(obj))
                {
                    obj.Down();
                }
                else//到底不能动的时候，需要产生新图形
                {
                    DropSoundEffect();
                    //先记录不能再移动的该下落图形
                    regulation.RecodeBlock(obj);
                    AddResult();
                    if (regulation.GameOver())
                    {
                        timer1.Enabled = false;
                        GameEnding();
                        return;
                    }
                    //开始新下落图形
                    ClearAndShow();
                }
                Judge();
                this.RefreshUI();
                //绘制
                obj.Daw(gs);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;
            int hh = time / 60 / 60;
            int mm = time / 60;
            int ss = time % 60;
            String temp = Convert.ToDateTime(String.Format("{0}:{1}:{2}", hh, mm, ss)).ToString();
            String tm = temp.Substring(temp.IndexOf(' '));
            lbltimed.Text = tm;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            regulation.initialization();
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            GameEnding();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Record R = new Record(this);
            R.ShowDialog();
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            txtNameShow();
        }

        /// <summary>
        /// 用户点击用户名文本框时，清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.SelectAll();
            //txtName.Text = "";
        }

        private void txtNameShow()
        {
            if (txtName.Text.Trim() == String.Empty)
            {
                txtName.Text = "请输入玩家姓名";
            }
        }

        private void lbltimed_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // timer1.Enabled = false;
            if (tf)
            {
                //  MessageBox.Show(e.KeyCode.ToString());
                //  BR.buttonKey.Add(e.KeyCode.ToString());

                switch (e.KeyCode.ToString().ToLower())
                {
                    case "w":
                        if (regulation.IsSpin(obj))
                        {
                            obj.spin();
                        }
                        break;
                    case "s":
                        if (regulation.IsDown(obj))
                        {
                            obj.Down();
                        }
                        else//到底不能动的时候，需要产生新图形
                        {
                            DropSoundEffect();
                            //先记录不能再移动的该下落图形
                            //regulation

                            regulation.RecodeBlock(obj);

                            AddResult();

                            if (regulation.GameOver())
                            {
                                GameEnding();
                                break;
                            }
                            //开始新下落图形
                            ClearAndShow();
                        }
                        Judge();

                        break;
                    case "a":
                        if (regulation.IsLeft(obj))
                        {
                            obj.Left();
                        }
                        break;
                    case "d":
                        if (regulation.IsRight(obj))
                        {
                            obj.Right();
                        }
                        break;
                }
                this.RefreshUI();
                obj.Daw(gs);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Record R = new Record(this);
            R.ShowDialog();
        }
    }
}
