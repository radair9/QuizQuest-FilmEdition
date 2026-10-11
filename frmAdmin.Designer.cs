
namespace QuizQuestFilmEdition.Forms
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.pbxDeleteUser = new System.Windows.Forms.PictureBox();
            this.pbxTopBar = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.pbxHome = new System.Windows.Forms.PictureBox();
            this.lblSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUsers.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 24;
            this.lbUsers.Location = new System.Drawing.Point(142, 123);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(203, 170);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // pbxDeleteUser
            // 
            this.pbxDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.pbxDeleteUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDeleteUser.Image = global::QuizQuestFilmEdition.Properties.Resources._continue;
            this.pbxDeleteUser.Location = new System.Drawing.Point(445, 179);
            this.pbxDeleteUser.Name = "pbxDeleteUser";
            this.pbxDeleteUser.Size = new System.Drawing.Size(155, 50);
            this.pbxDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDeleteUser.TabIndex = 2;
            this.pbxDeleteUser.TabStop = false;
            this.pbxDeleteUser.Click += new System.EventHandler(this.pbxDeleteUser_Click);
            // 
            // pbxTopBar
            // 
            this.pbxTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.pbxTopBar.Location = new System.Drawing.Point(-3, -1);
            this.pbxTopBar.Name = "pbxTopBar";
            this.pbxTopBar.Size = new System.Drawing.Size(786, 50);
            this.pbxTopBar.TabIndex = 3;
            this.pbxTopBar.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(323, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 23);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Remove A User";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lblRemove.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemove.Location = new System.Drawing.Point(175, 97);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(141, 23);
            this.lblRemove.TabIndex = 18;
            this.lblRemove.Text = "Select The User";
            // 
            // pbxHome
            // 
            this.pbxHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.pbxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHome.Image = global::QuizQuestFilmEdition.Properties.Resources.home;
            this.pbxHome.Location = new System.Drawing.Point(12, -1);
            this.pbxHome.Name = "pbxHome";
            this.pbxHome.Size = new System.Drawing.Size(50, 50);
            this.pbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHome.TabIndex = 19;
            this.pbxHome.TabStop = false;
            this.pbxHome.Click += new System.EventHandler(this.pbxHome_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(195)))));
            this.lblSelected.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelected.Location = new System.Drawing.Point(454, 123);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(138, 23);
            this.lblSelected.TabIndex = 20;
            this.lblSelected.Text = "Selected: None";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuizQuestFilmEdition.Properties.Resources.blankbackgrounfull;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(776, 437);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.pbxHome);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxTopBar);
            this.Controls.Add(this.pbxDeleteUser);
            this.Controls.Add(this.lbUsers);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveUser";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.PictureBox pbxDeleteUser;
        private System.Windows.Forms.PictureBox pbxTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.PictureBox pbxHome;
        private System.Windows.Forms.Label lblSelected;
    }
}