
namespace QuizQuestFilmEdition.Forms
{
    partial class frmLevel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel1));
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.lblPnlFeedback = new System.Windows.Forms.Label();
            this.pbxPnlBar = new System.Windows.Forms.PictureBox();
            this.lblClosepnl = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.pbxEnemyHealth = new System.Windows.Forms.PictureBox();
            this.pbxAvatarHealth = new System.Windows.Forms.PictureBox();
            this.pbxEnemy = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxBackHealth = new System.Windows.Forms.PictureBox();
            this.pbxEnemyBackHealth = new System.Windows.Forms.PictureBox();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.pbxNextQuestion = new System.Windows.Forms.PictureBox();
            this.pbxHelp = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGhostface = new System.Windows.Forms.Label();
            this.pbxHome = new System.Windows.Forms.PictureBox();
            this.pnlQuestion.SuspendLayout();
            this.pnlFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPnlBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemyHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemyBackHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNextQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlQuestion.Controls.Add(this.lblTimer);
            this.pnlQuestion.Controls.Add(this.lblQuestion);
            this.pnlQuestion.Controls.Add(this.btnAns3);
            this.pnlQuestion.Controls.Add(this.btnAns4);
            this.pnlQuestion.Controls.Add(this.btnAns2);
            this.pnlQuestion.Controls.Add(this.btnAns1);
            this.pnlQuestion.Controls.Add(this.lblQuestionNum);
            this.pnlQuestion.Location = new System.Drawing.Point(721, 88);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(510, 339);
            this.pnlQuestion.TabIndex = 9;
            this.pnlQuestion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQuestion_Paint);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimer.Location = new System.Drawing.Point(9, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(42, 17);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "label1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.SteelBlue;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblQuestion.Location = new System.Drawing.Point(17, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(469, 74);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "What is the highest grossing film in the UK?";
            // 
            // btnAns3
            // 
            this.btnAns3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAns3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAns3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAns3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnAns3.Location = new System.Drawing.Point(123, 239);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(131, 81);
            this.btnAns3.TabIndex = 4;
            this.btnAns3.Text = "Avengers: Endgame";
            this.btnAns3.UseVisualStyleBackColor = false;
            this.btnAns3.Click += new System.EventHandler(this.btnAns3_Click);
            // 
            // btnAns4
            // 
            this.btnAns4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAns4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAns4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAns4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnAns4.Location = new System.Drawing.Point(260, 239);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(131, 81);
            this.btnAns4.TabIndex = 3;
            this.btnAns4.Text = "Forrest Gump";
            this.btnAns4.UseVisualStyleBackColor = false;
            this.btnAns4.Click += new System.EventHandler(this.btnAns4_Click);
            // 
            // btnAns2
            // 
            this.btnAns2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAns2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAns2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAns2.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnAns2.Location = new System.Drawing.Point(260, 152);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(131, 81);
            this.btnAns2.TabIndex = 2;
            this.btnAns2.Text = "Titanic";
            this.btnAns2.UseVisualStyleBackColor = false;
            this.btnAns2.Click += new System.EventHandler(this.btnAns2_Click);
            // 
            // btnAns1
            // 
            this.btnAns1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAns1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAns1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAns1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnAns1.Location = new System.Drawing.Point(123, 152);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(131, 81);
            this.btnAns1.TabIndex = 1;
            this.btnAns1.Text = "Avatar";
            this.btnAns1.UseVisualStyleBackColor = false;
            this.btnAns1.Click += new System.EventHandler(this.btnAns1_Click);
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.Font = new System.Drawing.Font("Tahoma", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblQuestionNum.Location = new System.Drawing.Point(208, 9);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(109, 21);
            this.lblQuestionNum.TabIndex = 0;
            this.lblQuestionNum.Text = "Question 1:";
            this.lblQuestionNum.Click += new System.EventHandler(this.lblQuestionNum_Click);
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlFeedback.Controls.Add(this.lblPnlFeedback);
            this.pnlFeedback.Controls.Add(this.pbxPnlBar);
            this.pnlFeedback.Controls.Add(this.lblClosepnl);
            this.pnlFeedback.Controls.Add(this.btnReturn);
            this.pnlFeedback.Controls.Add(this.lblFeedback);
            this.pnlFeedback.Location = new System.Drawing.Point(24, 21);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(201, 122);
            this.pnlFeedback.TabIndex = 6;
            // 
            // lblPnlFeedback
            // 
            this.lblPnlFeedback.AutoSize = true;
            this.lblPnlFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lblPnlFeedback.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPnlFeedback.Location = new System.Drawing.Point(44, 10);
            this.lblPnlFeedback.Name = "lblPnlFeedback";
            this.lblPnlFeedback.Size = new System.Drawing.Size(114, 17);
            this.lblPnlFeedback.TabIndex = 16;
            this.lblPnlFeedback.Text = "Answer Feedback";
            // 
            // pbxPnlBar
            // 
            this.pbxPnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.pbxPnlBar.Location = new System.Drawing.Point(0, 0);
            this.pbxPnlBar.Name = "pbxPnlBar";
            this.pbxPnlBar.Size = new System.Drawing.Size(201, 35);
            this.pbxPnlBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPnlBar.TabIndex = 15;
            this.pbxPnlBar.TabStop = false;
            // 
            // lblClosepnl
            // 
            this.lblClosepnl.AutoSize = true;
            this.lblClosepnl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblClosepnl.Location = new System.Drawing.Point(14, 53);
            this.lblClosepnl.Name = "lblClosepnl";
            this.lblClosepnl.Size = new System.Drawing.Size(49, 22);
            this.lblClosepnl.TabIndex = 2;
            this.lblClosepnl.Text = "close";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Location = new System.Drawing.Point(150, 89);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(48, 30);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Close";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblFeedback.Location = new System.Drawing.Point(14, 53);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(56, 22);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "label1";
            // 
            // pbxEnemyHealth
            // 
            this.pbxEnemyHealth.Image = global::QuizQuestFilmEdition.Properties.Resources.battlepoke;
            this.pbxEnemyHealth.Location = new System.Drawing.Point(447, 380);
            this.pbxEnemyHealth.Name = "pbxEnemyHealth";
            this.pbxEnemyHealth.Size = new System.Drawing.Size(150, 20);
            this.pbxEnemyHealth.TabIndex = 7;
            this.pbxEnemyHealth.TabStop = false;
            this.pbxEnemyHealth.Click += new System.EventHandler(this.pbxEnemyHealth_Click);
            // 
            // pbxAvatarHealth
            // 
            this.pbxAvatarHealth.Image = global::QuizQuestFilmEdition.Properties.Resources.battlepoke;
            this.pbxAvatarHealth.Location = new System.Drawing.Point(234, 380);
            this.pbxAvatarHealth.Name = "pbxAvatarHealth";
            this.pbxAvatarHealth.Size = new System.Drawing.Size(150, 20);
            this.pbxAvatarHealth.TabIndex = 8;
            this.pbxAvatarHealth.TabStop = false;
            // 
            // pbxEnemy
            // 
            this.pbxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pbxEnemy.Image = global::QuizQuestFilmEdition.Properties.Resources.screamcharlvl1;
            this.pbxEnemy.Location = new System.Drawing.Point(401, 139);
            this.pbxEnemy.Name = "pbxEnemy";
            this.pbxEnemy.Size = new System.Drawing.Size(235, 235);
            this.pbxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEnemy.TabIndex = 1;
            this.pbxEnemy.TabStop = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbxAvatar.Image = global::QuizQuestFilmEdition.Properties.Resources.yoshi;
            this.pbxAvatar.Location = new System.Drawing.Point(234, 207);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(150, 167);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 0;
            this.pbxAvatar.TabStop = false;
            // 
            // pbxBackHealth
            // 
            this.pbxBackHealth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbxBackHealth.Location = new System.Drawing.Point(234, 380);
            this.pbxBackHealth.Name = "pbxBackHealth";
            this.pbxBackHealth.Size = new System.Drawing.Size(150, 20);
            this.pbxBackHealth.TabIndex = 11;
            this.pbxBackHealth.TabStop = false;
            // 
            // pbxEnemyBackHealth
            // 
            this.pbxEnemyBackHealth.BackColor = System.Drawing.Color.Black;
            this.pbxEnemyBackHealth.Location = new System.Drawing.Point(447, 380);
            this.pbxEnemyBackHealth.Name = "pbxEnemyBackHealth";
            this.pbxEnemyBackHealth.Size = new System.Drawing.Size(150, 20);
            this.pbxEnemyBackHealth.TabIndex = 10;
            this.pbxEnemyBackHealth.TabStop = false;
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // pbxNextQuestion
            // 
            this.pbxNextQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbxNextQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxNextQuestion.Image = global::QuizQuestFilmEdition.Properties.Resources.newquestion;
            this.pbxNextQuestion.Location = new System.Drawing.Point(698, 467);
            this.pbxNextQuestion.Name = "pbxNextQuestion";
            this.pbxNextQuestion.Size = new System.Drawing.Size(176, 85);
            this.pbxNextQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNextQuestion.TabIndex = 13;
            this.pbxNextQuestion.TabStop = false;
            this.pbxNextQuestion.Click += new System.EventHandler(this.pbxNextQuestion_Click);
            // 
            // pbxHelp
            // 
            this.pbxHelp.BackColor = System.Drawing.Color.Transparent;
            this.pbxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHelp.Image = global::QuizQuestFilmEdition.Properties.Resources.marioquestion;
            this.pbxHelp.Location = new System.Drawing.Point(12, 482);
            this.pbxHelp.Name = "pbxHelp";
            this.pbxHelp.Size = new System.Drawing.Size(70, 70);
            this.pbxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHelp.TabIndex = 14;
            this.pbxHelp.TabStop = false;
            this.pbxHelp.Click += new System.EventHandler(this.pbxHelp_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblUsername.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblUsername.Location = new System.Drawing.Point(230, 403);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 24);
            this.lblUsername.TabIndex = 69;
            this.lblUsername.Text = "Username";
            // 
            // lblGhostface
            // 
            this.lblGhostface.AutoSize = true;
            this.lblGhostface.BackColor = System.Drawing.Color.Transparent;
            this.lblGhostface.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblGhostface.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblGhostface.Location = new System.Drawing.Point(443, 403);
            this.lblGhostface.Name = "lblGhostface";
            this.lblGhostface.Size = new System.Drawing.Size(98, 24);
            this.lblGhostface.TabIndex = 70;
            this.lblGhostface.Text = "Ghostface";
            // 
            // pbxHome
            // 
            this.pbxHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHome.Image = global::QuizQuestFilmEdition.Properties.Resources.home;
            this.pbxHome.Location = new System.Drawing.Point(822, 12);
            this.pbxHome.Name = "pbxHome";
            this.pbxHome.Size = new System.Drawing.Size(50, 50);
            this.pbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHome.TabIndex = 71;
            this.pbxHome.TabStop = false;
            this.pbxHome.Click += new System.EventHandler(this.pbxHome_Click);
            // 
            // frmLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizQuestFilmEdition.Properties.Resources.level1map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pbxHome);
            this.Controls.Add(this.lblGhostface);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbxHelp);
            this.Controls.Add(this.pbxNextQuestion);
            this.Controls.Add(this.pnlFeedback);
            this.Controls.Add(this.pbxEnemyHealth);
            this.Controls.Add(this.pbxAvatarHealth);
            this.Controls.Add(this.pbxEnemy);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pbxBackHealth);
            this.Controls.Add(this.pbxEnemyBackHealth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            this.Load += new System.EventHandler(this.frmLevel1_Load);
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPnlBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemyHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatarHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemyBackHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNextQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.PictureBox pbxEnemy;
        private System.Windows.Forms.PictureBox pbxEnemyHealth;
        private System.Windows.Forms.PictureBox pbxAvatarHealth;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Label lblQuestionNum;
        private System.Windows.Forms.Panel pnlFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pbxEnemyBackHealth;
        private System.Windows.Forms.PictureBox pbxBackHealth;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.PictureBox pbxNextQuestion;
        private System.Windows.Forms.Label lblClosepnl;
        private System.Windows.Forms.PictureBox pbxHelp;
        private System.Windows.Forms.PictureBox pbxPnlBar;
        private System.Windows.Forms.Label lblPnlFeedback;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGhostface;
        private System.Windows.Forms.PictureBox pbxHome;
    }
}