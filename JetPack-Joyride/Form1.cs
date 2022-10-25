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
        System.Windows.Forms.PictureBox zappername;

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

            // zapper show or zapper intersect with caracter
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "zapper")
                {
                    // zapper left scroll
                    x.Location = new Point(x.Location.X - 4, x.Location.Y);

                    // game over
                    if (caracter.Bounds.IntersectsWith(x.Bounds))
                    {
                        //stop
                    }

                    // redefinde zapper compared the gameArea
                    if (x.Right < gameArea.Left)
                    {

                        // take a random enemy skin
                        randomzapper = rand.Next(0, 3);
                        if (x.Name == "zapper1")
                        {
                            zappername = zapper1;
                        }
                        else if (x.Name == "zapper2")
                        {
                            zappername = zapper2;
                        }
                        else
                        {
                            zappername = zapper3;
                        }

                        switch (randomzapper)
                        {
                            case 0: zappername.Image = Properties.Resources.L2; zappername.Size = new Size (130, 125); break;
                            case 1: zappername.Image = Properties.Resources.L9; zappername.Size = new Size(150, 55); break;
                            case 2: zappername.Image = Properties.Resources.L11; zappername.Size = new Size(130, 125); break;
                            case 3: zappername.Image = Properties.Resources.L12; zappername.Size = new Size(50, 140); break;
                        }

                        x.Location = new Point(gameArea.Right, rand.Next(gameArea.Top, (gameArea.Bottom - x.Height - ground.Height)));
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