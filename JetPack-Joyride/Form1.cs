
using Microsoft.VisualBasic.Devices;
using static System.Formats.Asn1.AsnWriter;
using System;
using System.Diagnostics;

namespace JetPack_Joyride
{
    public partial class GameZone : Form
    {
        // public var
        bool jump;
        int gravity = 14;
        int force;

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
            /*else
            {
                caracter.Top += force;
            }*/

            // intersect with the GameArea.Top
            if (caracter.Top < gameArea.Top)
            {
                jump = false;
                caracter.Top = gameArea.Top;
            }

            // intersect with the ground
            if (caracter.Bounds.IntersectsWith(ground.Bounds))
            {
                caracter.Top = ground.Top - caracter.Height - 1;
                jump = false;
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