using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace QuizQuestFilmEdition.Forms
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        int num1;

        public frmHelp(int num)
        {
            InitializeComponent();
            num1 = num;
        }

        private string ResourceTemp(byte[] data, string fileName)
        {
            string tempFolder = Path.Combine(Path.GetTempPath(), "MyHelpVideos");
            Directory.CreateDirectory(tempFolder);

            string fullPath = Path.Combine(tempFolder, fileName);

            File.WriteAllBytes(fullPath, data);
            return fullPath;
        }
        
        private void frmHelp_Load(object sender, EventArgs e)
        {
            byte[] videoBytes = null;
            string fileName = null;
            pnlWrittenHelp.Visible = false;
            pnlWrittenHelp.Location = new Point(105, 12);
            

            switch (num1)
            {
                case 1: //login
                    this.Text = "Login Help";
                    this.Update();
                    videoBytes = Properties.Resources.frmLoginAEdit;
                    fileName = "frmLoginAEdit.mp4";
                lblDesc.Text = "This is the login page, log in with your username \n and password to proceed onto the map selection screen. \n You can show/hide your password with the eye icon. \n Click on the 'REGISTER HERE' text to register and click \n the movie clapper icon or press Enter to log in.";
                break;

                case 2: //reg
                    this.Text = "Register Help";
                    this.Update();
                    videoBytes = Properties.Resources.frmLoginBEdit;
                    fileName = "frmLoginBEdit.mp4";
                    lblDesc.Text = "This is the registration page, create a new account by \n entering a unique username and password. You can \n select an avatar by using the arrows on the right of the form. \n You can show/hide you password with the eye icon. \n Click on the 'LOG IN' text to return to the login page once your \n account has been successfully created and click the movie clapper icon \n or press Enter to log in.";
                break;

                case 3: //map
                    this.Text = "Map Help";
                    this.Update();
                    videoBytes = Properties.Resources.frmMapEdit;
                    fileName = "frmMapEdit.mp4";
                    lblDesc.Text = "This is the map page, play a level by selecting on of \n the numbered buttons. Make sure you select a \n difficulty to proceed to the level, and then press continue.";
                break;

                case 4: //lvl 1
                    this.Text = "Level 1 Help";
                    this.Update();
                    videoBytes = Properties.Resources.frmLevel1Edit;
                    fileName = "frmLevel1                                                                                                                                                                          Edit.mp4";
                    lblDesc.Text = "Welcome to Level 1, to complete this level, you must \n click the 'NEW QUESTION' button in the bottom right \n and then select the correct answer on the popup.";
                    break;

                case 5: //lvl 2
                    this.Text = "Level 2 Help";
                    this.Update();
                    lblDesc.Text = "Welcome to Level 2, to complete this level, you must \n complete the puzzle. To do this you have to drag the \n pieces from the left of the screen and correctly \n place them onto the grid.";
                    break;

                case 6: //lvl 3
                    this.Text = "Level 3 Help";
                    this.Update();
                    lblDesc.Text = "Welcome to Level 3, to complete this level and win \n the game, you must use the arrow keys to collect \n the falling stars and avoid the falling clapperboards. \n You only have 20 seconds.Speed will increase after 10 stars  \n have been collected.";
                    break;
                case 7: //leaderboard
                    this.Text = "Leaderboard Help";
                    this.Update();
                    lblDesc.Text = "This is the leaderboard, here you can view the \n top players for each level by clicking on the buttons.";
                    break;
                case 8: //admin
                    this.Text = "Admin Help";
                    this.Update();
                    lblDesc.Text = "This is the admin page, here you can delete users by selecting \n them from the list box, and then clicking 'CONTINUE'.";
                    break;
            }
            if (videoBytes == null) return;

            string path = ResourceTemp(videoBytes, fileName);

            MXPVideo.URL = path;
            
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MXPVideo.Ctlcontrols.pause();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnClosePnl_Click(object sender, EventArgs e)
        {
            pnlWrittenHelp.Visible = false;
        }

        private void btnWrittenHelp_Click_1(object sender, EventArgs e)
        {
            pnlWrittenHelp.Visible = true;
            lblDesc.Visible = true;
            lblTitle.Text = "Written Help";
            MXPVideo.Visible = false;
        }

        private void btnVideoHelp_Click_1(object sender, EventArgs e)
        {
            pnlWrittenHelp.Visible = true;
            MXPVideo.Visible = true;
            lblTitle.Text = "Video Help";
            lblDesc.Visible = false;
            MXPVideo.Ctlcontrols.play();
        }
    }
}
