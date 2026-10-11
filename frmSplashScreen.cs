using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Media;

namespace QuizQuestFilmEdition.Forms
{
    public partial class frmSplashScreen : Form
    {
        private SoundPlayer _soundPlayer;

        int x = 239;
        int y = -200;
        int xlak = 49;
        int ylak = -143;
        int xsub = 31;
        int ysub = 13;


        public bool screen = false;

        public frmSplashScreen()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("smb_bump.wav");
            mxpTheme.URL = @"smb_theme.wav";
            mxpTheme.settings.playCount = 5;

            if (screen == true)
            {
                mxpTheme.Ctlcontrols.stop();
            }

            
            mxpTheme.Visible = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            tmrLabel.Interval = 1;
            tmrLakitu.Interval = 1;
            tmrSubtitle.Interval = 1;
            lblTitle.Hide();
            pbxLakitu.Show();
        }

        double count = 0;
        private void tmr_Tick(object sender, EventArgs e)
        {
                if (count <= 8)
                {
                    count++;

                    switch (count)
                    {
                        case 1:
                        case 4:
                        case 7:
                            this.Text = "Loading.";
                            break;

                        case 2:
                        case 5:
                        case 8:
                            this.Text = "Loading..";
                            break;

                        case 3:
                        case 6:
                            this.Text = "Loading...";
                            break;
                    }
                }
            else
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
                tmr.Stop();
            }

        }

        private void pbxSplash_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pbxLogo.SetBounds(x, y, pbxLogo.Width, pbxLogo.Height);
            y++;
            if (y == 19)
            {
                _soundPlayer.Play();
                y = 1;
                tmrLabel.Stop();

            }
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void tmrLakitu_Tick(object sender, EventArgs e)
        {
            pbxLakitu.SetBounds(xlak, ylak, pbxLakitu.Width, pbxLakitu.Height);
            ylak++;
            if (ylak == 29)
            {
                ylak = 1;
                tmrLakitu.Stop();
            }
        }

        private void tmrSubtitle_Tick(object sender, EventArgs e)
        {
            pbxSubtitle.SetBounds(xsub, ysub, pbxSubtitle.Width, pbxSubtitle.Height);
            ysub++;
            if (ysub == 167)
            {
                ysub = 1;
                tmrSubtitle.Stop();
            }
        }

        private void mxpTheme_Enter(object sender, EventArgs e)
        {

        }

        private void pbxLakitu_Click(object sender, EventArgs e)
        {

        }
    }
}
