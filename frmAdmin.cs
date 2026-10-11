using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizQuestFilmEdition.Forms
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();

            if (!File.Exists("UserDetails.txt"))
                return;

            var lines = File.ReadAllLines("UserDetails.txt");

            foreach (var line in lines)
            {
                string username = line.Split(',')[0];
                lbUsers.Items.Add(username);
            }
        }

        private void pbxDeleteUser_Click(object sender, EventArgs e)
        {
                if (lbUsers.SelectedItem == null)
                {
                    MessageBox.Show("Please select a user to remove.");                  
                }

                string selectedUsername = lbUsers.SelectedItem.ToString();

            
                if (selectedUsername == Classes.GameClass.currentuser.Username)
                {
                    MessageBox.Show("You cannot delete the currently logged-in user.");
                    return;
                }

               
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to remove '{selectedUsername}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }
                    

                
                var lines = File.ReadAllLines("UserDetails.txt").ToList();

                string lineToRemove = lines
                    .FirstOrDefault(l => l.StartsWith(selectedUsername + ","));

                if (lineToRemove == null)
                {
                    MessageBox.Show("User not found in file.");
                    return;
                }

                lines.Remove(lineToRemove);
                File.WriteAllLines("UserDetails.txt", lines);

                lbUsers.Items.Remove(selectedUsername);

                lblSelected.Text = "Selected: None";

                MessageBox.Show("User removed successfully.");
            

        }


        private void pbxHome_Click(object sender, EventArgs e)
        {
            Forms.frmMap map = new Forms.frmMap();
            map.Show();
            this.Hide();
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                lblSelected.Text = "Selected: " + lbUsers.SelectedItem.ToString();
            }
        }
    }
}
