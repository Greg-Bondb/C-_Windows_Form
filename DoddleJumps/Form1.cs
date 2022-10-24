namespace DoddleJumps
{
    // main class
    public partial class GameZone : Form
    {
        // public var
        bool goLeft, goRight;
        bool jump;
        bool dropBall;
        int gravity = 15;
        int force;
        int score;
        int compteur = 0;
        int randomEnemySkin;
        System.Drawing.Bitmap doolePicture;
        System.Drawing.Bitmap reverseDoodlePicture;
        Random rand = new Random();

        public GameZone() 
        { 
            InitializeComponent(); 
            Game_menu.Hide(); 
            HighValue.Text = Properties.Settings.Default.HScore;
        }
        private void gameArea_Click(object sender, EventArgs e)
        {
            ball.Location = new Point(doodle.Location.X, doodle.Location.Y);
            dropBall = true;
        }

        // main Timer
        private void mainTimer(object sender, EventArgs e)
        {
            // to make doodle don't move at the start
            if (Game_caracter.Visible)
            {
                doodle.Location = new Point(147, 584);
            }

            // doodle control && doodle skin
            if (doodle.Location.X == 147 && doodle.Location.Y == 572) { doodle.Image = reverseDoodlePicture; }
            if (goLeft) { doodle.Left -= 5; doodle.Image = doolePicture; }
            if (goRight) { doodle.Left += 5; doodle.Image = reverseDoodlePicture; }

            // doodle teleport right and left zone
            if (doodle.Left < gameArea.Left) { doodle.Location = new Point(gameArea.Right - 50, doodle.Location.Y); }
            if (doodle.Right > gameArea.Right) { doodle.Location = new Point(gameArea.Left, doodle.Location.Y); }

            // doodle jump
            if (jump)
            {
                doodle.Top -= force;
                force -= 1;
            }
            // doodle fall at the start
            else if (score < 1)
            {
                doodle.Top += 5;
            }
            // doodle stabilize 
            if (doodle.Top >= gameArea.Height)
            {
                doodle.Top = gameArea.Height;
                jump = false;
            }

            // register the Best Score
            int BestScore = Int32.Parse(HighValue.Text);

            if ((score / 7) > BestScore)
            {
                HighValue.Text = (score / 7).ToString();
                Properties.Settings.Default.HScore = HighValue.Text;
                Properties.Settings.Default.Save();
            }

            // throw a ball
            ball.Hide();

            if (dropBall == true)
            {
                ball.Show();
                ball.Top -= 10;
                if (ball.Top <= gameArea.Top)
                {
                    dropBall = false;
                    ball.Hide();
                    ball.Top = DeathBar.Top;
                }
            }

            // enemy hide or enemy intersect with ball
            if (enemy.Bottom > gameArea.Bottom || ball.Bounds.IntersectsWith(enemy.Bounds))
            {
                if (ball.Bounds.IntersectsWith(enemy.Bounds))
                {
                    score += 7;
                    compteur++;
                }
                // redefinde the enemy compared the gameArea
                enemy.Top = gameArea.Top - 400;
                enemy.Left = rand.Next(0, gameArea.Width - enemy.Width);
                randomEnemySkin = rand.Next(0, 3);
                // take a random enemy skin
                switch (randomEnemySkin)
                {
                    case 0: enemy.Image = Properties.Resources.Enemy1; break;
                    case 1: enemy.Image = Properties.Resources.Enemy2; break;
                    case 2: enemy.Image = Properties.Resources.Enemy3; break;
                    case 3: enemy.Image = Properties.Resources.Enemy4; break;
                }
            }

            // doodle intersect with deathbar or enemy
            if (doodle.Bounds.IntersectsWith(DeathBar.Bounds) || doodle.Bounds.IntersectsWith(enemy.Bounds))
            {
                timer.Stop();
                Game_menu.Show();
                score = 0;
                jump = false;
                compteur = 0;
            }

            // doodle intersect with plateforme
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "plateforme")
                {
                    if (doodle.Bounds.IntersectsWith(x.Bounds) && doodle.Bottom - 20 <= x.Top)
                    {
                        force = 15;
                        doodle.Top = x.Top - doodle.Height;
                        if (compteur == 0 && x.Name != "pictureBox0")
                        {
                            score += 7;
                            compteur++;
                        }
                        // redefinde plateform, doodle and enemy compared doodle Location
                        if (doodle.Location.Y <= 450)
                        {
                            foreach (Control y in this.Controls)
                            {
                                if ((string)y.Tag == "plateforme")
                                {
                                    y.Location = new Point(y.Location.X, y.Location.Y + 100);
                                    enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + 15);
                                    doodle.Location = new Point(doodle.Location.X, doodle.Location.Y + 15);

                                    score++;
                                }
                            }
                        }
                        Score.Text = "Score :" + score / 7;
                    }
                    // definde random plateform Left
                    if (x.Bottom > gameArea.Bottom)
                    {
                        x.Top = gameArea.Top;
                        x.Left = rand.Next(0, gameArea.Width - x.Width);
                    }
                }
            }
        }

        // doodle control when key is down
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Q) { goLeft = true; }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { goRight = true; }

            if (jump != true && e.KeyCode == Keys.Space)
            {
                jump = true;
                force = gravity;
            }
        }

        // doodle control when key is up
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Q) { goLeft = false; }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) { goRight = false; }
        }

        // To make a clean restart at the game launch
        private void label1_Click(object sender, EventArgs e)
        {
            timer.Start();
            Game_menu.Hide();
            doodle.Location = new Point(147, 584);
            pictureBox0.Location = new Point(118, 622);
            pictureBox1.Location = new Point(350, 550);
            pictureBox2.Location = new Point(139, 450);
            pictureBox3.Location = new Point(350, 350);
            pictureBox4.Location = new Point(166, 250);
            pictureBox5.Location = new Point(12, 150);
            pictureBox6.Location = new Point(251, 50);
            enemy.Location = new Point(365, 695);
        }

        // To quit the game
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // choose the doodle skin
        private void img1_Click(object sender, EventArgs e)
        {
            doolePicture = Properties.Resources.Skin1;
            reverseDoodlePicture = Properties.Resources.Skin15;
            Game_caracter.Hide();
        }

        private void img2_Click(object sender, EventArgs e)
        {
            doolePicture = Properties.Resources.Skin2;
            reverseDoodlePicture = Properties.Resources.Skin25;
            Game_caracter.Hide();
        }

        private void img3_Click(object sender, EventArgs e)
        {
            doolePicture = Properties.Resources.Skin3;
            reverseDoodlePicture = Properties.Resources.Skin35;
            Game_caracter.Hide();
        }

        private void img4_Click(object sender, EventArgs e)
        {
            doolePicture = Properties.Resources.Skin4;
            reverseDoodlePicture = Properties.Resources.Skin45;
            Game_caracter.Hide();
        }
    }
}