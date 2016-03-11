namespace Game_Tetris
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltimed = new System.Windows.Forms.Label();
            this.rbo1 = new System.Windows.Forms.RadioButton();
            this.rbo3 = new System.Windows.Forms.RadioButton();
            this.rbo2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.timed = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelNext = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.GameMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.GameSoundEffect = new AxWMPLib.AxWindowsMediaPlayer();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Panel.SuspendLayout();
            this.panelNext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSoundEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackgroundImage = global::Game_Tetris.Properties.Resources.zhujiemian;
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.Controls.Add(this.lblTitle);
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(320, 500);
            this.Panel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(46, 470);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "you are the apple of my eye .";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(387, 484);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(464, 484);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 28);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "当前得分：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(425, 55);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(17, 18);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "最高分：";
            // 
            // lblMaxResult
            // 
            this.lblMaxResult.AutoSize = true;
            this.lblMaxResult.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxResult.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaxResult.ForeColor = System.Drawing.Color.Red;
            this.lblMaxResult.Location = new System.Drawing.Point(425, 104);
            this.lblMaxResult.Name = "lblMaxResult";
            this.lblMaxResult.Size = new System.Drawing.Size(17, 18);
            this.lblMaxResult.TabIndex = 12;
            this.lblMaxResult.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "已过时间：";
            // 
            // lbltimed
            // 
            this.lbltimed.AutoSize = true;
            this.lbltimed.BackColor = System.Drawing.Color.Transparent;
            this.lbltimed.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltimed.ForeColor = System.Drawing.Color.Red;
            this.lbltimed.Location = new System.Drawing.Point(425, 157);
            this.lbltimed.Name = "lbltimed";
            this.lbltimed.Size = new System.Drawing.Size(72, 18);
            this.lbltimed.TabIndex = 14;
            this.lbltimed.Text = "00:00:00";
            this.lbltimed.Click += new System.EventHandler(this.lbltimed_Click);
            // 
            // rbo1
            // 
            this.rbo1.AutoSize = true;
            this.rbo1.BackColor = System.Drawing.Color.Transparent;
            this.rbo1.Location = new System.Drawing.Point(362, 193);
            this.rbo1.Name = "rbo1";
            this.rbo1.Size = new System.Drawing.Size(47, 16);
            this.rbo1.TabIndex = 15;
            this.rbo1.TabStop = true;
            this.rbo1.Text = "简单";
            this.rbo1.UseVisualStyleBackColor = false;
            // 
            // rbo3
            // 
            this.rbo3.AutoSize = true;
            this.rbo3.BackColor = System.Drawing.Color.Transparent;
            this.rbo3.Location = new System.Drawing.Point(481, 193);
            this.rbo3.Name = "rbo3";
            this.rbo3.Size = new System.Drawing.Size(47, 16);
            this.rbo3.TabIndex = 16;
            this.rbo3.TabStop = true;
            this.rbo3.Text = "困难";
            this.rbo3.UseVisualStyleBackColor = false;
            // 
            // rbo2
            // 
            this.rbo2.AutoSize = true;
            this.rbo2.BackColor = System.Drawing.Color.Transparent;
            this.rbo2.Location = new System.Drawing.Point(416, 193);
            this.rbo2.Name = "rbo2";
            this.rbo2.Size = new System.Drawing.Size(47, 16);
            this.rbo2.TabIndex = 17;
            this.rbo2.TabStop = true;
            this.rbo2.Text = "一般";
            this.rbo2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "玩家：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtName.Location = new System.Drawing.Point(425, 12);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 23);
            this.txtName.TabIndex = 18;
            this.txtName.Text = "请输入玩家姓名";
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            // 
            // timed
            // 
            this.timed.Interval = 1000;
            this.timed.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(451, 456);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "排行榜";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelNext
            // 
            this.panelNext.BackColor = System.Drawing.Color.Transparent;
            this.panelNext.Controls.Add(this.lbl);
            this.panelNext.Location = new System.Drawing.Point(387, 281);
            this.panelNext.Name = "panelNext";
            this.panelNext.Size = new System.Drawing.Size(147, 108);
            this.panelNext.TabIndex = 21;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(92, 77);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 12);
            this.lbl.TabIndex = 1;
            // 
            // lblNext
            // 
            this.lblNext.AutoEllipsis = true;
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(343, 243);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(84, 19);
            this.lblNext.TabIndex = 22;
            this.lblNext.Text = "下个方块：";
            this.lblNext.Visible = false;
            // 
            // GameMusic
            // 
            this.GameMusic.Enabled = true;
            this.GameMusic.Location = new System.Drawing.Point(733, 484);
            this.GameMusic.Name = "GameMusic";
           // this.GameMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("GameMusic.OcxState")));
            this.GameMusic.Size = new System.Drawing.Size(93, 33);
            this.GameMusic.TabIndex = 6;
            this.GameMusic.Visible = false;
            // 
            // GameSoundEffect
            // 
            this.GameSoundEffect.Enabled = true;
            this.GameSoundEffect.Location = new System.Drawing.Point(832, 485);
            this.GameSoundEffect.Name = "GameSoundEffect";
         //   this.GameSoundEffect.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("GameSoundEffect.OcxState")));
            this.GameSoundEffect.Size = new System.Drawing.Size(93, 32);
            this.GameSoundEffect.TabIndex = 5;
            this.GameSoundEffect.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(497, 456);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(33, 13);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "关于";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          //  this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(555, 520);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.panelNext);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rbo2);
            this.Controls.Add(this.rbo3);
            this.Controls.Add(this.rbo1);
            this.Controls.Add(this.lbltimed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMaxResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameMusic);
            this.Controls.Add(this.GameSoundEffect);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         //   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块(作者：all false)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.panelNext.ResumeLayout(false);
            this.panelNext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameSoundEffect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private AxWMPLib.AxWindowsMediaPlayer GameSoundEffect;
        private System.Windows.Forms.Label lblTitle;
        private AxWMPLib.AxWindowsMediaPlayer GameMusic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltimed;
        private System.Windows.Forms.RadioButton rbo1;
        private System.Windows.Forms.RadioButton rbo3;
        private System.Windows.Forms.RadioButton rbo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Timer timed;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelNext;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

