using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizQuestFilmEdition
{
    public partial class frmTest : Form
    {
        Image player;
        List<string> playerMovements = new List<string>();
        int steps = 0;
        int slowDownFrameRate = 0;
        bool goLeft, goRight, goUp, goDown;
        int playerX;
        int playerY;
        int playerHeight = 100;
        int playerWidth = 100;
        int playerSpeed = 10;

        public frmTest()
        {
            InitializeComponent();
            SetUp();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(player, playerX, playerY, playerWidth, playerHeight);
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        } 

        private void SetUp()
        {
            //this.BackgroundImage = Image.FromFile("bg.jpg");
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;

            // load the player files to the list
            // playerMovements = Directory.GetFiles("player", "*.png").ToList();
           // player = Image.FromFile(playerMovements[0]);

        }

        private void AnimatePlayer(int start, int end)
        {


        }


    }
}
