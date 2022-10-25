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
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracter)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.Transparent;
            this.gameArea.Location = new System.Drawing.Point(2, 3);
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
            this.ground.Size = new System.Drawing.Size(798, 21);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // caracter
            // 
            this.caracter.BackColor = System.Drawing.Color.Transparent;
            this.caracter.Image = global::JetPack_Joyride.Properties.Resources.caracter;
            this.caracter.Location = new System.Drawing.Point(97, 366);
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
            // GameZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JetPack_Joyride.Properties.Resources.de4pasy_9dc3d7ad_2e4c_4930_9968_4bf756402c1d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caracter);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.gameArea);
            this.DoubleBuffered = true;
            this.Name = "GameZone";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox gameArea;
        private PictureBox ground;
        private PictureBox caracter;
        private System.Windows.Forms.Timer timer;
    }
}