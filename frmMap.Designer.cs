
namespace QuizQuestFilmEdition.Forms
{
    partial class frmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.pbxLevel1 = new System.Windows.Forms.PictureBox();
            this.pbxLevel2 = new System.Windows.Forms.PictureBox();
            this.pbxLevel3 = new System.Windows.Forms.PictureBox();
            this.pnlLevelDesc = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnClosePnl = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.pbxHard = new System.Windows.Forms.PictureBox();
            this.pbxNormal = new System.Windows.Forms.PictureBox();
            this.pbxEasy = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pbxPnlBar = new System.Windows.Forms.PictureBox();
            this.pbxHelp = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLevel3)).BeginInit();
            this.pnlLevelDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPnlBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLevel1
            // 
            this.pbxLevel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLevel1.Image = global::QuizQuestFilmEdition.Properties.Resources._1;
            this.pbxLevel1.Location = new System.Drawing.Point(140, 33);
            this.pbxLevel1.Name = "pbxLevel1";
            this.pbxLevel1.Size = new System.Drawing.Size(70, 70);
            this.pbxLevel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLevel1.TabIndex = 0;
            this.pbxLevel1.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxLevel1, "Level 1");
            this.pbxLevel1.Click += new System.EventHandler(this.pbxLevel1_Click);
            // 
            // pbxLevel2
            // 
            this.pbxLevel2.BackColor = System.Drawing.Color.DimGray;
            this.pbxLevel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLevel2.Image = global::QuizQuestFilmEdition.Properties.Resources._2;
            this.pbxLevel2.Location = new System.Drawing.Point(307, 245);
            this.pbxLevel2.Name = "pbxLevel2";
            this.pbxLevel2.Size = new System.Drawing.Size(70, 70);
            this.pbxLevel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLevel2.TabIndex = 1;
            this.pbxLevel2.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxLevel2, "Level 2");
            this.pbxLevel2.Click += new System.EventHandler(this.pbxLevel2_Click);
            // 
            // pbxLevel3
            // 
            this.pbxLevel3.BackColor = System.Drawing.Color.DimGray;
            this.pbxLevel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLevel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLevel3.Image = global::QuizQuestFilmEdition.Properties.Resources._3;
            this.pbxLevel3.Location = new System.Drawing.Point(585, 352);
            this.pbxLevel3.Name = "pbxLevel3";
            this.pbxLevel3.Size = new System.Drawing.Size(70, 70);
            this.pbxLevel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLevel3.TabIndex = 2;
            this.pbxLevel3.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxLevel3, "Level 3");
            this.pbxLevel3.Click += new System.EventHandler(this.pbxLevel3_Click);
            // 
            // pnlLevelDesc
            // 
            this.pnlLevelDesc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlLevelDesc.Controls.Add(this.lblDesc);
            this.pnlLevelDesc.Controls.Add(this.btnClosePnl);
            this.pnlLevelDesc.Controls.Add(this.lblDifficulty);
            this.pnlLevelDesc.Controls.Add(this.pbxHard);
            this.pnlLevelDesc.Controls.Add(this.pbxNormal);
            this.pnlLevelDesc.Controls.Add(this.pbxEasy);
            this.pnlLevelDesc.Controls.Add(this.lblTitle);
            this.pnlLevelDesc.Controls.Add(this.btnContinue);
            this.pnlLevelDesc.Controls.Add(this.pbxPnlBar);
            this.pnlLevelDesc.Location = new System.Drawing.Point(124, 419);
            this.pnlLevelDesc.Name = "pnlLevelDesc";
            this.pnlLevelDesc.Size = new System.Drawing.Size(537, 410);
            this.pnlLevelDesc.TabIndex = 3;
            this.pnlLevelDesc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLevelDesc_Paint);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDesc.Location = new System.Drawing.Point(12, 62);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(449, 68);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Click Easy, Normal or Hard to generate a new question.\r\nAnswer 5 correct and you " +
    "win, however if \r\nyou answer 5 incorrect or run out of time.. you lose.";
            this.lblDesc.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnClosePnl
            // 
            this.btnClosePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.btnClosePnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePnl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePnl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClosePnl.Location = new System.Drawing.Point(163, 344);
            this.btnClosePnl.Name = "btnClosePnl";
            this.btnClosePnl.Size = new System.Drawing.Size(92, 43);
            this.btnClosePnl.TabIndex = 7;
            this.btnClosePnl.Text = "Close";
            this.btnClosePnl.UseVisualStyleBackColor = false;
            this.btnClosePnl.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblDifficulty.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDifficulty.Location = new System.Drawing.Point(134, 309);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(295, 22);
            this.lblDifficulty.TabIndex = 6;
            this.lblDifficulty.Text = "You haven\'t selected a difficulty yet.";
            // 
            // pbxHard
            // 
            this.pbxHard.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxHard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHard.Image = global::QuizQuestFilmEdition.Properties.Resources.Hard;
            this.pbxHard.Location = new System.Drawing.Point(327, 235);
            this.pbxHard.Name = "pbxHard";
            this.pbxHard.Size = new System.Drawing.Size(73, 61);
            this.pbxHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHard.TabIndex = 5;
            this.pbxHard.TabStop = false;
            this.pbxHard.Click += new System.EventHandler(this.pbxHard_Click);
            // 
            // pbxNormal
            // 
            this.pbxNormal.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxNormal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxNormal.Image = global::QuizQuestFilmEdition.Properties.Resources.Normal;
            this.pbxNormal.Location = new System.Drawing.Point(229, 235);
            this.pbxNormal.Name = "pbxNormal";
            this.pbxNormal.Size = new System.Drawing.Size(92, 61);
            this.pbxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNormal.TabIndex = 4;
            this.pbxNormal.TabStop = false;
            this.pbxNormal.Click += new System.EventHandler(this.pbxNormal_Click);
            // 
            // pbxEasy
            // 
            this.pbxEasy.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxEasy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEasy.Image = global::QuizQuestFilmEdition.Properties.Resources.Easy;
            this.pbxEasy.Location = new System.Drawing.Point(150, 235);
            this.pbxEasy.Name = "pbxEasy";
            this.pbxEasy.Size = new System.Drawing.Size(73, 61);
            this.pbxEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEasy.TabIndex = 3;
            this.pbxEasy.TabStop = false;
            this.pbxEasy.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(213, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "How to play...";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnContinue.Location = new System.Drawing.Point(291, 344);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(109, 44);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxPnlBar
            // 
            this.pbxPnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.pbxPnlBar.Location = new System.Drawing.Point(0, -1);
            this.pbxPnlBar.Name = "pbxPnlBar";
            this.pbxPnlBar.Size = new System.Drawing.Size(537, 43);
            this.pbxPnlBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPnlBar.TabIndex = 16;
            this.pbxPnlBar.TabStop = false;
            // 
            // pbxHelp
            // 
            this.pbxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHelp.Image = global::QuizQuestFilmEdition.Properties.Resources.marioquestion;
            this.pbxHelp.Location = new System.Drawing.Point(12, 12);
            this.pbxHelp.Name = "pbxHelp";
            this.pbxHelp.Size = new System.Drawing.Size(78, 74);
            this.pbxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHelp.TabIndex = 4;
            this.pbxHelp.TabStop = false;
            this.pbxHelp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbxAvatar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbxAvatar.Image = global::QuizQuestFilmEdition.Properties.Resources.toad;
            this.pbxAvatar.Location = new System.Drawing.Point(140, 109);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(70, 70);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 5;
            this.pbxAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsername.Location = new System.Drawing.Point(8, 89);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 22);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::QuizQuestFilmEdition.Properties.Resources.quizquestlogo_removebg;
            this.pbxLogo.Location = new System.Drawing.Point(-3, 376);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(121, 98);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnLogOut.Location = new System.Drawing.Point(693, 430);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(79, 34);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAdmin.Location = new System.Drawing.Point(693, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(79, 34);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaderboard.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnLeaderboard.Location = new System.Drawing.Point(693, 52);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(79, 34);
            this.btnLeaderboard.TabIndex = 10;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizQuestFilmEdition.Properties.Resources.map2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbxHelp);
            this.Controls.Add(this.pnlLevelDesc);
            this.Controls.Add(this.pbxLevel3);
            this.Controls.Add(this.pbxLevel2);
            this.Controls.Add(this.pbxLevel1);
            this.Controls.Add(this.pbxAvatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.frmMap_Load);
            this.Shown += new System.EventHandler(this.frmMap_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLevel3)).EndInit();
            this.pnlLevelDesc.ResumeLayout(false);
            this.pnlLevelDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPnlBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLevel1;
        private System.Windows.Forms.PictureBox pbxLevel2;
        private System.Windows.Forms.PictureBox pbxLevel3;
        private System.Windows.Forms.Panel pnlLevelDesc;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxHelp;
        private System.Windows.Forms.PictureBox pbxHard;
        private System.Windows.Forms.PictureBox pbxNormal;
        private System.Windows.Forms.PictureBox pbxEasy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnClosePnl;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbxPnlBar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}