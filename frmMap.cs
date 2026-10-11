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
    public partial class frmMap : Form
    {
        public frmMap()
        {
            InitializeComponent();
        }

        int mapselected = 1;

        private void frmMap_Shown(object sender, EventArgs e)
        {
            updateColours();
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            //set avatar
            pbxAvatar.Image = Classes.GameClass.GetAvatar();

            lblUsername.Text = Classes.GameClass.currentuser.Username;

            pnlLevelDesc.Hide();
            pnlLevelDesc.Location = new Point(107, 33);

            // Difficulty text
            if (Classes.GameClass.currentDifficulty == 1)
            {
                lblDesc.Text = "easy lvl1";
            }         
            else if (Classes.GameClass.currentDifficulty == 2)
            {
                lblDesc.Text = "normal lvl1";
            }
            else if (Classes.GameClass.currentDifficulty == 3)
            {
                lblDesc.Text = "hard lvl1";
            }

            Classes.GameClass.SavePlayers();

            if (Classes.GameClass.currentuser.levelsCompleted >= 2)
            {
                btnAdmin.Visible = true;
                btnLeaderboard.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
                btnLeaderboard.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Classes.GameClass.currentDifficulty = 1;
            lblDifficulty.Text = "You've selected EASY difficulty.";
            btnContinue.Enabled = true;

        }

        private void pbxNormal_Click(object sender, EventArgs e)
        {
            Classes.GameClass.currentDifficulty = 2;
            lblDifficulty.Text = "You've selected NORMAL difficulty.";
            btnContinue.Enabled = true;

        }

        private void pbxHard_Click(object sender, EventArgs e)
        {
            Classes.GameClass.currentDifficulty = 3;
            lblDifficulty.Text = "You've selected HARD difficulty.";
            btnContinue.Enabled = true;
        }

        private void pbxLevel1_Click(object sender, EventArgs e)
        {
            if (Classes.GameClass.currentuser.levelsCompleted == 1)
            {
                MessageBox.Show(
                    "Level 1 is completed. Complete Level 2 next.",
                    "Reminder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel1.Cursor = Cursors.No;
                return;
            }
            if (Classes.GameClass.currentuser.levelsCompleted == 2)
            {
                MessageBox.Show(
                    "Level 1 is completed. Complete Level 3 next.",
                    "Reminder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel1.Cursor = Cursors.No;
                return;
            }
            if (Classes.GameClass.currentuser.levelsCompleted == 3)
            {
                MessageBox.Show(
                    "Level 1 is completed. Explore the admin form, or check where you placed in the leaderboard.",
                    "Congratulations!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel1.Cursor = Cursors.No;
                return;
            }

            pnlLevelDesc.Show();
                mapselected = 1;
                lblDesc.Text = "This is Level 1. To complete this level, you must answer the \n movie questions correctly to damage your opponent, if you \n answer incorrectly, you opponent will attack. Kill your \n opponent by answering the questions correctly to move on \n to Level 2.";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmHelp move = new frmHelp(3);
            move.ShowDialog();
        }

        private void pnlLevelDesc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbxLevel2_Click(object sender, EventArgs e)
        {
            if (Classes.GameClass.currentuser.levelsCompleted == 0)
            {
                MessageBox.Show(
                    "Level 2 is locked. Complete Level 1 first.",
                    "Slow down!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel2.Cursor = Cursors.No;
                return;
            }

            if (Classes.GameClass.currentuser.levelsCompleted == 2)
            {
                MessageBox.Show(
                    "Level 2 is completed. Complete Level 3 next.",
                    "Reminder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel2.Cursor = Cursors.No;
                return;
            }

            if (Classes.GameClass.currentuser.levelsCompleted == 3)
            {
                MessageBox.Show(
                    "Level 2 is completed. Explore the admin form, or check where you placed in the leaderboard.",
                    "Congratulations!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel2.Cursor = Cursors.No;
                return;
            }

            mapselected = 2;
            pnlLevelDesc.Show();
            lblDesc.Text = "This is Level 2. To complete this level, you must complete your \n selected puzzle.  You can drag the pieces from the left \n of the level onto the correct place, complete this \n to move on to Level 3.";
        }

        private void pbxLevel3_Click(object sender, EventArgs e)
        {
            if (Classes.GameClass.currentuser.levelsCompleted == 0)
            {
                MessageBox.Show(
                    "Level 3 is locked. Complete Level 1 and 2 first.",
                    "Slow down!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel3.Cursor = Cursors.No;
                return;
            }
            else if (Classes.GameClass.currentuser.levelsCompleted == 1)
            {
                MessageBox.Show(
                    "Level 3 is locked. Complete Level 2 first.",
                    "Slow down!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbxLevel3.Cursor = Cursors.No;
                return;
            }

            if (Classes.GameClass.currentuser.levelsCompleted == 3)
            {
                MessageBox.Show(
                    "Level 3 is completed. Explore the admin form, or check where you placed in the leaderboard.",
                    "Congratulations!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                pbxLevel3.Cursor = Cursors.No;
                return;
            }

            mapselected = 3;
            pnlLevelDesc.Show();
            lblDesc.Text = "This is Level 3. To complete this level and win \n the game, you must use the arrow keys to collect \n the falling stars and avoid the falling clapperboards. \n You only have 20 seconds. Speed will increase after 10 stars  \n have been collected.";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlLevelDesc.Visible = false;
            Classes.GameClass.currentDifficulty = 1;
            lblDifficulty.Text = "You haven't selected a difficulty yet.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lblDifficulty.Text == "You haven't selected a difficulty yet.")
            {
                MessageBox.Show("Please select a difficulty to proceed.");
            }
            else
            {
                if (mapselected == 1)
                {                
                    Forms.frmLevel1 level1 = new Forms.frmLevel1();
                    level1.Show();
                    this.Hide();
                }
                else if (mapselected == 2)
                {               
                        Forms.frmLevel2 level2 = new Forms.frmLevel2();
                        level2.Show();
                        this.Hide();        
                }
                else
                {
                    Forms.frmLevel3 level3 = new Forms.frmLevel3();
                    level3.Show();
                    this.Hide();
                }
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               $"Are you sure you want to log out, {Classes.GameClass.currentuser.Username}?",
                 "Confirm Log Out",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );;

            if (result == DialogResult.Yes)
            {
                Forms.frmLogin login = new Forms.frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                return;
            }           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Forms.frmAdmin admin = new Forms.frmAdmin();
            admin.Show();
            this.Hide();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            Forms.frmLeaderboard leaderboard = new Forms.frmLeaderboard();
            leaderboard.Show();
            this.Hide();
        }

        

        private void updateColours()
        {
            int unlockedLevel = 0;

            if (Classes.GameClass.currentuser.Level1Unlocked == true)
            {
                unlockedLevel = 0;
            }
            if (Classes.GameClass.currentuser.Level2Unlocked == true)
            {
                unlockedLevel = 1;
            }
            if (Classes.GameClass.currentuser.Level3Unlocked == true)
            {
                unlockedLevel = 2;
            }
            if (Classes.GameClass.currentuser.levelsCompleted == 3)
            {
                unlockedLevel = 3;
            }
                

            switch (unlockedLevel)
            {
                case 0:
                    pbxAvatar.Location = new Point(140, 109);
                    pbxLevel1.BackColor = Color.White;
                    pbxLevel2.BackColor = Color.DimGray;
                    pbxLevel3.BackColor = Color.DimGray;
                    break;

                case 1:
                    pbxAvatar.Location = new Point(220, 245); 
                    pbxLevel1.BackColor = Color.DimGray;
                    pbxLevel2.BackColor = Color.White;
                    pbxLevel3.BackColor = Color.DimGray;
                    break;

                case 2:
                    pbxAvatar.Location = new Point(500, 352);
                    pbxLevel1.BackColor = Color.DimGray;
                    pbxLevel2.BackColor = Color.DimGray;
                    pbxLevel3.BackColor = Color.White;
                    break;
                case 3:
                    pbxAvatar.Location = new Point(600, 276);
                    pbxLevel1.BackColor = Color.DimGray;
                    pbxLevel2.BackColor = Color.DimGray;
                    pbxLevel3.BackColor = Color.DimGray;
                    break;

                default:
                    pbxAvatar.Location = new Point(600, 276);
                    pbxLevel1.BackColor = Color.DimGray;
                    pbxLevel2.BackColor = Color.DimGray;
                    pbxLevel3.BackColor = Color.DimGray;
                    break;
            }
        }




    }
}
