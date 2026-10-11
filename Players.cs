using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizQuestFilmEdition.Classes
{
    class Players
    {
        
        private string _username;
        private string _password;
        private int _avatarNum;
        private int _levelsCompleted = 0;
        private bool _level1Unlocked = false;
        private bool _level2Unlocked = false;
        private bool _level3Unlocked = false;
        private int _lvl1QuestionsAns = 0;
        private int _lvl2TimeTaken = 0;
        private int _lvl3Score = 0;
        

        public List<string> errorlist = new List<string>();
        public Players()
        {

        }

        public Players(string user, string pass, int avnum, int levels, bool level1, bool level2, bool level3, int lvl1score, int lvl2score, int lvl3score)
        {
            Username = user;
            Password = pass;
            avatarNum = avnum;
            _levelsCompleted = levels;
            _level1Unlocked = level1;
            _level2Unlocked = level2;
            _level3Unlocked = level3;
            _lvl1QuestionsAns = lvl1score;
            _lvl2TimeTaken = lvl2score;
            _lvl3Score = lvl3score;


    }
       

        public string Username
        {

            get { return _username; }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    errorlist.Add("Username cannot be blank.");
                    return;
                }

                if (value.Length < 3)
                {
                    errorlist.Add("Username must be at\n least 3 characters.");
                    return;
                }

                if (value.Length > 14)
                {
                    errorlist.Add("Username must be less\n than 14 characters.");
                    return;
                }

                _username = value;


            }


        }

        public string Password
        {
            get { return _password; }
            set
            {

               if (string.IsNullOrWhiteSpace(value))
                {
                    if (!errorlist.Contains("Password cannot be blank."))
                        errorlist.Add("Password cannot be blank.");
                    return;
                }

                if (value.Length < 3)
                {
                    errorlist.Add("Password must be at\n least 3 characters.");
                    return;
                }

                if (value.Length > 20)
                {
                    errorlist.Add("Password must be less\n than 20 characters.");
                    return;
                }
                

                _password = value;
            }
        }

        public void Validate(string confirmPassword, List<Players> allUsers)
        {
            errorlist.Clear();

            bool exists = false;

            foreach (Players p in allUsers)
            {
                if (p.Username == this.Username)
                {
                    exists = true;
                    break;
                }
            }

            if (exists == true)
            {
                errorlist.Add("Username is already taken.");
            }


            if (string.IsNullOrWhiteSpace(Password))
                errorlist.Add("Password cannot be blank.");

            if (Password != null && Password.Length < 3)
                errorlist.Add("Password must be at least 3 characters.");

            if (Password != null && Password.Length > 20)
                errorlist.Add("Password must be less than 20 characters.");

            if (Password != confirmPassword)
                errorlist.Add("Passwords do not match.");
        }


        public int avatarNum
        {
            get { return _avatarNum; }
            set
            {
                    _avatarNum = value;
            }
        }


        public int levelsCompleted
        {
            get { return _levelsCompleted; }
            set
            {
                _levelsCompleted = value;
            }
        }

        public bool Level1Unlocked
        {
            get { return _level1Unlocked; }
            set { _level1Unlocked = value; }
        }

        public bool Level2Unlocked
        {
            get { return _level2Unlocked; }
            set { _level2Unlocked = value; }
        }

        public bool Level3Unlocked
        {
            get { return _level3Unlocked; }
            set { _level3Unlocked = value; }
        }

        public int Lvl1QuestionsAns
        {
            get { return _lvl1QuestionsAns; }
            set { _lvl1QuestionsAns = value; }
        }

        public int Lvl2TimeTaken
        {
            get { return _lvl2TimeTaken; }
            set { _lvl2TimeTaken = value; }
        }

        public int Lvl3Score
        {
            get { return _lvl3Score; }
            set { _lvl3Score = value; }
        }
    }


   
}
