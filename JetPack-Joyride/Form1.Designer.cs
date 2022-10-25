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
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper3)).BeginInit();
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
            this.ground.Size = new System.Drawing.Size(798, 20);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // caracter
            // 
            this.caracter.BackColor = System.Drawing.Color.Transparent;
            this.caracter.Image = global::JetPack_Joyride.Properties.Resources.caracter;
            this.caracter.Location = new System.Drawing.Point(103, 367);
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
            // GameZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JetPack_Joyride.Properties.Resources.de4pasy_9dc3d7ad_2e4c_4930_9968_4bf756402c1d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.zapper3);
            this.Controls.Add(this.caracter);
            this.Controls.Add(this.zapper2);
            this.Controls.Add(this.zapper1);
            this.Controls.Add(this.gameArea);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "GameZone";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapper3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox gameArea;
        private PictureBox ground;
        private PictureBox caracter;
        private System.Windows.Forms.Timer timer;
        private PictureBox zapper1;
        private PictureBox zapper2;
        private PictureBox zapper3;
    }
}