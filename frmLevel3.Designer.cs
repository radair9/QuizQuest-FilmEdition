
namespace QuizQuestFilmEdition.Forms
{
    partial class frmLevel3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel3));
            this.tmrAvatar = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pbxHome = new System.Windows.Forms.PictureBox();
            this.pbxAvoid = new System.Windows.Forms.PictureBox();
            this.pbxStar3 = new System.Windows.Forms.PictureBox();
            this.pbxStar2 = new System.Windows.Forms.PictureBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.pbxStar1 = new System.Windows.Forms.PictureBox();
            this.pbxMenuBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvoid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAvatar
            // 
            this.tmrAvatar.Enabled = true;
            this.tmrAvatar.Interval = 10;
            this.tmrAvatar.Tick += new System.EventHandler(this.tmrAvatar_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.SteelBlue;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblScore.Location = new System.Drawing.Point(12, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 22);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSpeed.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblSpeed.Location = new System.Drawing.Point(453, 12);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(80, 22);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "Speed: 0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblTimer.Location = new System.Drawing.Point(103, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(107, 22);
            this.lblTimer.TabIndex = 21;
            this.lblTimer.Text = "Time Left: 0";
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartGame.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btnStartGame.Location = new System.Drawing.Point(222, 247);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(172, 94);
            this.btnStartGame.TabIndex = 22;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pbxHome
            // 
            this.pbxHome.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHome.Image = global::QuizQuestFilmEdition.Properties.Resources.home;
            this.pbxHome.Location = new System.Drawing.Point(559, -3);
            this.pbxHome.Name = "pbxHome";
            this.pbxHome.Size = new System.Drawing.Size(53, 48);
            this.pbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHome.TabIndex = 20;
            this.pbxHome.TabStop = false;
            this.pbxHome.Click += new System.EventHandler(this.pbxHome_Click);
            // 
            // pbxAvoid
            // 
            this.pbxAvoid.BackColor = System.Drawing.Color.Transparent;
            this.pbxAvoid.Image = global::QuizQuestFilmEdition.Properties.Resources.clapperboardavoid;
            this.pbxAvoid.Location = new System.Drawing.Point(206, 71);
            this.pbxAvoid.Name = "pbxAvoid";
            this.pbxAvoid.Size = new System.Drawing.Size(93, 88);
            this.pbxAvoid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvoid.TabIndex = 6;
            this.pbxAvoid.TabStop = false;
            this.pbxAvoid.Tag = "avoid";
            // 
            // pbxStar3
            // 
            this.pbxStar3.BackColor = System.Drawing.Color.Transparent;
            this.pbxStar3.Image = ((System.Drawing.Image)(resources.GetObject("pbxStar3.Image")));
            this.pbxStar3.Location = new System.Drawing.Point(457, 87);
            this.pbxStar3.Name = "pbxStar3";
            this.pbxStar3.Size = new System.Drawing.Size(93, 88);
            this.pbxStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStar3.TabIndex = 4;
            this.pbxStar3.TabStop = false;
            this.pbxStar3.Tag = "collect";
            // 
            // pbxStar2
            // 
            this.pbxStar2.BackColor = System.Drawing.Color.Transparent;
            this.pbxStar2.Image = ((System.Drawing.Image)(resources.GetObject("pbxStar2.Image")));
            this.pbxStar2.Location = new System.Drawing.Point(331, 51);
            this.pbxStar2.Name = "pbxStar2";
            this.pbxStar2.Size = new System.Drawing.Size(93, 88);
            this.pbxStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStar2.TabIndex = 3;
            this.pbxStar2.TabStop = false;
            this.pbxStar2.Tag = "collect";
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbxAvatar.Image = global::QuizQuestFilmEdition.Properties.Resources.toad;
            this.pbxAvatar.Location = new System.Drawing.Point(256, 571);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(107, 115);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 1;
            this.pbxAvatar.TabStop = false;
            // 
            // pbxStar1
            // 
            this.pbxStar1.BackColor = System.Drawing.Color.Transparent;
            this.pbxStar1.Image = global::QuizQuestFilmEdition.Properties.Resources.mariostar;
            this.pbxStar1.Location = new System.Drawing.Point(57, 87);
            this.pbxStar1.Name = "pbxStar1";
            this.pbxStar1.Size = new System.Drawing.Size(93, 88);
            this.pbxStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStar1.TabIndex = 0;
            this.pbxStar1.TabStop = false;
            this.pbxStar1.Tag = "collect";
            // 
            // pbxMenuBar
            // 
            this.pbxMenuBar.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxMenuBar.Location = new System.Drawing.Point(2, -3);
            this.pbxMenuBar.Name = "pbxMenuBar";
            this.pbxMenuBar.Size = new System.Drawing.Size(619, 48);
            this.pbxMenuBar.TabIndex = 71;
            this.pbxMenuBar.TabStop = false;
            // 
            // frmLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 702);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbxHome);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.pbxAvoid);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbxStar3);
            this.Controls.Add(this.pbxStar2);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.pbxStar1);
            this.Controls.Add(this.pbxMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 3";
            this.Load += new System.EventHandler(this.frmLevel3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLevel3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLevel3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvoid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxStar1;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Timer tmrAvatar;
        private System.Windows.Forms.PictureBox pbxStar2;
        private System.Windows.Forms.PictureBox pbxStar3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox pbxAvoid;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox pbxHome;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pbxMenuBar;
    }
}