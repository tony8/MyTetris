namespace TetrisSingle
{
    partial class SingleGame
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMap = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLineCount = new System.Windows.Forms.Label();
            this.panelNextPiece = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblShapeZ = new System.Windows.Forms.Label();
            this.lblShapeT = new System.Windows.Forms.Label();
            this.lblShapeS = new System.Windows.Forms.Label();
            this.lblShapeO = new System.Windows.Forms.Label();
            this.lblShapeL = new System.Windows.Forms.Label();
            this.lblShapeJ = new System.Windows.Forms.Label();
            this.lblShapeI = new System.Windows.Forms.Label();
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.textBoxLine = new System.Windows.Forms.TextBox();
            this.textBoxSocre = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMap.Location = new System.Drawing.Point(16, 35);
            this.panelMap.Margin = new System.Windows.Forms.Padding(2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(200, 400);
            this.panelMap.TabIndex = 0;
            this.panelMap.TabStop = true;
            this.panelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMap_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTime);
            this.groupBox1.Controls.Add(this.textBoxSocre);
            this.groupBox1.Controls.Add(this.textBoxLine);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.lblLineCount);
            this.groupBox1.Controls.Add(this.panelNextPiece);
            this.groupBox1.Location = new System.Drawing.Point(299, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(265, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "游戏信息";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(140, 111);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "时  间：";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(139, 74);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 12);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "得  分：";
            // 
            // lblLineCount
            // 
            this.lblLineCount.AutoSize = true;
            this.lblLineCount.Location = new System.Drawing.Point(139, 37);
            this.lblLineCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLineCount.Name = "lblLineCount";
            this.lblLineCount.Size = new System.Drawing.Size(53, 12);
            this.lblLineCount.TabIndex = 1;
            this.lblLineCount.Text = "消行数：";
            // 
            // panelNextPiece
            // 
            this.panelNextPiece.Location = new System.Drawing.Point(18, 32);
            this.panelNextPiece.Margin = new System.Windows.Forms.Padding(2);
            this.panelNextPiece.Name = "panelNextPiece";
            this.panelNextPiece.Size = new System.Drawing.Size(107, 107);
            this.panelNextPiece.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(299, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(265, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "人工智能控制";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.lblShapeZ);
            this.groupBox3.Controls.Add(this.lblShapeT);
            this.groupBox3.Controls.Add(this.lblShapeS);
            this.groupBox3.Controls.Add(this.lblShapeO);
            this.groupBox3.Controls.Add(this.lblShapeL);
            this.groupBox3.Controls.Add(this.lblShapeJ);
            this.groupBox3.Controls.Add(this.lblShapeI);
            this.groupBox3.Location = new System.Drawing.Point(299, 403);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(265, 140);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "统计信息";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(142, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(60, 21);
            this.textBox7.TabIndex = 13;
            this.textBox7.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(142, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(60, 21);
            this.textBox6.TabIndex = 12;
            this.textBox6.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(60, 21);
            this.textBox5.TabIndex = 11;
            this.textBox5.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(42, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(60, 21);
            this.textBox4.TabIndex = 10;
            this.textBox4.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(60, 21);
            this.textBox3.TabIndex = 9;
            this.textBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(60, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(60, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            // 
            // lblShapeZ
            // 
            this.lblShapeZ.AutoSize = true;
            this.lblShapeZ.Location = new System.Drawing.Point(119, 88);
            this.lblShapeZ.Name = "lblShapeZ";
            this.lblShapeZ.Size = new System.Drawing.Size(17, 12);
            this.lblShapeZ.TabIndex = 6;
            this.lblShapeZ.Text = "Z:";
            // 
            // lblShapeT
            // 
            this.lblShapeT.AutoSize = true;
            this.lblShapeT.Location = new System.Drawing.Point(119, 60);
            this.lblShapeT.Name = "lblShapeT";
            this.lblShapeT.Size = new System.Drawing.Size(17, 12);
            this.lblShapeT.TabIndex = 5;
            this.lblShapeT.Text = "T:";
            // 
            // lblShapeS
            // 
            this.lblShapeS.AutoSize = true;
            this.lblShapeS.Location = new System.Drawing.Point(119, 32);
            this.lblShapeS.Name = "lblShapeS";
            this.lblShapeS.Size = new System.Drawing.Size(17, 12);
            this.lblShapeS.TabIndex = 4;
            this.lblShapeS.Text = "S:";
            // 
            // lblShapeO
            // 
            this.lblShapeO.AutoSize = true;
            this.lblShapeO.Location = new System.Drawing.Point(19, 116);
            this.lblShapeO.Name = "lblShapeO";
            this.lblShapeO.Size = new System.Drawing.Size(17, 12);
            this.lblShapeO.TabIndex = 3;
            this.lblShapeO.Text = "O:";
            // 
            // lblShapeL
            // 
            this.lblShapeL.AutoSize = true;
            this.lblShapeL.Location = new System.Drawing.Point(19, 91);
            this.lblShapeL.Name = "lblShapeL";
            this.lblShapeL.Size = new System.Drawing.Size(17, 12);
            this.lblShapeL.TabIndex = 2;
            this.lblShapeL.Text = "L:";
            // 
            // lblShapeJ
            // 
            this.lblShapeJ.AutoSize = true;
            this.lblShapeJ.Location = new System.Drawing.Point(19, 63);
            this.lblShapeJ.Name = "lblShapeJ";
            this.lblShapeJ.Size = new System.Drawing.Size(17, 12);
            this.lblShapeJ.TabIndex = 1;
            this.lblShapeJ.Text = "J:";
            // 
            // lblShapeI
            // 
            this.lblShapeI.AutoSize = true;
            this.lblShapeI.Location = new System.Drawing.Point(19, 32);
            this.lblShapeI.Name = "lblShapeI";
            this.lblShapeI.Size = new System.Drawing.Size(17, 12);
            this.lblShapeI.TabIndex = 0;
            this.lblShapeI.Text = "I:";
            // 
            // timerDown
            // 
            this.timerDown.Interval = 800;
            this.timerDown.Tick += new System.EventHandler(this.timerDown_Tick);
            // 
            // textBoxLine
            // 
            this.textBoxLine.Location = new System.Drawing.Point(186, 33);
            this.textBoxLine.Name = "textBoxLine";
            this.textBoxLine.ReadOnly = true;
            this.textBoxLine.Size = new System.Drawing.Size(74, 21);
            this.textBoxLine.TabIndex = 4;
            this.textBoxLine.TabStop = false;
            // 
            // textBoxSocre
            // 
            this.textBoxSocre.Location = new System.Drawing.Point(186, 71);
            this.textBoxSocre.Name = "textBoxSocre";
            this.textBoxSocre.ReadOnly = true;
            this.textBoxSocre.Size = new System.Drawing.Size(74, 21);
            this.textBoxSocre.TabIndex = 5;
            this.textBoxSocre.TabStop = false;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(186, 106);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(74, 21);
            this.textBoxTime.TabIndex = 6;
            this.textBoxTime.TabStop = false;
            // 
            // SingleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SingleGame";
            this.Text = "经典俄罗斯方块";
            this.Load += new System.EventHandler(this.SingleGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SingleGame_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLineCount;
        private System.Windows.Forms.Panel panelNextPiece;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblShapeZ;
        private System.Windows.Forms.Label lblShapeT;
        private System.Windows.Forms.Label lblShapeS;
        private System.Windows.Forms.Label lblShapeO;
        private System.Windows.Forms.Label lblShapeL;
        private System.Windows.Forms.Label lblShapeJ;
        private System.Windows.Forms.Label lblShapeI;
    
        //计时器，定时执行事件
        private System.Windows.Forms.Timer timerDown;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxSocre;
        private System.Windows.Forms.TextBox textBoxLine;
    }
}

