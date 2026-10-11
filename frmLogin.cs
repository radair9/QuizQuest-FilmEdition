using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuizQuestFilmEdition.Forms
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        int avatar = 1;
        int code = 1;
        string[] userdetails;
        bool reg = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblAvatarInfo.Text = "Toad";

            tbxUsername.Text = "Username";
            tbxPassword.Text = "Password";
            tbxConfirmPass.Text = "Confirm Password";
            tbxUsername.ForeColor = Color.Gray;
            tbxPassword.ForeColor = Color.Gray;
            tbxConfirmPass.ForeColor = Color.Gray;

            this.Size = new Size(486, 511);
            ResizeForm();
            tmrEnterWait.Stop();
            pnlAvatar.Visible = false;
            pnlErrorlist.Visible = false;
            pbxBackgroundReg.Visible = false;
            pbxAvSelect.Visible = false;
            tbxConfirmPass.Visible = false;
            pbxEnter.Location = new Point(190, 255);
            pbxHidePass1.Visible = false;

         if (reg == false)
            {
                userdetails = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "UserDetails.txt");
                for (int a = 0; a < userdetails.Length; a++)
                {
                    string[] details = userdetails[a].Split(',');

                        Classes.Players temp1 = new Classes.Players(
                        details[0],                           // username
                        details[1],                           // password
                        Convert.ToInt32(details[2]),          // avatarNum
                        Convert.ToInt32(details[3]),          // levelsCompleted
                        
                        Convert.ToBoolean(details[4]),        // level1Unlocked
                        Convert.ToBoolean(details[5]),        // level2Unlocked
                        Convert.ToBoolean(details[6]),        // level3Unlocked

                        Convert.ToInt32(details[7]),          // lvl1QuestionsAns
                        Convert.ToInt32(details[8]),          // lvl2TimeTaken
                        Convert.ToInt32(details[9]));         // lvl3Score



                    Classes.GameClass.allusers.Add(temp1);

                }
            }
           
        }


        private void lblCreateNew_Click(object sender, EventArgs e)
        {
            if (reg == true)
            {
                code = 1;
                reg = false;
                lblCreateNew.Text = ("NEW USER? REGISTER HERE.");
                this.Size = new Size(486, 511);

                this.Text = "Login";
                this.Update();

                ResizeForm();

                pnlAvatar.Visible = false;
                pnlErrorlist.Visible = false;
                pbxBackgroundReg.Visible = false;
                pbxAvSelect.Visible = false;
                tbxConfirmPass.Visible = false;
                pbxBackgroundLogin.Visible = true;
                lblCreateNew.Location = new Point(102, 331);
                pbxEnter.Location = new Point(195, 255);
                pbxHidePass1.Visible = false;
            }
            else
            {
                code = 2;
                reg = true;
                this.Size = new Size(819, 530);

                this.Text = "Register";
                this.Update();

                ResizeForm();

                pnlAvatar.Visible = true;
                lblCreateNew.Text = ("RETURNING USER? CLICK HERE TO LOGIN.");
                pbxBackgroundReg.Visible = true;
                pbxBackgroundLogin.Visible = false;
                pbxAvSelect.Visible = true;
                tbxConfirmPass.Visible = true;
                lblCreateNew.Location = new Point(60, 380);
                pbxEnter.Location = new Point(190, 300);
                pbxHidePass1.Visible = true;


            } 

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
          
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        int count = 0;
        bool playgif = false;
        bool unique = true;

        private void pbxSubtitle_Click(object sender, EventArgs e)
        {
            lbErrorList.Items.Clear();
            

            if (reg == true)
            {
                Classes.Players objplayer = new Classes.Players(tbxUsername.Text, tbxPassword.Text, avatar, 0, false, false, false, 0, 0, 0);
                
                objplayer.Validate(tbxConfirmPass.Text, Classes.GameClass.allusers);

                
                if (objplayer.errorlist.Count > 0)
                {
                    lbErrorList.Items.Clear();
                    pnlErrorlist.Visible = true;

                    foreach (string x in objplayer.errorlist)
                        lbErrorList.Items.Add(x);

                    return;
                }

               
                Classes.GameClass.allusers.Add(objplayer);
                Classes.GameClass.currentuser = objplayer;
                Classes.GameClass.SavePlayers();
                Classes.GameClass.currentuser.avatarNum = avatar;
                MessageBox.Show("New user created successfully!");


                lbErrorList.Items.Clear();
                
                Forms.frmMap map = new Forms.frmMap();
                map.Show();
                this.Hide();

            }
            else
            {
                string username = tbxUsername.Text.Trim();
                string password = tbxPassword.Text.Trim();

                string[] lines = File.ReadAllLines("UserDetails.txt");

                bool found = false;
                for (int x = 0; x <lines.Length ; x++)
                {
                    string[] thing = lines[x].Split(',');
                    string fileusername = thing[0].Trim();
                    string filepassword = thing[1].Trim();

                    if (username == fileusername && password == filepassword)
                    {
                        found = true;
                        Classes.GameClass.currentuser = Classes.GameClass.allusers[x]; 
                        Forms.frmMap map = new Forms.frmMap(); 
                        map.Show(); 
                        this.Hide(); 
                        break; 

                    }
          
                }
                if (!found == true)
                    {
                        pnlErrorlist.Visible = true;
                        lbErrorList.Items.Add("Your username or password is incorrect.");
                    }

            }

            playgif = true;
            tmrEnterWait.Start();

            if (playgif == true)
            {
               
                Bitmap b = new Bitmap(Properties.Resources.clapperboardgif);
                pbxEnter.Image = b;

            }  
            
        }

        private void ResizeForm()
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            this.Top = (area.Height - this.Height) / 2;
            this.Left = (area.Width - this.Width) / 2;
        }


        private void tmrEnterWait_Tick(object sender, EventArgs e)
        {
           

           
        }

        bool image = true;
        
        private void pbxAudioCont_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbxArrowRight_Click(object sender, EventArgs e)
        {
            avatar++;
            if (avatar == 4)
            {
                avatar = 1;
            }

            switch (avatar)
            {
                case 1:
                    pbxAvatar.Image = Properties.Resources.toad;
                    lblAvatarInfo.Text = "Toad";
                break;
                case 2:
                    pbxAvatar.Image = Properties.Resources.goomba;
                    lblAvatarInfo.Text = "Goomba";
                    break;
                case 3:
                    pbxAvatar.Image = Properties.Resources.yoshi;
                    lblAvatarInfo.Text = "Yoshi";
                    break;
                default:
                    pbxAvatar.Image = Properties.Resources.toad;
                    lblAvatarInfo.Text = "Toad";
                    break;

            }
               
        }

        private void pbxArrowLeft_Click(object sender, EventArgs e)
        {
            avatar--;

            if (avatar == 0)
            {
                avatar = 3;
            }

            switch (avatar)
            {
                case 1:
                    pbxAvatar.Image = Properties.Resources.toad;
                    lblAvatarInfo.Text = "Toad";
                    break;
                case 2:
                    pbxAvatar.Image = Properties.Resources.goomba;
                    lblAvatarInfo.Text = "Goomba";
                    break;
                case 3:
                    pbxAvatar.Image = Properties.Resources.yoshi;
                    lblAvatarInfo.Text = "Yoshi";
                    break;
                default:
                    pbxAvatar.Image = Properties.Resources.toad;
                    lblAvatarInfo.Text = "Toad";
                    break;

            }
        }

       

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlAvatar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbxBackgroundLogin_Click(object sender, EventArgs e)
        {

        }

        bool clicked = true;
        bool clicked2 = true;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicked2 == true)
            {
                tbxConfirmPass.UseSystemPasswordChar = false;
                clicked2 = false;
            }
            else
            {
                tbxConfirmPass.UseSystemPasswordChar = true;
                clicked2 = true;
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "Username")
            {
                tbxUsername.Text = "";
            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxUsername.Text))
            {
                tbxUsername.Text = "Username";
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Password")
            {
                tbxPassword.UseSystemPasswordChar = true;
                tbxPassword.Text = "";
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                tbxPassword.UseSystemPasswordChar = false;
                tbxPassword.Text = "Password";
            }
        }

        private void tbxConfirmPass_Enter(object sender, EventArgs e)
        {
            if (tbxConfirmPass.Text == "Confirm Password")
            { 
            tbxConfirmPass.UseSystemPasswordChar = true;
            tbxConfirmPass.Text = "";
            }
        }

        private void tbxConfirmPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxConfirmPass.Text))
            {
                tbxConfirmPass.UseSystemPasswordChar = false;
                tbxConfirmPass.Text = "Confirm Password";
            }
        }

        

        private void pbxHelp_Click(object sender, EventArgs e)
        {
            frmHelp move = new frmHelp(code);
            move.ShowDialog();
        }

        private void pbxGoBack_Click(object sender, EventArgs e)
        {

        }

        private void pbxConfirm_Click(object sender, EventArgs e)
        {
            Forms.frmMap map = new Forms.frmMap();
            map.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void lblUsernamePnl_Click(object sender, EventArgs e)
        {
            
        }

        private void pbxClosePnl_Click(object sender, EventArgs e)
        {
            pnlErrorlist.Visible = false;
        }

        private void pbxHidePass1_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                tbxConfirmPass.UseSystemPasswordChar = false;
                clicked = false;
                pbxHidePass1.Image = Properties.Resources.eye1remove_fotor_bg_remover_20251120112119;

            }
            else
            {
                tbxConfirmPass.UseSystemPasswordChar = true;
                clicked = true;
                pbxHidePass1.Image = Properties.Resources.eye2remove_fotor_bg_remover_20251120112147;
            }
        }

        private void pbxHidePass2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pbxSubtitle_Click(pbxEnter, EventArgs.Empty);
                e.Handled = true;
            }
        }

        private void pbxHidePass_Click(object sender, EventArgs e)
        {
            if (clicked2 == true)
            {
                tbxPassword.UseSystemPasswordChar = false;
                clicked2 = false;           
                pbxHidePass.Image = Properties.Resources.eye1remove_fotor_bg_remover_20251120112119;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
                clicked2 = true;
                pbxHidePass.Image = Properties.Resources.eye2remove_fotor_bg_remover_20251120112147;
            }
        }
    }
}

