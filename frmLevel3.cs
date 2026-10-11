using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizQuestFilmEdition.Forms
{
    public partial class frmLevel3 : Form
    {
        string currentDirection = "None";
        int speed = 0;
        int score = 0;

        Random randX = new Random();
        Random randY = new Random();

        public frmLevel3()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        int difficultylvl;
        int timeLeft = 20;

        private void frmLevel3_Load(object sender, EventArgs e)
        {
            //set local var difficulty
                difficultylvl = Classes.GameClass.currentDifficulty;

            //set avatar
               pbxAvatar.Image = Classes.GameClass.GetAvatar();

            tmrAvatar.Enabled = true;

            if (difficultylvl == 1)
            {
                speed = 4;
            }
            else if (difficultylvl == 2)
            {
                speed = 6;
            }
            else
            {
                speed = 8;
            }
        }

        private void frmLevel3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Right:
                    currentDirection = "Right";
                    break;

                case Keys.Left:
                    currentDirection = "Left";
                    break;


            }
        }

        private void tmrAvatar_Tick(object sender, EventArgs e)
        {
            
    

            switch (currentDirection)
            {
                case "Right":
                    if (pbxAvatar.Left + 20 < this.ClientSize.Width - pbxAvatar.Width)
                    {
                        pbxAvatar.Left += 20;
                    }
                    break;

                case "Left":
                    if (pbxAvatar.Left - 20 > 0)
                    {
                        pbxAvatar.Left -= 20;
                    }
                    break;
            }


        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = ($"Score: {score}");
            lblSpeed.Text = ($"Speed: {speed}");

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "collect")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        stopOverlap((PictureBox)x);

                    }
                    if (pbxAvatar.Bounds.IntersectsWith(x.Bounds))
                    {
                        stopOverlap((PictureBox)x);

                        score++;
                    }
                }
            }

            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && (string)z.Tag == "avoid")
                {
                    z.Top += speed;

                    if (z.Top + z.Height > this.ClientSize.Height)
                    {
                        z.Top = randY.Next(80, 300) * -1;
                        z.Left = randX.Next(5, this.ClientSize.Width - z.Width);
                    }

                    if (pbxAvatar.Bounds.IntersectsWith(z.Bounds))
                    {
                        z.Top = randY.Next(80, 300) * -1;
                        z.Left = randX.Next(5, this.ClientSize.Width - z.Width);
                        score--;
                    }
                }
            }

            if (score > 10)
            {
                if (difficultylvl == 1)
                {
                    speed = 6;
                }
                else if (difficultylvl == 2)
                {
                    speed = 8;
                }
                else
                {
                    speed = 10;
                }
            }

        }


        private void stopOverlap(PictureBox y)
        {
            bool overlapping;

            do
            {
                overlapping = false;

                
                y.Top = randY.Next(80, 300) * -1;
                y.Left = randX.Next(5, this.ClientSize.Width - y.Width);

                
                foreach (Control c in this.Controls)
                {
                    if (c is PictureBox other && other != y)
                    {
                        if (y.Bounds.IntersectsWith(other.Bounds))
                        {
                            overlapping = true;
                            break;
                        }
                    }
                }

            } while (overlapping == true);
        }


        private void RestartGame()
        {
            
            score = 0;
            timeLeft = 20;
            currentDirection = "None";

            
            if (difficultylvl == 1)
                speed = 4;
            else if (difficultylvl == 2)
                speed = 6;
            else
                speed = 8;

            pbxAvatar.Left = this.ClientSize.Width / 2;

           
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "collect")
                {
                    x.Top = randY.Next(80, 300) * -1;
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

           
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && (string)z.Tag == "avoid")
                {
                    z.Top = randY.Next(80, 300) * -1;
                    z.Left = randX.Next(5, this.ClientSize.Width - z.Width);
                }
            }

            
            lblScore.Text = "Score: 0";
            lblTimer.Text = $"Time: {timeLeft}s";

           
            tmrGame.Start();
            tmrCountdown.Start();
        }


        private void pbxHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               $"You're in the middle of a game, would you like to go back to the map?",
                 "Leave Game",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information
           ); ;

            if (result == DialogResult.Yes)
            {
                Forms.frmMap map1 = new Forms.frmMap();
                map1.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {

            timeLeft--;
            lblTimer.Text = $"Time: {timeLeft}s";

            if (timeLeft <= 0)
            {
                tmrCountdown.Stop();
                tmrGame.Stop();


                DialogResult result = MessageBox.Show(
               $"Time's up! You got {score} stars. \n Would you like to retry?",
                 "Retry?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information
           ); ;

                if (result == DialogResult.Yes)
                {
                    RestartGame();
                    return;
                }
                else
                {
                    Forms.frmMap map1 = new Forms.frmMap();
                    map1.Show();
                    this.Hide();
                }

                Classes.GameClass.currentuser.Lvl3Score = score;
                Classes.GameClass.currentuser.levelsCompleted++;
                Classes.GameClass.SavePlayers();

                Forms.frmMap map = new Forms.frmMap();
                map.Show();
                this.Hide();
            }


        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;

            tmrGame.Enabled = true;

            lblTimer.Text = $"Time: {timeLeft}s";
            tmrCountdown.Start();


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "collect")
                {
                    stopOverlap((PictureBox)x);
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "collect")
                {
                    stopOverlap((PictureBox)x);
                }
            }


            pbxAvatar.Left = this.ClientSize.Width / 2;


            if (difficultylvl == 1)
            {
                speed = 4;
            }
            else if (difficultylvl == 2)
            {
                speed = 6;
            }
            else
            {
                speed = 8;
            }

            score = 0;



            tmrGame.Start();

        }

        private void frmLevel3_KeyUp(object sender, KeyEventArgs e)
        {
            currentDirection = "None";

        }
    }
}
