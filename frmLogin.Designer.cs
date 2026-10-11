
namespace QuizQuestFilmEdition.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblCreateNew = new System.Windows.Forms.Label();
            this.tbxConfirmPass = new System.Windows.Forms.TextBox();
            this.lblAvatarInfo = new System.Windows.Forms.Label();
            this.tmrEnterWait = new System.Windows.Forms.Timer(this.components);
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.pbxArrowRight = new System.Windows.Forms.PictureBox();
            this.pbxArrowLeft = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.lbErrorList = new System.Windows.Forms.ListBox();
            this.pnlErrorlist = new System.Windows.Forms.Panel();
            this.pbxClosePnl = new System.Windows.Forms.PictureBox();
            this.pbxHelp = new System.Windows.Forms.PictureBox();
            this.pbxAvSelect = new System.Windows.Forms.PictureBox();
            this.pbxEnter = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbxHidePass2 = new System.Windows.Forms.PictureBox();
            this.pbxHidePass1 = new System.Windows.Forms.PictureBox();
            this.pbxBackgroundLogin = new System.Windows.Forms.PictureBox();
            this.pbxBackgroundReg = new System.Windows.Forms.PictureBox();
            this.pbxHidePass = new System.Windows.Forms.PictureBox();
            this.pnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.pnlErrorlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClosePnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsername.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tbxUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxUsername.Location = new System.Drawing.Point(114, 161);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(235, 25);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tbxPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxPassword.Location = new System.Drawing.Point(114, 209);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(235, 25);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // lblCreateNew
            // 
            this.lblCreateNew.AutoSize = true;
            this.lblCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateNew.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblCreateNew.Location = new System.Drawing.Point(110, 367);
            this.lblCreateNew.Name = "lblCreateNew";
            this.lblCreateNew.Size = new System.Drawing.Size(248, 22);
            this.lblCreateNew.TabIndex = 4;
            this.lblCreateNew.Text = "NEW USER? REGISTER HERE.";
            this.lblCreateNew.Click += new System.EventHandler(this.lblCreateNew_Click);
            // 
            // tbxConfirmPass
            // 
            this.tbxConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.tbxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxConfirmPass.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tbxConfirmPass.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxConfirmPass.Location = new System.Drawing.Point(114, 259);
            this.tbxConfirmPass.Name = "tbxConfirmPass";
            this.tbxConfirmPass.Size = new System.Drawing.Size(235, 25);
            this.tbxConfirmPass.TabIndex = 8;
            this.tbxConfirmPass.TextChanged += new System.EventHandler(this.tbxConfirmPass_TextChanged);
            this.tbxConfirmPass.Enter += new System.EventHandler(this.tbxConfirmPass_Enter);
            this.tbxConfirmPass.Leave += new System.EventHandler(this.tbxConfirmPass_Leave);
            // 
            // lblAvatarInfo
            // 
            this.lblAvatarInfo.AutoSize = true;
            this.lblAvatarInfo.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInfo.Location = new System.Drawing.Point(149, 12);
            this.lblAvatarInfo.Name = "lblAvatarInfo";
            this.lblAvatarInfo.Size = new System.Drawing.Size(69, 22);
            this.lblAvatarInfo.TabIndex = 12;
            this.lblAvatarInfo.Text = "Avatar";
            // 
            // tmrEnterWait
            // 
            this.tmrEnterWait.Enabled = true;
            this.tmrEnterWait.Tick += new System.EventHandler(this.tmrEnterWait_Tick);
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pnlAvatar.Controls.Add(this.lblAvatarInfo);
            this.pnlAvatar.Controls.Add(this.pbxArrowRight);
            this.pnlAvatar.Controls.Add(this.pbxArrowLeft);
            this.pnlAvatar.Controls.Add(this.pbxAvatar);
            this.pnlAvatar.Location = new System.Drawing.Point(434, 102);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(350, 261);
            this.pnlAvatar.TabIndex = 15;
            this.pnlAvatar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAvatar_Paint);
            // 
            // pbxArrowRight
            // 
            this.pbxArrowRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxArrowRight.Image = global::QuizQuestFilmEdition.Properties.Resources.labelfaceright_removebg;
            this.pbxArrowRight.Location = new System.Drawing.Point(282, 119);
            this.pbxArrowRight.Name = "pbxArrowRight";
            this.pbxArrowRight.Size = new System.Drawing.Size(50, 50);
            this.pbxArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArrowRight.TabIndex = 11;
            this.pbxArrowRight.TabStop = false;
            this.pbxArrowRight.Click += new System.EventHandler(this.pbxArrowRight_Click);
            // 
            // pbxArrowLeft
            // 
            this.pbxArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxArrowLeft.Image = global::QuizQuestFilmEdition.Properties.Resources.labelfaceleft_removebg;
            this.pbxArrowLeft.Location = new System.Drawing.Point(20, 119);
            this.pbxArrowLeft.Name = "pbxArrowLeft";
            this.pbxArrowLeft.Size = new System.Drawing.Size(50, 50);
            this.pbxArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArrowLeft.TabIndex = 10;
            this.pbxArrowLeft.TabStop = false;
            this.pbxArrowLeft.Click += new System.EventHandler(this.pbxArrowLeft_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Image = global::QuizQuestFilmEdition.Properties.Resources.toad;
            this.pbxAvatar.Location = new System.Drawing.Point(76, 40);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(200, 200);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 9;
            this.pbxAvatar.TabStop = false;
            // 
            // lbErrorList
            // 
            this.lbErrorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lbErrorList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbErrorList.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbErrorList.ForeColor = System.Drawing.SystemColors.Window;
            this.lbErrorList.FormattingEnabled = true;
            this.lbErrorList.ItemHeight = 24;
            this.lbErrorList.Location = new System.Drawing.Point(12, 7);
            this.lbErrorList.Name = "lbErrorList";
            this.lbErrorList.Size = new System.Drawing.Size(394, 122);
            this.lbErrorList.TabIndex = 16;
            // 
            // pnlErrorlist
            // 
            this.pnlErrorlist.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlErrorlist.Controls.Add(this.pbxClosePnl);
            this.pnlErrorlist.Controls.Add(this.lbErrorList);
            this.pnlErrorlist.Location = new System.Drawing.Point(12, 142);
            this.pnlErrorlist.Name = "pnlErrorlist";
            this.pnlErrorlist.Size = new System.Drawing.Size(416, 201);
            this.pnlErrorlist.TabIndex = 28;
            // 
            // pbxClosePnl
            // 
            this.pbxClosePnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClosePnl.Image = global::QuizQuestFilmEdition.Properties.Resources.goback;
            this.pbxClosePnl.Location = new System.Drawing.Point(150, 135);
            this.pbxClosePnl.Name = "pbxClosePnl";
            this.pbxClosePnl.Size = new System.Drawing.Size(129, 46);
            this.pbxClosePnl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClosePnl.TabIndex = 17;
            this.pbxClosePnl.TabStop = false;
            this.pbxClosePnl.Click += new System.EventHandler(this.pbxClosePnl_Click);
            // 
            // pbxHelp
            // 
            this.pbxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHelp.Image = global::QuizQuestFilmEdition.Properties.Resources.marioquestion;
            this.pbxHelp.Location = new System.Drawing.Point(12, 12);
            this.pbxHelp.Name = "pbxHelp";
            this.pbxHelp.Size = new System.Drawing.Size(70, 70);
            this.pbxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHelp.TabIndex = 24;
            this.pbxHelp.TabStop = false;
            this.pbxHelp.Click += new System.EventHandler(this.pbxHelp_Click);
            // 
            // pbxAvSelect
            // 
            this.pbxAvSelect.Image = global::QuizQuestFilmEdition.Properties.Resources.avatar_select_lbl;
            this.pbxAvSelect.Location = new System.Drawing.Point(439, 56);
            this.pbxAvSelect.Name = "pbxAvSelect";
            this.pbxAvSelect.Size = new System.Drawing.Size(344, 37);
            this.pbxAvSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvSelect.TabIndex = 23;
            this.pbxAvSelect.TabStop = false;
            // 
            // pbxEnter
            // 
            this.pbxEnter.BackColor = System.Drawing.Color.Transparent;
            this.pbxEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEnter.Image = global::QuizQuestFilmEdition.Properties.Resources.clapperboardstill_png;
            this.pbxEnter.Location = new System.Drawing.Point(196, 289);
            this.pbxEnter.Name = "pbxEnter";
            this.pbxEnter.Size = new System.Drawing.Size(79, 75);
            this.pbxEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEnter.TabIndex = 13;
            this.pbxEnter.TabStop = false;
            this.pbxEnter.Click += new System.EventHandler(this.pbxSubtitle_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(114, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(235, 136);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pbxHidePass2
            // 
            this.pbxHidePass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHidePass2.Location = new System.Drawing.Point(797, 392);
            this.pbxHidePass2.Name = "pbxHidePass2";
            this.pbxHidePass2.Size = new System.Drawing.Size(27, 23);
            this.pbxHidePass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHidePass2.TabIndex = 30;
            this.pbxHidePass2.TabStop = false;
            this.pbxHidePass2.Click += new System.EventHandler(this.pbxHidePass2_Click_1);
            // 
            // pbxHidePass1
            // 
            this.pbxHidePass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHidePass1.Image = global::QuizQuestFilmEdition.Properties.Resources.eye2remove_fotor_bg_remover_20251120112147;
            this.pbxHidePass1.Location = new System.Drawing.Point(355, 261);
            this.pbxHidePass1.Name = "pbxHidePass1";
            this.pbxHidePass1.Size = new System.Drawing.Size(27, 23);
            this.pbxHidePass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHidePass1.TabIndex = 29;
            this.pbxHidePass1.TabStop = false;
            this.pbxHidePass1.Click += new System.EventHandler(this.pbxHidePass1_Click);
            // 
            // pbxBackgroundLogin
            // 
            this.pbxBackgroundLogin.Image = global::QuizQuestFilmEdition.Properties.Resources.blankbackgrounfull;
            this.pbxBackgroundLogin.Location = new System.Drawing.Point(0, -22);
            this.pbxBackgroundLogin.Name = "pbxBackgroundLogin";
            this.pbxBackgroundLogin.Size = new System.Drawing.Size(798, 513);
            this.pbxBackgroundLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBackgroundLogin.TabIndex = 19;
            this.pbxBackgroundLogin.TabStop = false;
            this.pbxBackgroundLogin.Click += new System.EventHandler(this.pbxBackgroundLogin_Click);
            // 
            // pbxBackgroundReg
            // 
            this.pbxBackgroundReg.BackgroundImage = global::QuizQuestFilmEdition.Properties.Resources.blankbackgrounfull;
            this.pbxBackgroundReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxBackgroundReg.Location = new System.Drawing.Point(0, -22);
            this.pbxBackgroundReg.Name = "pbxBackgroundReg";
            this.pbxBackgroundReg.Size = new System.Drawing.Size(824, 513);
            this.pbxBackgroundReg.TabIndex = 17;
            this.pbxBackgroundReg.TabStop = false;
            // 
            // pbxHidePass
            // 
            this.pbxHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHidePass.Image = global::QuizQuestFilmEdition.Properties.Resources.eye2remove_fotor_bg_remover_20251120112147;
            this.pbxHidePass.Location = new System.Drawing.Point(355, 210);
            this.pbxHidePass.Name = "pbxHidePass";
            this.pbxHidePass.Size = new System.Drawing.Size(27, 23);
            this.pbxHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHidePass.TabIndex = 31;
            this.pbxHidePass.TabStop = false;
            this.pbxHidePass.Click += new System.EventHandler(this.pbxHidePass_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(252)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(803, 491);
            this.Controls.Add(this.pnlErrorlist);
            this.Controls.Add(this.pbxHidePass);
            this.Controls.Add(this.pbxHelp);
            this.Controls.Add(this.pbxAvSelect);
            this.Controls.Add(this.lblCreateNew);
            this.Controls.Add(this.pbxEnter);
            this.Controls.Add(this.tbxConfirmPass);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.pnlAvatar);
            this.Controls.Add(this.pbxHidePass2);
            this.Controls.Add(this.pbxHidePass1);
            this.Controls.Add(this.pbxBackgroundReg);
            this.Controls.Add(this.pbxBackgroundLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.pnlAvatar.ResumeLayout(false);
            this.pnlAvatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.pnlErrorlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClosePnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblCreateNew;
        private System.Windows.Forms.TextBox tbxConfirmPass;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.PictureBox pbxArrowLeft;
        private System.Windows.Forms.PictureBox pbxArrowRight;
        private System.Windows.Forms.Label lblAvatarInfo;
        private System.Windows.Forms.PictureBox pbxEnter;
        private System.Windows.Forms.Timer tmrEnterWait;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.ListBox lbErrorList;
        private System.Windows.Forms.PictureBox pbxBackgroundReg;
        private System.Windows.Forms.PictureBox pbxBackgroundLogin;
        private System.Windows.Forms.PictureBox pbxAvSelect;
        private System.Windows.Forms.PictureBox pbxHelp;
        private System.Windows.Forms.Panel pnlErrorlist;
        private System.Windows.Forms.PictureBox pbxClosePnl;
        private System.Windows.Forms.PictureBox pbxHidePass1;
        private System.Windows.Forms.PictureBox pbxHidePass2;
        private System.Windows.Forms.PictureBox pbxHidePass;
    }
}