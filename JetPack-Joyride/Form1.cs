using Microsoft.VisualBasic.Devices;
using static System.Formats.Asn1.AsnWriter;
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace JetPack_Joyride
{
    public partial class GameZone : Form
    {
        // public var
        bool jump;
        int gravity = 14;
        int force;
        int randomzapper;
        Random rand = new Random();

        public GameZone()
        {
            InitializeComponent();
        }

        private void mainTimer(object sender, EventArgs e)
        {

            // jump
            if (jump)
            {
                caracter.Top -= force;
                force -= 1;
            }

            // intersect with the GameArea.Top
            if (caracter.Top < gameArea.Top)
            {
                /*jump = false;*/
                caracter.Top = gameArea.Top;
            }

            // intersect with the ground
            if (caracter.Bounds.IntersectsWith(ground.Bounds))
            {
                caracter.Top = ground.Top - caracter.Height - 1;
                jump = false;
            }

            /*foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "zapper")
                {
                    x.Left -= 3;
                }
            }*/

            // zapper show or zapper intersect with caracter
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "zapper")
                {
                    // game over
                    if (caracter.Bounds.IntersectsWith(x.Bounds))
                    {
                        //stop
                    }

                    // redefinde zapper compared the gameArea
                    if (x.Right < gameArea.Left)
                    {
                        x.Location = new Point(x.Location.X + 100, x.Location.Y);

                        // take a random enemy skin
                        /*randomzapper = rand.Next(0, 3);
                        switch (randomzapper)
                        {
                            case 0: pictureBox1.Image = Properties.Resources.L2; break;
                            case 1: pictureBox1.Image = Properties.Resources.L9; break;
                            case 2: pictureBox1.Image = Properties.Resources.L11; break;
                            case 3: pictureBox1.Image = Properties.Resources.L12; break;
                        }*/
                    }
                }
            }
        }

        // control when key is down
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jump = true;
                force = gravity;
            } else
            {
                jump = false;
            }
        }
    }
}