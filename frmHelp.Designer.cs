
namespace QuizQuestFilmEdition.Forms
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pnlWrittenHelp = new System.Windows.Forms.Panel();
            this.MXPVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnClosePnl = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxPnlBar = new System.Windows.Forms.PictureBox();
            this.btnWrittenHelp = new System.Windows.Forms.Button();
            this.btnVideoHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxTopBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.pnlWrittenHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MXPVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPnlBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxClose
            // 
            this.pbxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.pbxClose.Image = global::QuizQuestFilmEdition.Properties.Resources.goback;
            this.pbxClose.Location = new System.Drawing.Point(2, 0);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(122, 46);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClose.TabIndex = 1;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // pnlWrittenHelp
            // 
            this.pnlWrittenHelp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlWrittenHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWrittenHelp.Controls.Add(this.MXPVideo);
            this.pnlWrittenHelp.Controls.Add(this.lblDesc);
            this.pnlWrittenHelp.Controls.Add(this.btnClosePnl);
            this.pnlWrittenHelp.Controls.Add(this.lblTitle);
            this.pnlWrittenHelp.Controls.Add(this.pbxPnlBar);
            this.pnlWrittenHelp.Location = new System.Drawing.Point(139, 253);
            this.pnlWrittenHelp.Name = "pnlWrittenHelp";
            this.pnlWrittenHelp.Size = new System.Drawing.Size(537, 410);
            this.pnlWrittenHelp.TabIndex = 4;
            // 
            // MXPVideo
            // 
            this.MXPVideo.Enabled = true;
            this.MXPVideo.Location = new System.Drawing.Point(24, 48);
            this.MXPVideo.Name = "MXPVideo";
            this.MXPVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXPVideo.OcxState")));
            this.MXPVideo.Size = new System.Drawing.Size(489, 290);
            this.MXPVideo.TabIndex = 17;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDesc.Location = new System.Drawing.Point(24, 61);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(449, 68);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Click Easy, Normal or Hard to generate a new question.\r\nAnswer 5 correct and you " +
    "win, however if \r\nyou answer 5 incorrect or run out of time.. you lose.";
            // 
            // btnClosePnl
            // 
            this.btnClosePnl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClosePnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePnl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePnl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClosePnl.Location = new System.Drawing.Point(229, 344);
            this.btnClosePnl.Name = "btnClosePnl";
            this.btnClosePnl.Size = new System.Drawing.Size(92, 43);
            this.btnClosePnl.TabIndex = 7;
            this.btnClosePnl.Text = "Close";
            this.btnClosePnl.UseVisualStyleBackColor = false;
            this.btnClosePnl.Click += new System.EventHandler(this.btnClosePnl_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(225, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Written Help";
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
            // btnWrittenHelp
            // 
            this.btnWrittenHelp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWrittenHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWrittenHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWrittenHelp.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnWrittenHelp.Location = new System.Drawing.Point(175, 142);
            this.btnWrittenHelp.Name = "btnWrittenHelp";
            this.btnWrittenHelp.Size = new System.Drawing.Size(183, 75);
            this.btnWrittenHelp.TabIndex = 7;
            this.btnWrittenHelp.Text = "Written Help";
            this.btnWrittenHelp.UseVisualStyleBackColor = false;
            this.btnWrittenHelp.Click += new System.EventHandler(this.btnWrittenHelp_Click_1);
            // 
            // btnVideoHelp
            // 
            this.btnVideoHelp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVideoHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideoHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVideoHelp.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnVideoHelp.Location = new System.Drawing.Point(448, 142);
            this.btnVideoHelp.Name = "btnVideoHelp";
            this.btnVideoHelp.Size = new System.Drawing.Size(176, 75);
            this.btnVideoHelp.TabIndex = 8;
            this.btnVideoHelp.Text = "Video Help";
            this.btnVideoHelp.UseVisualStyleBackColor = false;
            this.btnVideoHelp.Click += new System.EventHandler(this.btnVideoHelp_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(328, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Remove A User";
            // 
            // pbxTopBar
            // 
            this.pbxTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.pbxTopBar.Location = new System.Drawing.Point(2, -4);
            this.pbxTopBar.Name = "pbxTopBar";
            this.pbxTopBar.Size = new System.Drawing.Size(786, 50);
            this.pbxTopBar.TabIndex = 18;
            this.pbxTopBar.TabStop = false;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizQuestFilmEdition.Properties.Resources.blankbackgrounfull;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(786, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlWrittenHelp);
            this.Controls.Add(this.pbxClose);
            this.Controls.Add(this.pbxTopBar);
            this.Controls.Add(this.btnVideoHelp);
            this.Controls.Add(this.btnWrittenHelp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.pnlWrittenHelp.ResumeLayout(false);
            this.pnlWrittenHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MXPVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPnlBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.Panel pnlWrittenHelp;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnClosePnl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxPnlBar;
        private AxWMPLib.AxWindowsMediaPlayer MXPVideo;
        private System.Windows.Forms.Button btnWrittenHelp;
        private System.Windows.Forms.Button btnVideoHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxTopBar;
    }
}