
namespace QuizQuestFilmEdition
{
    partial class frmTest
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
            this.lblMovement = new System.Windows.Forms.Label();
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.BackColor = System.Drawing.Color.Transparent;
            this.lblMovement.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.lblMovement.ForeColor = System.Drawing.Color.Coral;
            this.lblMovement.Location = new System.Drawing.Point(12, 427);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(132, 25);
            this.lblMovement.TabIndex = 0;
            this.lblMovement.Text = "Movement:";
            // 
            // tmrMovement
            // 
            this.tmrMovement.Enabled = true;
            this.tmrMovement.Interval = 20;
            this.tmrMovement.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lblMovement);
            this.Name = "frmTest";
            this.Text = "4 Way Sprite";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Timer tmrMovement;
    }
}