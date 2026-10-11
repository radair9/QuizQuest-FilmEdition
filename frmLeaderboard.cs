using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizQuestFilmEdition.Forms
{
    public partial class frmLeaderboard : Form
    {
        public frmLeaderboard()
        {
            InitializeComponent();
        }
        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            pnlLevel1.Visible = false;
            Classes.GameClass.allusers.Clear();

            
            using (StreamReader sr = new StreamReader("UserDetails.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Classes.Players p = new Classes.Players();
                    string[] data = line.Split(',');

                    p.Username = data[0];
                    p.Password = data[1];
                    p.avatarNum = Convert.ToInt32(data[2]);
                    p.levelsCompleted = Convert.ToInt32(data[3]);
                    p.Level1Unlocked = Convert.ToBoolean(data[4]);
                    p.Level2Unlocked = Convert.ToBoolean(data[5]);
                    p.Level3Unlocked = Convert.ToBoolean(data[6]);
                    p.Lvl1QuestionsAns = Convert.ToInt32(data[7]);
                    p.Lvl2TimeTaken = Convert.ToInt32(data[8]);
                    p.Lvl3Score = Convert.ToInt32(data[9]);

                    Classes.GameClass.allusers.Add(p);
                }
            }

            
            
        }

        

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            lblLevel.Text = "Level 1";
            pnlLevel1.Visible = true;

            Classes.GameClass.allusers = Classes.GameClass.allusers
                .OrderBy(p => p.Lvl1QuestionsAns)
                .ToList();


            List<Label> alllabels = new List<Label>()
            {
                 lblPos1,
                 lblPos2,
                 lblPos3,
                 lblPos4,
                 lblPos5,
                 lblPos6,
                 lblPos7,
                 lblPos8,
                 lblPos9,
                 lblPos10,

            };

            

            int count = Math.Min(Classes.GameClass.allusers.Count, 10);


            for (int i = 0; i < count; i++)
            {
                Classes.Players p = Classes.GameClass.allusers[i];
                alllabels[i].Text = $"{i + 1}.  {p.Username}  -  Answered {p.Lvl1QuestionsAns}";
            }

            hideLabels(alllabels);
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            lblLevel.Text = "Level 2";
            pnlLevel1.Visible = true;
            Classes.GameClass.allusers = Classes.GameClass.allusers
                .OrderBy(p => p.Lvl2TimeTaken)
                .ToList();


            List<Label> alllabels = new List<Label>()
            {
                 lblPos1,
                 lblPos2,
                 lblPos3,
                 lblPos4,
                 lblPos5,
                 lblPos6,
                 lblPos7,
                 lblPos8,
                 lblPos9,
                 lblPos10,

            };


            int count = Math.Min(Classes.GameClass.allusers.Count, 10);


            for (int i = 0; i < count; i++)
            {
                Classes.Players p = Classes.GameClass.allusers[i];
                alllabels[i].Text = $"{i + 1}.  {p.Username}  -  took {p.Lvl2TimeTaken}s";
            }

            hideLabels(alllabels);
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {

            pnlLevel1.Visible = true;
            lblLevel.Text = "Level 3";
            Classes.GameClass.allusers = Classes.GameClass.allusers
                .OrderByDescending(p => p.Lvl3Score)
                .ToList();


            List<Label> alllabels = new List<Label>()
            {
                 lblPos1,
                 lblPos2,
                 lblPos3,
                 lblPos4,
                 lblPos5,
                 lblPos6,
                 lblPos7,
                 lblPos8,
                 lblPos9,
                 lblPos10,

            };

            

            int count = Math.Min(Classes.GameClass.allusers.Count, 10);


            for (int i = 0; i < count; i++)
            {
                Classes.Players p = Classes.GameClass.allusers[i];
                alllabels[i].Text = $"{i + 1}.  {p.Username}  -  collected {p.Lvl3Score}";
            }

            hideLabels(alllabels);
        }

        private void pbxHome_Click(object sender, EventArgs e)
        {
            Forms.frmMap map = new Forms.frmMap();
            map.Show();
            this.Hide();
        }

        private void hideLabels(List<Label> alllabels)
        {
            foreach (Label lbl in alllabels)
            {
                if (lbl.Text == "label")
                {
                    lbl.Visible = false;
                }
                else
                {
                    lbl.Visible = true;
                }
            }
        }

    }
}
