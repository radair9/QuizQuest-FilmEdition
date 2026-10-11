
namespace QuizQuestFilmEdition.Forms
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pbxSplash = new System.Windows.Forms.PictureBox();
            this.tmrLabel = new System.Windows.Forms.Timer(this.components);
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mxpTheme = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbxSubtitle = new System.Windows.Forms.PictureBox();
            this.pbxLakitu = new System.Windows.Forms.PictureBox();
            this.tmrLakitu = new System.Windows.Forms.Timer(this.components);
            this.tmrSubtitle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSplash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxpTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSubtitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLakitu)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // pbxSplash
            // 
            this.pbxSplash.Image = global::QuizQuestFilmEdition.Properties.Resources.splashmario_ezgif_com_speed;
            this.pbxSplash.Location = new System.Drawing.Point(-2, 1);
            this.pbxSplash.Name = "pbxSplash";
            this.pbxSplash.Size = new System.Drawing.Size(809, 450);
            this.pbxSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSplash.TabIndex = 1;
            this.pbxSplash.TabStop = false;
            this.pbxSplash.UseWaitCursor = true;
            this.pbxSplash.Click += new System.EventHandler(this.pbxSplash_Click);
            // 
            // tmrLabel
            // 
            this.tmrLabel.Enabled = true;
            this.tmrLabel.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::QuizQuestFilmEdition.Properties.Resources.quizquestlogo_removebg;
            this.pbxLogo.Location = new System.Drawing.Point(252, -129);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(294, 233);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.UseWaitCursor = true;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(490, 400);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quiz Quest";
            this.lblTitle.UseWaitCursor = true;
            this.lblTitle.Visible = false;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // mxpTheme
            // 
            this.mxpTheme.Enabled = true;
            this.mxpTheme.Location = new System.Drawing.Point(295, 319);
            this.mxpTheme.Name = "mxpTheme";
            this.mxpTheme.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mxpTheme.OcxState")));
            this.mxpTheme.Size = new System.Drawing.Size(135, 44);
            this.mxpTheme.TabIndex = 3;
            this.mxpTheme.UseWaitCursor = true;
            this.mxpTheme.Enter += new System.EventHandler(this.mxpTheme_Enter);
            // 
            // pbxSubtitle
            // 
            this.pbxSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.pbxSubtitle.Image = global::QuizQuestFilmEdition.Properties.Resources.subtfilmeditionremovebg;
            this.pbxSubtitle.Location = new System.Drawing.Point(31, 167);
            this.pbxSubtitle.Name = "pbxSubtitle";
            this.pbxSubtitle.Size = new System.Drawing.Size(198, 147);
            this.pbxSubtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSubtitle.TabIndex = 4;
            this.pbxSubtitle.TabStop = false;
            this.pbxSubtitle.UseWaitCursor = true;
            // 
            // pbxLakitu
            // 
            this.pbxLakitu.Image = global::QuizQuestFilmEdition.Properties.Resources.lakituYAY;
            this.pbxLakitu.Location = new System.Drawing.Point(46, -129);
            this.pbxLakitu.Name = "pbxLakitu";
            this.pbxLakitu.Size = new System.Drawing.Size(161, 168);
            this.pbxLakitu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLakitu.TabIndex = 5;
            this.pbxLakitu.TabStop = false;
            this.pbxLakitu.UseWaitCursor = true;
            this.pbxLakitu.Click += new System.EventHandler(this.pbxLakitu_Click);
            // 
            // tmrLakitu
            // 
            this.tmrLakitu.Enabled = true;
            this.tmrLakitu.Interval = 200;
            this.tmrLakitu.Tick += new System.EventHandler(this.tmrLakitu_Tick);
            // 
            // tmrSubtitle
            // 
            this.tmrSubtitle.Enabled = true;
            this.tmrSubtitle.Tick += new System.EventHandler(this.tmrSubtitle_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(252)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.pbxSubtitle);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pbxLakitu);
            this.Controls.Add(this.pbxSplash);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mxpTheme);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSplash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mxpTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSubtitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLakitu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.PictureBox pbxSplash;
        private System.Windows.Forms.Timer tmrLabel;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxSubtitle;
        private System.Windows.Forms.PictureBox pbxLakitu;
        private System.Windows.Forms.Timer tmrLakitu;
        private System.Windows.Forms.Timer tmrSubtitle;
        private AxWMPLib.AxWindowsMediaPlayer mxpTheme;
    }
}