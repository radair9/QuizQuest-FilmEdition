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
    public partial class frmLevel2 : Form
    {
        public frmLevel2()
        {
            InitializeComponent();
        }

       
        List<Image> wonkaimagelist = new List<Image>
        {
            Properties.Resources.wonka0,
            Properties.Resources.wonka1,
            Properties.Resources.wonka2,
            Properties.Resources.wonka3,
            Properties.Resources.wonka4,
            Properties.Resources.wonka5,
            Properties.Resources.wonka6,
            Properties.Resources.wonka7,
            Properties.Resources.wonka8,
            Properties.Resources.wonka9,
            Properties.Resources.wonka10,
            Properties.Resources.wonka11,
            Properties.Resources.wonka12,
            Properties.Resources.wonka13,
            Properties.Resources.wonka14,
            Properties.Resources.wonka15,
            Properties.Resources.wonka16,
            Properties.Resources.wonka17,
            Properties.Resources.wonka18,
            Properties.Resources.wonka19,
            Properties.Resources.wonka20,
            Properties.Resources.wonka21,
            Properties.Resources.wonka22,
            Properties.Resources.wonka23,
            Properties.Resources.wonka24,
            Properties.Resources.wonka25,
            Properties.Resources.wonka26,
            Properties.Resources.wonka27,
            Properties.Resources.wonka28,
            Properties.Resources.wonka29,
        };

        List<Image> loveactuallyimagelist = new List<Image>
        {
            Properties.Resources.loveactually__2_,
            Properties.Resources.loveactually__3_,
            Properties.Resources.loveactually__4_,
            Properties.Resources.loveactually__5_,
            Properties.Resources.loveactually__6_,
            Properties.Resources.loveactually__7_,
            Properties.Resources.loveactually__8_,
            Properties.Resources.loveactually__9_1,
            Properties.Resources.loveactually__10_,
            Properties.Resources.loveactually__11_,
            Properties.Resources.loveactually__12_,
            Properties.Resources.loveactually__13_,
            Properties.Resources.loveactually__14_,
            Properties.Resources.loveactually__15_,
            Properties.Resources.loveactually__16_,
            Properties.Resources.loveactually__17_,
            Properties.Resources.loveactually__18_,
            Properties.Resources.loveactually__19_,
            Properties.Resources.loveactually__20_,
            Properties.Resources.loveactually__21_,
            Properties.Resources.loveactually__22_,
            Properties.Resources.loveactually__23_,
            Properties.Resources.loveactually__24_,
            Properties.Resources.loveactually__25_,
            Properties.Resources.loveactually__26_,
            Properties.Resources.loveactually__27_,
            Properties.Resources.loveactually__28_,
            Properties.Resources.loveactually__29_,
            Properties.Resources.loveactually__30_,
            Properties.Resources.loveactually__1_,
        };

        List<Image> bridgetjonesimagelist = new List<Image>
        {
            Properties.Resources.bridgetjones__1_,
            Properties.Resources.bridgetjones__2_,
            Properties.Resources.bridgetjones__3_,
            Properties.Resources.bridgetjones__4_,
            Properties.Resources.bridgetjones__5_,
            Properties.Resources.bridgetjones__6_,
            Properties.Resources.bridgetjones__7_,
            Properties.Resources.bridgetjones__8_,
            Properties.Resources.bridgetjones__9_,
            Properties.Resources.bridgetjones__10_,
            Properties.Resources.bridgetjones__11_,
            Properties.Resources.bridgetjones__12_,
            Properties.Resources.bridgetjones__13_,
            Properties.Resources.bridgetjones__14_,
            Properties.Resources.bridgetjones__15_,
            Properties.Resources.bridgetjones__16_,
            Properties.Resources.bridgetjones__17_,
            Properties.Resources.bridgetjones__18_,
            Properties.Resources.bridgetjones__19_,
            Properties.Resources.bridgetjones__20_,
            Properties.Resources.bridgetjones__21_,
            Properties.Resources.bridgetjones__22_,
            Properties.Resources.bridgetjones__23_,
            Properties.Resources.bridgetjones__24_,
            Properties.Resources.bridgetjones__25_,
            Properties.Resources.bridgetjones__26_,
            Properties.Resources.bridgetjones__27_,
            Properties.Resources.bridgetjones__28_,
            Properties.Resources.bridgetjones__29_,
            Properties.Resources.bridgetjones__30_,
            
        };

        int difficultylvl;
        private DateTime startTime;
        int elapsedseconds;
        int time = 0;
        int x = 0;



        public void posterView()
        {
            if (difficultylvl == 1)
            {
                pbxPoster.Image = Properties.Resources.bridgetjonesposter;
            }
            else if (difficultylvl == 2)
            {
                pbxPoster.Image = Properties.Resources.loveactuallyposter1;
            }
            else if (difficultylvl == 3)
            {
                pbxPoster.Image = Properties.Resources.wonkaposter;
            }

        }

        
        List<PictureBox> randomboxlist = new List<PictureBox>
        {

        };



        List<PictureBox> boxlist = new List<PictureBox>
        {

        };

        public void setup()
        {
            tmrCountdown.Enabled = true;
            if (difficultylvl == 1)
            {

               
                for (int x = 0; x < 30; x++)
                {
                    PictureBox box = new PictureBox();
                    box.Image = bridgetjonesimagelist[x];
                    int b = x + 1;
                    box.Tag = b.ToString();
                    randomboxlist.Add(box);
                    

                }
            }
            else if (difficultylvl == 2)
            {
                

                pictureBox1.Size = new Size(51, 64);
                pictureBox2.Size = new Size(51, 64);
                pictureBox3.Size = new Size(51, 64);
                pictureBox4.Size = new Size(51, 64);
                pictureBox5.Size = new Size(51, 64);
                pictureBox6.Size = new Size(51, 64);
                pictureBox7.Size = new Size(51, 64);
                pictureBox8.Size = new Size(51, 64);
                pictureBox9.Size = new Size(51, 64);
                pictureBox10.Size = new Size(51, 64);
                pictureBox11.Size = new Size(51, 64);
                pictureBox12.Size = new Size(51, 64);
                pictureBox13.Size = new Size(51, 64);
                pictureBox14.Size = new Size(51, 64);
                pictureBox15.Size = new Size(51, 64);
                pictureBox16.Size = new Size(51, 64);
                pictureBox17.Size = new Size(51, 64);
                pictureBox18.Size = new Size(51, 64);
                pictureBox19.Size = new Size(51, 64);
                pictureBox20.Size = new Size(51, 64);
                pictureBox21.Size = new Size(51, 64);
                pictureBox22.Size = new Size(51, 64);
                pictureBox23.Size = new Size(51, 64);
                pictureBox24.Size = new Size(51, 64);
                pictureBox25.Size = new Size(51, 64);
                pictureBox26.Size = new Size(51, 64);
                pictureBox27.Size = new Size(51, 64);
                pictureBox28.Size = new Size(51, 64);
                pictureBox29.Size = new Size(51, 64);
                pictureBox30.Size = new Size(51, 64);

                dragdrop1.Size = new Size(51, 64);
                dragdrop2.Size = new Size(51, 64);
                dragdrop3.Size = new Size(51, 64);
                dragdrop4.Size = new Size(51, 64);
                dragdrop5.Size = new Size(51, 64);
                dragdrop6.Size = new Size(51, 64);
                dragdrop7.Size = new Size(51, 64);
                dragdrop8.Size = new Size(51, 64);
                dragdrop9.Size = new Size(51, 64);
                dragdrop10.Size = new Size(51, 64);
                dragdrop11.Size = new Size(51, 64);
                dragdrop12.Size = new Size(51, 64);
                dragdrop13.Size = new Size(51, 64);
                dragdrop14.Size = new Size(51, 64);
                dragdrop15.Size = new Size(51, 64);
                dragdrop16.Size = new Size(51, 64);
                dragdrop17.Size = new Size(51, 64);
                dragdrop18.Size = new Size(51, 64);
                dragdrop19.Size = new Size(51, 64);
                dragdrop20.Size = new Size(51, 64);
                dragdrop21.Size = new Size(51, 64);
                dragdrop22.Size = new Size(51, 64);
                dragdrop23.Size = new Size(51, 64);
                dragdrop24.Size = new Size(51, 64);
                dragdrop25.Size = new Size(51, 64);
                dragdrop26.Size = new Size(51, 64);
                dragdrop27.Size = new Size(51, 64);
                dragdrop28.Size = new Size(51, 64);
                dragdrop29.Size = new Size(51, 64);
                dragdrop30.Size = new Size(51, 64);

                for (int x = 0; x < 30; x++)
                {
                    PictureBox box = new PictureBox();
                    box.Image = loveactuallyimagelist[x];
                    int b = x + 1;
                    box.Tag = b.ToString();
                    randomboxlist.Add(box);

                }
            }
            else
            {
                

                for (int x = 0; x < 30; x++)
                {
                    PictureBox box = new PictureBox();
                    box.Image = wonkaimagelist[x];
                    int b = x + 1;
                    box.Tag = b.ToString();
                    randomboxlist.Add(box);

                }
            }
           

            Random getnum = new Random();

            for (int x = 0; x < 30; x++)
            {
                int Qnumber = getnum.Next(0,randomboxlist.Count); 
                boxlist.Add(randomboxlist[Qnumber]);
                randomboxlist.RemoveAt(Qnumber);
            }
            pictureBox1.Image = boxlist[0].Image;
            pictureBox1.Tag = boxlist[0].Tag;
            pictureBox2.Image = boxlist[1].Image;
            pictureBox2.Tag = boxlist[1].Tag;
            pictureBox3.Image = boxlist[2].Image;
            pictureBox3.Tag = boxlist[2].Tag;
            pictureBox4.Image = boxlist[3].Image;
            pictureBox4.Tag = boxlist[3].Tag;
            pictureBox5.Image = boxlist[4].Image;
            pictureBox5.Tag = boxlist[4].Tag;
            pictureBox6.Image = boxlist[5].Image;
            pictureBox6.Tag = boxlist[5].Tag;
            pictureBox7.Image = boxlist[6].Image;
            pictureBox7.Tag = boxlist[6].Tag;
            pictureBox8.Image = boxlist[7].Image;
            pictureBox8.Tag = boxlist[7].Tag;
            pictureBox9.Image = boxlist[8].Image;
            pictureBox9.Tag = boxlist[8].Tag;
            pictureBox10.Image = boxlist[9].Image;
            pictureBox10.Tag = boxlist[9].Tag;
            pictureBox11.Image = boxlist[10].Image;
            pictureBox11.Tag = boxlist[10].Tag;
            pictureBox12.Image = boxlist[11].Image;
            pictureBox12.Tag = boxlist[11].Tag;
            pictureBox13.Image = boxlist[12].Image;
            pictureBox13.Tag = boxlist[12].Tag;
            pictureBox14.Image = boxlist[13].Image;
            pictureBox14.Tag = boxlist[13].Tag;
            pictureBox15.Image = boxlist[14].Image;
            pictureBox15.Tag = boxlist[14].Tag;
            pictureBox16.Image = boxlist[15].Image;
            pictureBox16.Tag = boxlist[15].Tag;
            pictureBox17.Image = boxlist[16].Image;
            pictureBox17.Tag = boxlist[16].Tag;
            pictureBox18.Image = boxlist[17].Image;
            pictureBox18.Tag = boxlist[17].Tag;
            pictureBox19.Image = boxlist[18].Image;
            pictureBox19.Tag = boxlist[18].Tag;
            pictureBox20.Image = boxlist[19].Image;
            pictureBox20.Tag = boxlist[19].Tag;
            pictureBox21.Image = boxlist[20].Image;
            pictureBox21.Tag = boxlist[20].Tag;
            pictureBox22.Image = boxlist[21].Image;
            pictureBox22.Tag = boxlist[21].Tag;
            pictureBox23.Image = boxlist[22].Image;
            pictureBox23.Tag = boxlist[22].Tag;
            pictureBox24.Image = boxlist[23].Image;
            pictureBox24.Tag = boxlist[23].Tag;
            pictureBox25.Image = boxlist[24].Image;
            pictureBox25.Tag = boxlist[24].Tag;
            pictureBox26.Image = boxlist[25].Image;
            pictureBox26.Tag = boxlist[25].Tag;
            pictureBox27.Image = boxlist[26].Image;
            pictureBox27.Tag = boxlist[26].Tag;
            pictureBox28.Image = boxlist[27].Image;
            pictureBox28.Tag = boxlist[27].Tag;
            pictureBox29.Image = boxlist[28].Image;
            pictureBox29.Tag = boxlist[28].Tag;
            pictureBox30.Image = boxlist[29].Image;
            pictureBox30.Tag = boxlist[29].Tag;
        }

        

        private void tmrPosterView_Tick(object sender, EventArgs e)
        {
            postercount++;

            if (postercount == 12)
            {
                pnlPoster.Visible = false;
                pnlJigsaw.Visible = true;
                tmrCountdown.Enabled = true;

                this.Cursor = Cursors.Default;

                tmrPosterView.Stop();
                setup();
            }

        }

        private void frmLevel2_Load(object sender, EventArgs e)
        {
            //set local var difficulty
            difficultylvl = Classes.GameClass.currentDifficulty;

            //set avatar
            pbxAvatar.Image = Classes.GameClass.GetAvatar();
            lblUsername.Text = Classes.GameClass.currentuser.Username;

            posterView();

            pnlJigsaw.Visible = false;
            pnlPoster.Visible = true;

            this.Cursor = Cursors.WaitCursor;

            tmrCountdown.Enabled = false;
            lblTimer.Text = "";
            
            dragdrop1.AllowDrop = true;
            dragdrop2.AllowDrop = true;
            dragdrop3.AllowDrop = true;
            dragdrop4.AllowDrop = true;
            dragdrop5.AllowDrop = true;
            dragdrop6.AllowDrop = true;
            dragdrop7.AllowDrop = true;
            dragdrop8.AllowDrop = true;
            dragdrop9.AllowDrop = true;
            dragdrop10.AllowDrop = true;
            dragdrop11.AllowDrop = true;
            dragdrop12.AllowDrop = true;
            dragdrop13.AllowDrop = true;
            dragdrop14.AllowDrop = true;
            dragdrop15.AllowDrop = true;
            dragdrop16.AllowDrop = true;
            dragdrop17.AllowDrop = true;
            dragdrop18.AllowDrop = true;
            dragdrop19.AllowDrop = true;
            dragdrop20.AllowDrop = true;
            dragdrop21.AllowDrop = true;
            dragdrop22.AllowDrop = true;
            dragdrop23.AllowDrop = true;
            dragdrop24.AllowDrop = true;
            dragdrop25.AllowDrop = true;
            dragdrop26.AllowDrop = true;
            dragdrop27.AllowDrop = true;
            dragdrop28.AllowDrop = true;
            dragdrop29.AllowDrop = true;
            dragdrop30.AllowDrop = true;
            
            startTime = DateTime.Now;

           

            pnlPoster.Location = new Point(403, 8);
        }

        private void picbox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var pic = (PictureBox)sender;
            pic.DoDragDrop(pic, DragDropEffects.Move);
        }
        int count = 0;
        int postercount = 0;
        private void picdrop_DragDrop(object sender, DragEventArgs e)
        {
            var target = (PictureBox)sender;
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
               
                var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
             
                if (target.Tag.ToString() == source.Tag.ToString())
                {
                    
                    count++;
                    target.Image = source.Image;
                    source.Visible= false;
                    target.Cursor = Cursors.No;

                    if (count == 1)
                    {
                        lblInstruction.Visible = false;
                    }


                    if(count == 30)
                    {
                        tmrCountdown.Stop();
                        TimeSpan t = TimeSpan.FromSeconds(elapsedseconds);


                        MessageBox.Show(
                        $"You won! You completed the jigsaw in {elapsedseconds}s \n Return to Map to complete Level 3 next.",
                        "Congratulations!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        Forms.frmMap map = new Forms.frmMap();
                        map.Show();
                        this.Hide();


                        Classes.GameClass.currentuser.Lvl2TimeTaken = elapsedseconds;
                        Classes.GameClass.currentuser.levelsCompleted++;
                        Classes.GameClass.currentuser.Level3Unlocked = true;
                        Classes.GameClass.SavePlayers();

                    }
                }
                else
                {
                    MessageBox.Show("Try again.");
                }
            }
        }
        private void pictureBox59_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedseconds++;
            lblTimer.Text = (elapsedseconds).ToString() + " " + "seconds gone";
        }

        private void pbxHelp_Click(object sender, EventArgs e)
        {
            frmHelp move = new frmHelp(5);
            move.ShowDialog();

            lblInstruction.Visible = true;
            if (count == 1)
            {
                lblInstruction.Visible = true;
            }
        }

        

        private void pnlPoster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            
                if (time == 120)
                {
                    tmrLoading.Stop();
                }
                else
                {
                    time++;
                    x = x + 10;
                    pbxMenuBar.Size = new Size(x, 129);
                }
            
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

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
    }
}
