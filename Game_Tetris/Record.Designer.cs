namespace Game_Tetris
{
    partial class Record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.游戏回放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecord = new System.Windows.Forms.Label();
            this.Cmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvShow.ContextMenuStrip = this.Cmenu;
            this.lvShow.FullRowSelect = true;
            this.lvShow.Location = new System.Drawing.Point(13, 33);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(361, 273);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "排名";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "玩家姓名";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "得分";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "日期";
            this.columnHeader3.Width = 106;
            // 
            // Cmenu
            // 
            this.Cmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏回放ToolStripMenuItem});
            this.Cmenu.Name = "Cmenu";
            this.Cmenu.Size = new System.Drawing.Size(153, 48);
            // 
            // 游戏回放ToolStripMenuItem
            // 
            this.游戏回放ToolStripMenuItem.Name = "游戏回放ToolStripMenuItem";
            this.游戏回放ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.游戏回放ToolStripMenuItem.Text = "游戏回放";
            this.游戏回放ToolStripMenuItem.Click += new System.EventHandler(this.游戏回放ToolStripMenuItem_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Font = new System.Drawing.Font("华文彩云", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecord.ForeColor = System.Drawing.Color.PapayaWhip;
            this.lblRecord.Location = new System.Drawing.Point(140, 11);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(115, 21);
            this.lblRecord.TabIndex = 1;
            this.lblRecord.Text = "玩家排行榜";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Tetris.Properties.Resources.zhujiemian;
            this.ClientSize = new System.Drawing.Size(387, 318);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lvShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "游戏记录";
            this.Load += new System.EventHandler(this.Record_Load);
            this.Cmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip Cmenu;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem 游戏回放ToolStripMenuItem;
    }
}