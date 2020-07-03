namespace Proekt_ArcadeBubblePopper
{
    partial class Form1
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Level = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(11, 9);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(73, 19);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Level
            // 
            this.Level.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(612, 9);
            this.Level.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(54, 19);
            this.Level.TabIndex = 6;
            this.Level.Text = "Level ";
            this.Level.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Level.Click += new System.EventHandler(this.Level_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.pinkBalloon;
            this.pictureBox5.Location = new System.Drawing.Point(254, 306);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 143);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Balloon";
            this.pictureBox5.Click += new System.EventHandler(this.popBalloon);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.redStar;
            this.pictureBox4.Location = new System.Drawing.Point(26, 165);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Balloon";
            this.pictureBox4.Click += new System.EventHandler(this.popBalloon);
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bomb.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(147, 118);
            this.bomb.Margin = new System.Windows.Forms.Padding(2);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(100, 98);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bomb.TabIndex = 2;
            this.bomb.TabStop = false;
            this.bomb.Tag = "Bomb";
            this.bomb.Click += new System.EventHandler(this.popBomb);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.redHeart;
            this.pictureBox2.Location = new System.Drawing.Point(34, 328);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Balloon";
            this.pictureBox2.Click += new System.EventHandler(this.popBalloon);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.yellowBalloon;
            this.pictureBox1.Location = new System.Drawing.Point(290, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Balloon";
            this.pictureBox1.Click += new System.EventHandler(this.popBalloon);
            // 
            // life1
            // 
            this.life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.life1.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.undertale_pixel_heart_png_8;
            this.life1.Location = new System.Drawing.Point(558, 36);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(30, 32);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 7;
            this.life1.TabStop = false;
            this.life1.Tag = "life1";
            // 
            // life2
            // 
            this.life2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.life2.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.undertale_pixel_heart_png_8;
            this.life2.Location = new System.Drawing.Point(594, 36);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(30, 32);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 8;
            this.life2.TabStop = false;
            this.life2.Tag = "life2";
            // 
            // life3
            // 
            this.life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.life3.Image = global::Proekt_ArcadeBubblePopper.Properties.Resources.undertale_pixel_heart_png_8;
            this.life3.Location = new System.Drawing.Point(630, 36);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(30, 32);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 9;
            this.life3.TabStop = false;
            this.life3.Tag = "life3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(677, 609);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Arcade Bubble Popper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
    }
}

