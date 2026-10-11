using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace QuizQuestFilmEdition.Classes
{
    class GameClass
    {
        public static List<Players> allusers = new List<Players>();
        public static Players currentuser;
        public static int currentDifficulty = 2;
        public static void getUserDetails()
            {
                try
                {
                    using (StreamReader readlogin = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserDetails.txt", false))
                    {
                        while (!readlogin.EndOfStream)
                        {
                            Players readin = new Players();
                            string[] temp = readlogin.ReadLine().Split(',');
                            readin.Username = temp[0];
                            readin.Password = temp[1];
                            readin.avatarNum = Convert.ToInt32(temp[2]);
                            readin.levelsCompleted = Convert.ToInt32(temp[3]);
                            
                            readin.Level1Unlocked = Convert.ToBoolean(temp[4]);
                            readin.Level2Unlocked = Convert.ToBoolean(temp[5]);
                            readin.Level3Unlocked = Convert.ToBoolean(temp[6]);

                            readin.Lvl1QuestionsAns = Convert.ToInt32(temp[7]);
                            readin.Lvl2TimeTaken = Convert.ToInt32(temp[8]);
                            readin.Lvl3Score = Convert.ToInt32(temp[9]);

                        allusers.Add(readin);
                        }
                    }
                }

                catch (Exception)
                {
                    
                }

            }

        public static void SavePlayers()
        {
            using (StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "UserDetails.txt", false))
            {
                for (int x = 0; x < allusers.Count; x++)
                {
                    string AllDetails = allusers[x].Username + ',' + allusers[x].Password + ',' + allusers[x].avatarNum + ',' + allusers[x].levelsCompleted + ',' + allusers[x].Level1Unlocked + ',' + allusers[x].Level2Unlocked + ',' + allusers[x].Level3Unlocked + ',' + allusers[x].Lvl1QuestionsAns + ',' + allusers[x].Lvl2TimeTaken + ',' + allusers[x].Lvl3Score;
                    streamWriter.WriteLine(AllDetails);
                }
            }


        }

        public static Image GetAvatar()
        {
            int avatarpicked = currentuser.avatarNum;

            switch (Classes.GameClass.currentuser.avatarNum)
            {
                case 1:
                    return Properties.Resources.toad;
                case 2:
                    return Properties.Resources.goomba;
                case 3:
                    return Properties.Resources.yoshi;
                default:
                    return Properties.Resources.toad;
            }
        }


    }
}
