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
    public partial class frmLevel1 : Form
    {
        List<(string Question, string[] answers)> quizList = new List<(string Question, string[] answers)>(); //quiz list
        Random rnd1 = new Random(); // random line in quiz list


        //variables
        int timeLeft = 10;
        int health = 100;
        int healthbar = 150;
        int enemyhealth = 150;
        int score = 1;

        int dmg = 0;


        //locations for answers
        int box1x = 123;
        int box1y = 152;
        int box2x = 260;
        int box2y = 152;
        int box3x = 123;
        int box3y = 239;
        int box4x = 260;
        int box4y = 239;

        //local var for difficulty
        int difficultylvl;

        

        public frmLevel1()
        {
            InitializeComponent();
        }

        public void DisplayQuestion()
        {
            //method to randomly display the questions
            if (quizList.Count == 0)
                return; //prevents erros if theres an empty list
          

            int index = rnd1.Next(quizList.Count);
            var randomQA = quizList[index];
            quizList.RemoveAt(index);


            lblQuestion.Text = randomQA.Question;

            if (randomQA.answers.Length >= 4)
            {
                btnAns1.Text = randomQA.answers[0];
                btnAns2.Text = randomQA.answers[1];
                btnAns3.Text = randomQA.answers[2];
                btnAns4.Text = randomQA.answers[3];

                if (difficultylvl == 3)
                {
                    timeLeft = 10;
                }
                else if (difficultylvl == 2)
                {
                    timeLeft = 15;
                }
                else
                {
                    timeLeft = 9999;
                }

                

                lblTimer.Text = $"Time left: {timeLeft}s";
                tmrCountdown.Start();
            }
        }

        private void frmLevel1_Load(object sender, EventArgs e)
        {
            //set local var difficulty
            difficultylvl = Classes.GameClass.currentDifficulty;

            lblUsername.Text = Classes.GameClass.currentuser.Username;

            if (difficultylvl == 1)
            {
                lblTimer.Visible = false;
            }

            DisplayQuestion();
            tmrCountdown.Stop();

            //set avatar
            pbxAvatar.Image = Classes.GameClass.GetAvatar();

            pnlQuestion.Visible = false;
            pnlFeedback.Hide();
            lblClosepnl.Visible = false;
            lblFeedback.Visible = true;
            pnlFeedback.Location = new Point(334, 226);
            pnlQuestion.Location = new Point(183, 71);



            //read in questions
            string filePath = "QuestionsLVL1.txt";

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                int questionMarkIndex = line.IndexOf('?'); //seperates the question from the answers
                if (questionMarkIndex == -1)
                    continue;

                string question = line.Substring(0, questionMarkIndex + 1).Trim();
                string rest = line.Substring(questionMarkIndex + 1).Trim();

                string[] answers = rest.Split(',');

                for (int x = 0; x < answers.Length; x++)
                    answers[x] = answers[x].Trim();

                quizList.Add((question, answers));
            }

        }

        private void pbxEasyQ_Click(object sender, EventArgs e)
        {

        }

        private void pbxNormalQ_Click(object sender, EventArgs e)
        {

        }

        private void pbxHardQ_Click(object sender, EventArgs e)
        {

        }

        public void Dead()
        {
            MessageBox.Show("You died..");
            pbxAvatarHealth.Size = new Size(healthbar, 20);
            Forms.frmMap map = new Forms.frmMap();
            map.Show();
            this.Hide();
        }
        public void newQuestion()
        {
            //method to display a new question

            pbxEnemyBackHealth.BringToFront();
            pbxEnemyHealth.BringToFront();
            pbxBackHealth.BringToFront();
            pbxAvatarHealth.BringToFront();
            pnlQuestion.BringToFront();
            pnlFeedback.BringToFront();

            lblQuestionNum.Text = ($"Question {score}");


            Random rnd = new Random();
            int num = rnd.Next(1, 5);

            pnlQuestion.Visible = true;
            DisplayQuestion();
            switch (num)
            {
                case 1:
                    btnAns1.Location = new Point(box1x, box1y);
                    btnAns2.Location = new Point(box2x, box2y);
                    btnAns3.Location = new Point(box3x, box3y);
                    btnAns4.Location = new Point(box4x, box4y);
                    break;
                case 2:
                    btnAns1.Location = new Point(box2x, box2y);
                    btnAns2.Location = new Point(box3x, box3y);
                    btnAns3.Location = new Point(box4x, box4y);
                    btnAns4.Location = new Point(box1x, box1y);
                    break;
                case 3:
                    btnAns1.Location = new Point(box3x, box3y);
                    btnAns2.Location = new Point(box4x, box4y);
                    btnAns3.Location = new Point(box1x, box1y);
                    btnAns4.Location = new Point(box2x, box2y);
                    break;
                case 4:
                    btnAns1.Location = new Point(box4x, box4y);
                    btnAns2.Location = new Point(box3x, box3y);
                    btnAns3.Location = new Point(box2x, box2y);
                    btnAns4.Location = new Point(box1x, box1y);
                    break;
                default:
                    btnAns1.Location = new Point(box1x, box1y);
                    btnAns2.Location = new Point(box2x, box2y);
                    btnAns3.Location = new Point(box3x, box3y);
                    btnAns4.Location = new Point(box4x, box4y);
                    break;
            }
        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            //correct answer button 
            pnlQuestion.Visible = false;
            pbxNextQuestion.Visible = true;
            lblFeedback.Text = ("Correct answer!");


            //different damage levels based on difficulty
            if (difficultylvl == 1)
            {
                enemyhealth = enemyhealth - 10;
            }
            else if (difficultylvl == 2)
            {
                enemyhealth = enemyhealth - 20;
            }
            else 
            {
                enemyhealth = enemyhealth - 30;
            }
          
            pnlFeedback.Show();
            pbxEnemy.Image = Properties.Resources.screamcharhurt;
            score++;
            tmrCountdown.Stop();
        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            //incorrect answer button (1)
            pnlQuestion.Visible = false;
            pbxNextQuestion.Visible = true;
            if (difficultylvl == 1)
            {
                health = health - 10;
                healthbar = healthbar - 15;
            }
            else if (difficultylvl == 2)
            {
                health = health - 20;
                healthbar = healthbar - 30;
            }
            else
            {
                health = health - 30;
                healthbar = healthbar - 45;
            }

            lblFeedback.Text = ("Incorrect answer!");
            pnlFeedback.Show();
            pbxEnemy.Image = Properties.Resources.screamcharattack;
            score++;
            tmrCountdown.Stop();
            dmg++;

        }

        private void btnAns3_Click(object sender, EventArgs e)
        {
            //incorrect answer button (2)
            pnlQuestion.Visible = false;
            pbxNextQuestion.Visible = true;
            if (difficultylvl == 1)
            {
                health = health - 10;
                healthbar = healthbar - 15;
            }
            else if (difficultylvl == 2)
            {
                health = health - 20;
                healthbar = healthbar - 30;
            }
            else
            {
                health = health - 30;
                healthbar = healthbar - 45;
            }

            lblFeedback.Text = ("Incorrect answer!");
            pnlFeedback.Show();
            pbxEnemy.Image = Properties.Resources.screamcharattack;
            score++;
            tmrCountdown.Stop();
            dmg++;
        }

        private void btnAns4_Click(object sender, EventArgs e)
        {
            //incorrect answer button (3)
            pnlQuestion.Visible = false;
            pbxNextQuestion.Visible = true;
            if (difficultylvl == 1)
            {
                health = health - 10;
                healthbar = healthbar - 15;
            }
            else if(difficultylvl == 2)
            {
                health = health - 20;
                healthbar = healthbar - 30;
            }
            else
            {
                health = health - 30;
                healthbar = healthbar - 45;
            }

            lblFeedback.Text = ("Incorrect answer!");
            pnlFeedback.Show();
            pbxEnemy.Image = Properties.Resources.screamcharattack;
            score++;
            tmrCountdown.Stop();
            dmg++;

        }


        private void pnlQuestion_Paint(object sender, PaintEventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            //on feedback panel
            pnlFeedback.Hide();
            pnlQuestion.Visible = false;
            lblClosepnl.Visible = false;
            lblFeedback.Visible = true;
            pbxEnemy.Image = Properties.Resources.screamcharlvl1;

            

            if (difficultylvl == 3 && dmg == 4)
            {
                Dead();
            }
            else if (difficultylvl == 2 && dmg >= 5)
            {
                Dead();
            }
            else if (difficultylvl == 1 && dmg == 10)
            {
                Dead();
            }
            else
            {
                if (lblFeedback.Text == "Incorrect answer!")
                {
                    pbxAvatarHealth.Size = new Size(healthbar, 20);
                }
                else
                {
                    pbxEnemyHealth.Size = new Size(enemyhealth, 20);
                }
            }

            if (enemyhealth <= 0)
            {                          
                MessageBox.Show(
                    "You won! Return to Map to complete Level 2 next.",
                    "Congratulations!",
                    MessageBoxButtons.OK,
                    
                    MessageBoxIcon.Information
                );

                Forms.frmMap map = new Forms.frmMap();
                map.Show();
                this.Hide();

                Classes.GameClass.currentuser.levelsCompleted++; 
                Classes.GameClass.currentuser.Level2Unlocked = true;
                Classes.GameClass.currentuser.Lvl1QuestionsAns = score;

                Classes.GameClass.SavePlayers();

            }
            else if (lblFeedback.Text == "Incorrect answer!")
            {
                pbxAvatarHealth.Size = new Size(healthbar, 20);
            }
            else
            {
                pbxEnemyHealth.Size = new Size(enemyhealth, 20);
            }
        }

        private void pbxEnemyHealth_Click(object sender, EventArgs e)
        {

        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = ($"Time left: {timeLeft}s");

            if (timeLeft <= 0)
            {
                tmrCountdown.Stop();
                pnlQuestion.Visible = false;
                lblFeedback.Text = "Time's up!";
                pnlFeedback.Show();
                
                if (difficultylvl == 2)
                {
                    health = health - 20;
                    healthbar = healthbar - 30;
                }
                else
                {
                    health = health - 20;
                    healthbar = healthbar - 30;
                }
                pbxEnemy.Image = Properties.Resources.screamcharattack;
                score++;
            }
        }

        private void lblQuestionNum_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Forms.frmMap map = new Forms.frmMap();
            map.Show();
            this.Hide();
        }

        private void pbxNextQuestion_Click(object sender, EventArgs e)
        {
            pbxNextQuestion.Visible = false; 
            if (pnlFeedback.Visible == false)
            {
                newQuestion();
            }
            else
            {
                lblFeedback.Visible = false;
                lblClosepnl.Visible = true;
                lblClosepnl.Text = "Please click on 'Close'\n to continue.";
                pbxNextQuestion.Visible = true;
            }
            
        }

        private void pbxHelp_Click(object sender, EventArgs e)
        {
            frmHelp move = new frmHelp(4);
            move.ShowDialog();
        }

        private void pbxHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               $"You're in the middle of a game, would you like to go back to the map?",
                 "Leave Game",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information
           ); ;

            if (result == DialogResult.Yes)
            {
                Forms.frmMap map1 = new Forms.frmMap();
                map1.Show();
                this.Hide();
            }
            else
            {
                return;
            }

        }
    }
}
