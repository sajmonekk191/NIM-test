namespace NIM_v1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sirkyhodnotalbl = new System.Windows.Forms.Label();
            this.sirkynum = new System.Windows.Forms.Label();
            this.sirkymaxpb = new System.Windows.Forms.PictureBox();
            this.sirka1btn = new System.Windows.Forms.Button();
            this.sirka2btn = new System.Windows.Forms.Button();
            this.sirka3btn = new System.Windows.Forms.Button();
            this.sirka1pb = new System.Windows.Forms.PictureBox();
            this.sirka2pb = new System.Windows.Forms.PictureBox();
            this.sirka3pb = new System.Windows.Forms.PictureBox();
            this.startgamebtn = new System.Windows.Forms.Button();
            this.exitgamebtn = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.exitlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mediumbtn = new System.Windows.Forms.Button();
            this.Easybtn = new System.Windows.Forms.Button();
            this.hardbtn = new System.Windows.Forms.Button();
            this.gameoverlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sirkymaxpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka1pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka2pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka3pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sirkyhodnotalbl
            // 
            this.sirkyhodnotalbl.AutoSize = true;
            this.sirkyhodnotalbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sirkyhodnotalbl.Location = new System.Drawing.Point(222, 22);
            this.sirkyhodnotalbl.Name = "sirkyhodnotalbl";
            this.sirkyhodnotalbl.Size = new System.Drawing.Size(50, 25);
            this.sirkyhodnotalbl.TabIndex = 0;
            this.sirkyhodnotalbl.Text = "Sirky";
            // 
            // sirkynum
            // 
            this.sirkynum.AutoSize = true;
            this.sirkynum.Location = new System.Drawing.Point(233, 52);
            this.sirkynum.Name = "sirkynum";
            this.sirkynum.Size = new System.Drawing.Size(32, 15);
            this.sirkynum.TabIndex = 1;
            this.sirkynum.Text = "num";
            // 
            // sirkymaxpb
            // 
            this.sirkymaxpb.BackColor = System.Drawing.Color.Transparent;
            this.sirkymaxpb.Image = global::NIM_v1._0.Properties.Resources.MatchBox;
            this.sirkymaxpb.Location = new System.Drawing.Point(186, 73);
            this.sirkymaxpb.Name = "sirkymaxpb";
            this.sirkymaxpb.Size = new System.Drawing.Size(122, 108);
            this.sirkymaxpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirkymaxpb.TabIndex = 2;
            this.sirkymaxpb.TabStop = false;
            // 
            // sirka1btn
            // 
            this.sirka1btn.Location = new System.Drawing.Point(93, 316);
            this.sirka1btn.Name = "sirka1btn";
            this.sirka1btn.Size = new System.Drawing.Size(75, 23);
            this.sirka1btn.TabIndex = 3;
            this.sirka1btn.Text = "Vzít 1 Sirku";
            this.sirka1btn.UseVisualStyleBackColor = true;
            this.sirka1btn.Click += new System.EventHandler(this.sirka1btn_Click);
            // 
            // sirka2btn
            // 
            this.sirka2btn.Location = new System.Drawing.Point(213, 316);
            this.sirka2btn.Name = "sirka2btn";
            this.sirka2btn.Size = new System.Drawing.Size(75, 23);
            this.sirka2btn.TabIndex = 4;
            this.sirka2btn.Text = "Vzít 2 Sirky";
            this.sirka2btn.UseVisualStyleBackColor = true;
            this.sirka2btn.Click += new System.EventHandler(this.sirka2btn_Click);
            // 
            // sirka3btn
            // 
            this.sirka3btn.Location = new System.Drawing.Point(329, 316);
            this.sirka3btn.Name = "sirka3btn";
            this.sirka3btn.Size = new System.Drawing.Size(75, 23);
            this.sirka3btn.TabIndex = 5;
            this.sirka3btn.Text = "Vzít 3 Sirky";
            this.sirka3btn.UseVisualStyleBackColor = true;
            this.sirka3btn.Click += new System.EventHandler(this.sirka3btn_Click);
            // 
            // sirka1pb
            // 
            this.sirka1pb.BackColor = System.Drawing.Color.Transparent;
            this.sirka1pb.Image = global::NIM_v1._0.Properties.Resources.Sirky1;
            this.sirka1pb.Location = new System.Drawing.Point(88, 338);
            this.sirka1pb.Name = "sirka1pb";
            this.sirka1pb.Size = new System.Drawing.Size(80, 78);
            this.sirka1pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirka1pb.TabIndex = 6;
            this.sirka1pb.TabStop = false;
            // 
            // sirka2pb
            // 
            this.sirka2pb.BackColor = System.Drawing.Color.Transparent;
            this.sirka2pb.Image = global::NIM_v1._0.Properties.Resources.Sirky2;
            this.sirka2pb.Location = new System.Drawing.Point(208, 338);
            this.sirka2pb.Name = "sirka2pb";
            this.sirka2pb.Size = new System.Drawing.Size(80, 78);
            this.sirka2pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirka2pb.TabIndex = 7;
            this.sirka2pb.TabStop = false;
            // 
            // sirka3pb
            // 
            this.sirka3pb.BackColor = System.Drawing.Color.Transparent;
            this.sirka3pb.Image = global::NIM_v1._0.Properties.Resources.Sirky3;
            this.sirka3pb.Location = new System.Drawing.Point(325, 341);
            this.sirka3pb.Name = "sirka3pb";
            this.sirka3pb.Size = new System.Drawing.Size(80, 78);
            this.sirka3pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sirka3pb.TabIndex = 8;
            this.sirka3pb.TabStop = false;
            // 
            // startgamebtn
            // 
            this.startgamebtn.Location = new System.Drawing.Point(34, 35);
            this.startgamebtn.Name = "startgamebtn";
            this.startgamebtn.Size = new System.Drawing.Size(75, 32);
            this.startgamebtn.TabIndex = 9;
            this.startgamebtn.Text = "Start Game";
            this.startgamebtn.UseVisualStyleBackColor = true;
            this.startgamebtn.Click += new System.EventHandler(this.startgamebtn_Click);
            // 
            // exitgamebtn
            // 
            this.exitgamebtn.Location = new System.Drawing.Point(34, 73);
            this.exitgamebtn.Name = "exitgamebtn";
            this.exitgamebtn.Size = new System.Drawing.Size(75, 32);
            this.exitgamebtn.TabIndex = 10;
            this.exitgamebtn.Text = "Exit";
            this.exitgamebtn.UseVisualStyleBackColor = true;
            this.exitgamebtn.Click += new System.EventHandler(this.exitgamebtn_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.BackColor = System.Drawing.Color.Firebrick;
            this.exitlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitlbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitlbl.Location = new System.Drawing.Point(101, 0);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(34, 20);
            this.exitlbl.TabIndex = 11;
            this.exitlbl.Text = "  X  ";
            this.exitlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NIM_v1._0.Properties.Resources.MatchBox;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "NIM v1.0";
            // 
            // Mediumbtn
            // 
            this.Mediumbtn.Location = new System.Drawing.Point(212, 213);
            this.Mediumbtn.Name = "Mediumbtn";
            this.Mediumbtn.Size = new System.Drawing.Size(75, 32);
            this.Mediumbtn.TabIndex = 15;
            this.Mediumbtn.Text = "Medium";
            this.Mediumbtn.UseVisualStyleBackColor = true;
            this.Mediumbtn.Click += new System.EventHandler(this.Mediumbtn_Click);
            // 
            // Easybtn
            // 
            this.Easybtn.Location = new System.Drawing.Point(212, 175);
            this.Easybtn.Name = "Easybtn";
            this.Easybtn.Size = new System.Drawing.Size(75, 32);
            this.Easybtn.TabIndex = 14;
            this.Easybtn.Text = "Easy";
            this.Easybtn.UseVisualStyleBackColor = true;
            this.Easybtn.Click += new System.EventHandler(this.Easybtn_Click);
            // 
            // hardbtn
            // 
            this.hardbtn.Location = new System.Drawing.Point(213, 251);
            this.hardbtn.Name = "hardbtn";
            this.hardbtn.Size = new System.Drawing.Size(75, 32);
            this.hardbtn.TabIndex = 16;
            this.hardbtn.Text = "Hard";
            this.hardbtn.UseVisualStyleBackColor = true;
            this.hardbtn.Click += new System.EventHandler(this.hardbtn_Click);
            // 
            // gameoverlbl
            // 
            this.gameoverlbl.AutoSize = true;
            this.gameoverlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameoverlbl.Location = new System.Drawing.Point(181, 166);
            this.gameoverlbl.Name = "gameoverlbl";
            this.gameoverlbl.Size = new System.Drawing.Size(150, 37);
            this.gameoverlbl.TabIndex = 17;
            this.gameoverlbl.Text = "Game Over";
            this.gameoverlbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 421);
            this.Controls.Add(this.gameoverlbl);
            this.Controls.Add(this.hardbtn);
            this.Controls.Add(this.Mediumbtn);
            this.Controls.Add(this.Easybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.exitgamebtn);
            this.Controls.Add(this.startgamebtn);
            this.Controls.Add(this.sirka3pb);
            this.Controls.Add(this.sirka2pb);
            this.Controls.Add(this.sirka1pb);
            this.Controls.Add(this.sirka3btn);
            this.Controls.Add(this.sirka2btn);
            this.Controls.Add(this.sirka1btn);
            this.Controls.Add(this.sirkymaxpb);
            this.Controls.Add(this.sirkynum);
            this.Controls.Add(this.sirkyhodnotalbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NIM v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.sirkymaxpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka1pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka2pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirka3pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sirkyhodnotalbl;
        private System.Windows.Forms.Label sirkynum;
        private System.Windows.Forms.PictureBox sirkymaxpb;
        private System.Windows.Forms.Button sirka1btn;
        private System.Windows.Forms.Button sirka2btn;
        private System.Windows.Forms.Button sirka3btn;
        private System.Windows.Forms.PictureBox sirka1pb;
        private System.Windows.Forms.PictureBox sirka2pb;
        private System.Windows.Forms.PictureBox sirka3pb;
        private System.Windows.Forms.Button startgamebtn;
        private System.Windows.Forms.Button exitgamebtn;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label exitlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mediumbtn;
        private System.Windows.Forms.Button Easybtn;
        private System.Windows.Forms.Button hardbtn;
        private System.Windows.Forms.Label gameoverlbl;
    }
}
