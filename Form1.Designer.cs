
namespace circle_tap
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.real_timer = new System.Windows.Forms.Label();
            this.replay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Smile3 = new System.Windows.Forms.PictureBox();
            this.Smile2 = new System.Windows.Forms.PictureBox();
            this.Smile1 = new System.Windows.Forms.PictureBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.Game_Menu = new System.Windows.Forms.GroupBox();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.high_Score = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Smile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smile1)).BeginInit();
            this.Game_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // real_timer
            // 
            this.real_timer.AutoSize = true;
            this.real_timer.BackColor = System.Drawing.Color.Transparent;
            this.real_timer.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.real_timer.Location = new System.Drawing.Point(494, 22);
            this.real_timer.Name = "real_timer";
            this.real_timer.Size = new System.Drawing.Size(154, 32);
            this.real_timer.TabIndex = 2;
            this.real_timer.Text = "Time Left: 25";
            // 
            // replay
            // 
            this.replay.BackColor = System.Drawing.Color.RoyalBlue;
            this.replay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replay.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.replay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.replay.Location = new System.Drawing.Point(282, 15);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(121, 45);
            this.replay.TabIndex = 3;
            this.replay.Text = "Play";
            this.replay.UseVisualStyleBackColor = false;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 5;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Azure;
            this.save.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(118, 23);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(68, 32);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Azure;
            this.load.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.load.Location = new System.Drawing.Point(44, 23);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(68, 32);
            this.load.TabIndex = 7;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.LightCyan;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.label7);
            this.gamePanel.Controls.Add(this.label6);
            this.gamePanel.Controls.Add(this.label5);
            this.gamePanel.Controls.Add(this.label4);
            this.gamePanel.Controls.Add(this.label3);
            this.gamePanel.Controls.Add(this.label2);
            this.gamePanel.Controls.Add(this.Smile3);
            this.gamePanel.Controls.Add(this.Smile2);
            this.gamePanel.Controls.Add(this.Smile1);
            this.gamePanel.Controls.Add(this.GameNameLabel);
            this.gamePanel.ForeColor = System.Drawing.Color.Coral;
            this.gamePanel.Location = new System.Drawing.Point(41, 60);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(607, 314);
            this.gamePanel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(210, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 56);
            this.label7.TabIndex = 21;
            this.label7.Text = "-15 + Kill All Objects\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(210, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 56);
            this.label6.TabIndex = 20;
            this.label6.Text = "-15 + Time Reduce\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(257, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "+5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(76, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bad Point: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bad Point: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Positive Point: ";
            // 
            // Smile3
            // 
            this.Smile3.Image = global::circle_tap.Properties.Resources.smile22;
            this.Smile3.Location = new System.Drawing.Point(0, 250);
            this.Smile3.Name = "Smile3";
            this.Smile3.Size = new System.Drawing.Size(89, 38);
            this.Smile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Smile3.TabIndex = 15;
            this.Smile3.TabStop = false;
            // 
            // Smile2
            // 
            this.Smile2.Image = global::circle_tap.Properties.Resources.smile21;
            this.Smile2.Location = new System.Drawing.Point(-1, 183);
            this.Smile2.Name = "Smile2";
            this.Smile2.Size = new System.Drawing.Size(90, 39);
            this.Smile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Smile2.TabIndex = 14;
            this.Smile2.TabStop = false;
            // 
            // Smile1
            // 
            this.Smile1.Image = global::circle_tap.Properties.Resources.smile2;
            this.Smile1.Location = new System.Drawing.Point(-1, 120);
            this.Smile1.Name = "Smile1";
            this.Smile1.Size = new System.Drawing.Size(90, 38);
            this.Smile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Smile1.TabIndex = 13;
            this.Smile1.TabStop = false;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameNameLabel.Font = new System.Drawing.Font("Magneto", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.GameNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.GameNameLabel.Location = new System.Drawing.Point(37, 18);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(533, 81);
            this.GameNameLabel.TabIndex = 11;
            this.GameNameLabel.Text = "Smiley Killer";
            // 
            // Game_Menu
            // 
            this.Game_Menu.BackColor = System.Drawing.Color.LightCyan;
            this.Game_Menu.Controls.Add(this.lbl_quit);
            this.Game_Menu.Controls.Add(this.lbl_restart);
            this.Game_Menu.Controls.Add(this.lbl_over);
            this.Game_Menu.Controls.Add(this.high_Score);
            this.Game_Menu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Game_Menu.Location = new System.Drawing.Point(-4, -1);
            this.Game_Menu.Name = "Game_Menu";
            this.Game_Menu.Size = new System.Drawing.Size(701, 415);
            this.Game_Menu.TabIndex = 9;
            this.Game_Menu.TabStop = false;
            this.Game_Menu.Text = "End Menu";
            this.Game_Menu.Enter += new System.EventHandler(this.Game_Menu_Enter);
            // 
            // lbl_quit
            // 
            this.lbl_quit.AutoSize = true;
            this.lbl_quit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_quit.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_quit.Location = new System.Drawing.Point(559, 346);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(127, 59);
            this.lbl_quit.TabIndex = 10;
            this.lbl_quit.Text = "Quit";
            this.lbl_quit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_quit.Click += new System.EventHandler(this.lbl_quit_Click);
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_restart.Font = new System.Drawing.Font("Imprint MT Shadow", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_restart.Location = new System.Drawing.Point(219, 190);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(270, 88);
            this.lbl_restart.TabIndex = 9;
            this.lbl_restart.Text = "Restart";
            this.lbl_restart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_restart.Click += new System.EventHandler(this.lbl_restart_Click);
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_over.Location = new System.Drawing.Point(59, 42);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(594, 113);
            this.lbl_over.TabIndex = 8;
            this.lbl_over.Text = "Game - Over";
            this.lbl_over.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // high_Score
            // 
            this.high_Score.AutoSize = true;
            this.high_Score.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.high_Score.Location = new System.Drawing.Point(6, 373);
            this.high_Score.Name = "high_Score";
            this.high_Score.Size = new System.Drawing.Size(127, 30);
            this.high_Score.TabIndex = 4;
            this.high_Score.Text = "High Score:";
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContinueButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ContinueButton.Location = new System.Drawing.Point(227, 12);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(220, 49);
            this.ContinueButton.TabIndex = 11;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(691, 413);
            this.Controls.Add(this.Game_Menu);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.real_timer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Smile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Smile1)).EndInit();
            this.Game_Menu.ResumeLayout(false);
            this.Game_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label real_timer;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.GroupBox Game_Menu;
        private System.Windows.Forms.Label lbl_quit;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label high_Score;
        private System.Windows.Forms.PictureBox Smile3;
        private System.Windows.Forms.PictureBox Smile2;
        private System.Windows.Forms.PictureBox Smile1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ContinueButton;
    }
}

