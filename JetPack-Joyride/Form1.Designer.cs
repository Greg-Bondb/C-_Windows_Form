namespace JetPack_Joyride
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
            this.gameArea = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.caracter = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.zapper1 = new System.Windows.Forms.PictureBox();
            this.zapper2 = new System.Windows.Forms.PictureBox();
            this.zapper3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Game_menu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.HighValue = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.Coin = new System.Windows.Forms.Label();
            this.coin2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper3)).BeginInit();
            this.Game_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.Transparent;
            this.gameArea.Location = new System.Drawing.Point(1, 2);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(798, 448);
            this.gameArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameArea.TabIndex = 0;
            this.gameArea.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ground.Location = new System.Drawing.Point(1, 430);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(798, 20);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // caracter
            // 
            this.caracter.BackColor = System.Drawing.Color.Transparent;
            this.caracter.Image = global::JetPack_Joyride.Properties.Resources.caracter;
            this.caracter.Location = new System.Drawing.Point(100, 367);
            this.caracter.Name = "caracter";
            this.caracter.Size = new System.Drawing.Size(65, 63);
            this.caracter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.caracter.TabIndex = 2;
            this.caracter.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.mainTimer);
            // 
            // zapper1
            // 
            this.zapper1.BackColor = System.Drawing.Color.Transparent;
            this.zapper1.Image = global::JetPack_Joyride.Properties.Resources.L9;
            this.zapper1.Location = new System.Drawing.Point(2, 430);
            this.zapper1.Name = "zapper1";
            this.zapper1.Size = new System.Drawing.Size(150, 50);
            this.zapper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zapper1.TabIndex = 3;
            this.zapper1.TabStop = false;
            this.zapper1.Tag = "zapper";
            // 
            // zapper2
            // 
            this.zapper2.BackColor = System.Drawing.Color.Transparent;
            this.zapper2.Image = global::JetPack_Joyride.Properties.Resources.L9;
            this.zapper2.Location = new System.Drawing.Point(326, 430);
            this.zapper2.Name = "zapper2";
            this.zapper2.Size = new System.Drawing.Size(150, 50);
            this.zapper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zapper2.TabIndex = 4;
            this.zapper2.TabStop = false;
            this.zapper2.Tag = "zapper";
            // 
            // zapper3
            // 
            this.zapper3.BackColor = System.Drawing.Color.Transparent;
            this.zapper3.Image = global::JetPack_Joyride.Properties.Resources.L9;
            this.zapper3.Location = new System.Drawing.Point(649, 430);
            this.zapper3.Name = "zapper3";
            this.zapper3.Size = new System.Drawing.Size(150, 50);
            this.zapper3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zapper3.TabIndex = 5;
            this.zapper3.TabStop = false;
            this.zapper3.Tag = "zapper";
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
            // Game_menu
            // 
            this.Game_menu.Controls.Add(this.label3);
            this.Game_menu.Controls.Add(this.label2);
            this.Game_menu.Controls.Add(this.label1);
            this.Game_menu.Location = new System.Drawing.Point(256, 140);
            this.Game_menu.Name = "Game_menu";
            this.Game_menu.Size = new System.Drawing.Size(289, 170);
            this.Game_menu.TabIndex = 17;
            this.Game_menu.TabStop = false;
            this.Game_menu.Text = "Menu";
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
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Cyan;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.ForeColor = System.Drawing.Color.Black;
            this.Score.Location = new System.Drawing.Point(577, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(75, 23);
            this.Score.TabIndex = 21;
            this.Score.Text = "Score : 0";
            // 
            // HighValue
            // 
            this.HighValue.AutoSize = true;
            this.HighValue.BackColor = System.Drawing.Color.Cyan;
            this.HighValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighValue.ForeColor = System.Drawing.Color.Black;
            this.HighValue.Location = new System.Drawing.Point(763, 9);
            this.HighValue.Name = "HighValue";
            this.HighValue.Size = new System.Drawing.Size(19, 23);
            this.HighValue.TabIndex = 23;
            this.HighValue.Text = "0";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.BackColor = System.Drawing.Color.Cyan;
            this.HighScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighScore.ForeColor = System.Drawing.Color.Black;
            this.HighScore.Location = new System.Drawing.Point(668, 9);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(102, 23);
            this.HighScore.TabIndex = 22;
            this.HighScore.Text = "High Score :";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = global::JetPack_Joyride.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(220, 430);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(40, 39);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 24;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // Coin
            // 
            this.Coin.AutoSize = true;
            this.Coin.BackColor = System.Drawing.Color.Cyan;
            this.Coin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Coin.ForeColor = System.Drawing.Color.Black;
            this.Coin.Location = new System.Drawing.Point(492, 9);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(68, 23);
            this.Coin.TabIndex = 25;
            this.Coin.Text = "Coin : 0";
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = global::JetPack_Joyride.Properties.Resources.coin;
            this.coin2.Location = new System.Drawing.Point(549, 430);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(40, 39);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 29;
            this.coin2.TabStop = false;
            this.coin2.Tag = "coin";
            // 
            // GameZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JetPack_Joyride.Properties.Resources.de4pasy_9dc3d7ad_2e4c_4930_9968_4bf756402c1d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.HighValue);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Game_menu);
            this.Controls.Add(this.zapper3);
            this.Controls.Add(this.caracter);
            this.Controls.Add(this.zapper2);
            this.Controls.Add(this.zapper1);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.gameArea);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "GameZone";
            this.Text = "Jetpack-Joyride";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper3)).EndInit();
            this.Game_menu.ResumeLayout(false);
            this.Game_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox gameArea;
        private PictureBox ground;
        private PictureBox caracter;
        private System.Windows.Forms.Timer timer;
        private PictureBox zapper1;
        private PictureBox zapper2;
        private PictureBox zapper3;
        private Label label3;
        private Label label1;
        private GroupBox Game_menu;
        private Label label2;
        private Label Score;
        private Label HighValue;
        private Label HighScore;
        private PictureBox coin1;
        private Label Coin;
        private PictureBox coin2;
    }
}