using Microsoft.VisualBasic.Devices;
using static System.Formats.Asn1.AsnWriter;
using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace JetPack_Joyride
{
    public partial class GameZone : Form
    {
        // public var
        bool jump;
        int gravity = 14;
        int force, score, randomzapper, compteur, score_coin;
        Random rand = new Random();
        System.Windows.Forms.PictureBox zappername;

        public GameZone()
        {
            InitializeComponent();
        }

        private void mainTimer(object sender, EventArgs e)
        {

            Game_menu.Hide();

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

            // register the Best Score
            int BestScore = Int32.Parse(HighValue.Text);

            if (score > BestScore)
            {
                HighValue.Text = score.ToString();
                Properties.Settings.Default.HScore = HighValue.Text;
                Properties.Settings.Default.Save();
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
                        timer.Stop();
                        Game_menu.Show();
                        score = 0;
                        compteur = 0;
                        score_coin = 0;
                        jump = false;
                    }

                    // redefinde zapper compared the gameArea
                    if (x.Right < gameArea.Left)
                    {

                        // add score
                        if (compteur > 1)
                        {
                            score++;
                            Score.Text = "Score :" + score;
                        }

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

                        compteur++;
                        x.Location = new Point(gameArea.Right, rand.Next(gameArea.Top, (gameArea.Bottom - x.Height - ground.Height)));
                    }
                }
            }

            // coin
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "coin")
                {
                    // coin left scroll
                    x.Location = new Point(x.Location.X - 4, x.Location.Y);

                    // add coin
                    if (caracter.Bounds.IntersectsWith(x.Bounds)&& x.Visible == true)
                    {
                        x.Hide();
                        score_coin++;
                        Coin.Text = "Coin :" + score_coin;
                    }

                    // redefinde coin compared the gameArea
                    if (x.Right < gameArea.Left)
                    {
                        x.Show();
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

        // To make a clean restart at the game launch
        private void label1_Click(object sender, EventArgs e)
        {
            timer.Start();
            Game_menu.Hide();
            Score.Text = "Score :" + score;
            Coin.Text = "Coin :" + score_coin;
            caracter.Location = new Point(100, 367);
            zapper1.Location = new Point(2, 430);
            zapper2.Location = new Point(326, 430);
            zapper3.Location = new Point(649, 430);
            coin1.Location = new Point(220, 430);
            coin2.Location = new Point(549, 430);
        }

        // To quit the game
        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}