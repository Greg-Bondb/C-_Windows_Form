namespace DoddleJumps
{
    partial class GameZone
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
            this.doodle = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.DeathBar = new System.Windows.Forms.PictureBox();
            this.gameArea = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Game_menu = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.HighValue = new System.Windows.Forms.Label();
            this.Game_caracter = new System.Windows.Forms.GroupBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.doodle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeathBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Game_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.Game_caracter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // doodle
            // 
            this.doodle.BackColor = System.Drawing.SystemColors.Control;
            this.doodle.BackgroundImage = global::DoddleJumps.Properties.Resources.back;
            this.doodle.Location = new System.Drawing.Point(147, 573);
            this.doodle.Name = "doodle";
            this.doodle.Size = new System.Drawing.Size(50, 50);
            this.doodle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doodle.TabIndex = 0;
            this.doodle.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.mainTimer);
            // 
            // DeathBar
            // 
            this.DeathBar.BackColor = System.Drawing.Color.Red;
            this.DeathBar.Location = new System.Drawing.Point(12, 689);
            this.DeathBar.Name = "DeathBar";
            this.DeathBar.Size = new System.Drawing.Size(558, 14);
            this.DeathBar.TabIndex = 2;
            this.DeathBar.TabStop = false;
            this.DeathBar.Tag = "";
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.SystemColors.Control;
            this.gameArea.BackgroundImage = global::DoddleJumps.Properties.Resources.Fond;
            this.gameArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gameArea.Location = new System.Drawing.Point(12, 40);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(558, 650);
            this.gameArea.TabIndex = 3;
            this.gameArea.TabStop = false;
            this.gameArea.Click += new System.EventHandler(this.gameArea_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Image = global::DoddleJumps.Properties.Resources.platform;
            this.pictureBox3.Location = new System.Drawing.Point(350, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "plateforme";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Image = global::DoddleJumps.Properties.Resources.platform;
            this.pictureBox5.Location = new System.Drawing.Point(12, 150);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "plateforme";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::DoddleJumps.Properties.Resources.platform;
            this.pictureBox2.Location = new System.Drawing.Point(139, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "plateforme";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Image = global::DoddleJumps.Properties.Resources.platform;
            this.pictureBox4.Location = new System.Drawing.Point(166, 250);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "plateforme";
            // 
            // Game_menu
            // 
            this.Game_menu.Controls.Add(this.label3);
            this.Game_menu.Controls.Add(this.label2);
            this.Game_menu.Controls.Add(this.label1);
            this.Game_menu.Location = new System.Drawing.Point(147, 310);
            this.Game_menu.Name = "Game_menu";
            this.Game_menu.Size = new System.Drawing.Size(289, 170);
            this.Game_menu.TabIndex = 16;
            this.Game_menu.TabStop = false;
            this.Game_menu.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(45, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "GAME OVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(104, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(93, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::DoddleJumps.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(350, 553);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "plateforme";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox6.Image = global::DoddleJumps.Properties.Resources.platform;
            this.pictureBox6.Location = new System.Drawing.Point(251, 50);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(111, 17);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "plateforme";
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox0.Image = global::DoddleJumps.Properties.Resources.platform;
            this.pictureBox0.Location = new System.Drawing.Point(118, 622);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(111, 17);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox0.TabIndex = 19;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Tag = "plateforme";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Cyan;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.ForeColor = System.Drawing.Color.Black;
            this.Score.Location = new System.Drawing.Point(32, 663);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(75, 23);
            this.Score.TabIndex = 18;
            this.Score.Text = "Score : 0";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Cyan;
            this.HighScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighScore.ForeColor = System.Drawing.Color.Black;
            this.HighScore.Location = new System.Drawing.Point(178, 663);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(102, 23);
            this.HighScore.TabIndex = 20;
            this.HighScore.Text = "High Score :";
            // 
            // HighValue
            // 
            this.HighValue.AutoSize = true;
            this.HighValue.BackColor = System.Drawing.Color.Cyan;
            this.HighValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighValue.ForeColor = System.Drawing.Color.Black;
            this.HighValue.Location = new System.Drawing.Point(273, 663);
            this.HighValue.Name = "HighValue";
            this.HighValue.Size = new System.Drawing.Size(19, 23);
            this.HighValue.TabIndex = 21;
            this.HighValue.Text = "0";
            // 
            // Game_caracter
            // 
            this.Game_caracter.Controls.Add(this.img3);
            this.Game_caracter.Controls.Add(this.img4);
            this.Game_caracter.Controls.Add(this.img2);
            this.Game_caracter.Controls.Add(this.img1);
            this.Game_caracter.Location = new System.Drawing.Point(43, 310);
            this.Game_caracter.Name = "Game_caracter";
            this.Game_caracter.Size = new System.Drawing.Size(495, 195);
            this.Game_caracter.TabIndex = 18;
            this.Game_caracter.TabStop = false;
            this.Game_caracter.Text = "Selection du personnage";
            // 
            // img3
            // 
            this.img3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img3.Image = global::DoddleJumps.Properties.Resources.Skin35;
            this.img3.Location = new System.Drawing.Point(269, 56);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(85, 90);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3.TabIndex = 4;
            this.img3.TabStop = false;
            this.img3.Click += new System.EventHandler(this.img3_Click);
            // 
            // img4
            // 
            this.img4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img4.Image = global::DoddleJumps.Properties.Resources.Skin45;
            this.img4.Location = new System.Drawing.Point(384, 56);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(85, 90);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img4.TabIndex = 3;
            this.img4.TabStop = false;
            this.img4.Click += new System.EventHandler(this.img4_Click);
            // 
            // img2
            // 
            this.img2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img2.Image = global::DoddleJumps.Properties.Resources.Skin2;
            this.img2.Location = new System.Drawing.Point(152, 56);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(85, 90);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 1;
            this.img2.TabStop = false;
            this.img2.Click += new System.EventHandler(this.img2_Click);
            // 
            // img1
            // 
            this.img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img1.Image = global::DoddleJumps.Properties.Resources.Skin1;
            this.img1.Location = new System.Drawing.Point(35, 56);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(85, 90);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.img1_Click);
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.SystemColors.Control;
            this.enemy.BackgroundImage = global::DoddleJumps.Properties.Resources.back;
            this.enemy.Location = new System.Drawing.Point(365, 695);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(85, 65);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy.TabIndex = 22;
            this.enemy.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.BackgroundImage = global::DoddleJumps.Properties.Resources.back;
            this.ball.Image = global::DoddleJumps.Properties.Resources.Ball;
            this.ball.Location = new System.Drawing.Point(499, 622);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(39, 39);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 23;
            this.ball.TabStop = false;
            // 
            // GameZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(582, 705);
            this.Controls.Add(this.Game_caracter);
            this.Controls.Add(this.Game_menu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.HighValue);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pictureBox0);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.DeathBar);
            this.Controls.Add(this.doodle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gameArea);
            this.ForeColor = System.Drawing.Color.YellowGreen;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameZone";
            this.Text = "Horreur Jump !";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.doodle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeathBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Game_menu.ResumeLayout(false);
            this.Game_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.Game_caracter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox doodle;
        private System.Windows.Forms.Timer timer;
        private PictureBox DeathBar;
        private PictureBox gameArea;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private GroupBox Game_menu;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox0;
        private Label Score;
        private Label HighScore;
        private Label HighValue;
        private GroupBox Game_caracter;
        private PictureBox img4;
        private PictureBox img2;
        private PictureBox img1;
        private PictureBox img3;
        private PictureBox enemy;
        private PictureBox ball;
    }
}