using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;



namespace circle_tap
{


    public partial class Form1 : Form
    {
      
        


        public static int points = 0;
        public static int max_points = 0;
        public static int Tick;
        public static SortedList PC_list = new SortedList();//<<<<<<<<<<<<<<<<-

        public static List<Dot> MainList = new List<Dot>();


        public static Label score = new Label();


        public static object Instance { get; internal set; }

        // public event MouseEventHandler MouseClick;


        public Form1()
        {
            InitializeComponent();
            high_Score.Text = "Your Highest Score Is: " + points;

            score.Text = "Score: " + points;
            score.Width = 90;
            score.Height = 80;
            score.Location = new System.Drawing.Point(0, 0);
            score.Font = new System.Drawing.Font("Imprint MT Shadow", 13);
            score.Visible = true;
            this.Controls.Add(score);
            // lbl_over.Hide(); // Hides Game-Over Box until Game's Over.
            Game_Menu.Hide();// Hides the GameMenu ( "Game-over , Restart , Quit )" Options
            ContinueButton.Hide(); // Hides the Continue Button until "Load"
                        //replay.Hide();

        }

        public void Game_Over()     //
        {
            foreach(Dot X in Form1.MainList)
             {
                X.image.Visible = false;

            }
            Form1.MainList.Clear();
            //replay.Hide();

            Tick = 0;
            real_timer.Text = "Time Left: " + (Tick);
            timer1.Stop();
            //MessageBox.Show("Your score is: " + points);
            Game_Menu.Show(); // Show's Game Menu
          //  start.Enabled = false;
            replay.Enabled = true;

            if (max_points < points)
            {

                max_points = points;
                high_Score.Text = "Your Highest Score Is: " + points;
            }
            points = 0;
            score.Text = "Score: " + (points);
            // start.Text = "push replay";



        }

        public void Restart()   //  restart  the game 
        {
            load.Enabled = false;
            Tick = 0;
            timer1.Start();
            MainMenuLables();
            //start.Enabled = true;
           // start.Text = "push me";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //start.Text = "push me";
           // timer1.Enabled = true;
            //Random rnd = new Random();
            //int X = rnd.Next(70, 650);
          //  int Y = rnd.Next(70, 400);


            //points++;
          //  score.Text = "score: " + points;

        //  start.Location = new System.Drawing.Point(X, Y);


        }

        private void timer1_Tick(object sender, EventArgs e) //     implution timer amd use
        {
            Tick++;
            real_timer.Text = "Time Left: " + (25 - Tick);
            Random rnd = new Random();
            Create_Position_Circle();
            
            if (Tick >= 25)
            {
                Game_Over();
            }

            // Change Locations 

            if (Tick == 2 || Tick == 5 || Tick == 10 || Tick == 16 || Tick == 19 || Tick == 22)
            {
                for(int i = 0; i < 2; i++)
                {
                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    ChangeLocations CL = new ChangeLocations(X, Y, i);
                    MainList.Add(CL);
                    //>>>>>>>>>>         // PC_list.Add(i,pc);      <<<<<<<<<<
                    CL.DrawChangeLocations(gamePanel, i);
                }
            }

            // Timer Reducer


            if (Tick == 4 || Tick == 6 || Tick == 11 || Tick == 15 || Tick == 20 || Tick == 23 )
            {
                for (int i = 0; i < 2; i++)
                {
                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    Reduces_Time RT = new Reduces_Time(X, Y, i);
                    MainList.Add(RT);
                    //>>>>>>>>>>         // PC_list.Add(i,pc);      <<<<<<<<<<
                    RT.DrawReduceTime(gamePanel, i);
                }
            }

        }
        // --------------------------------------------------------------------------

        // Restart Options 


        private void replay_Click(object sender, EventArgs e)// replay the game
        {
            Game_Menu.Hide();
            gamePanel.Show();
            //MainMenuPanel.Hide();
            Restart();                               // Restart Via "Play" Button"
            replay.Enabled = false;
        }

        private void lbl_restart_Click(object sender, EventArgs e)
            {
               // MainMenuPanel.Hide();
            gamePanel.Show();
            Game_Menu.Hide();            // Restart Via Game Menu
                Restart();
                replay.Enabled = false;

            }
              // --------------------------------------------------------------------------

        private void Create_Position_Circle()
            {
                Random rnd = new Random();

                for (int i = 0; i < 1; i++)
                {
                    
                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    Positive_Circle pc = new Positive_Circle(X, Y, i);
                //>>>>>>>>>>         // PC_list.Add(i,pc);      <<<<<<<<<<
                    MainList.Add(pc);
                    pc.Draw_PC(gamePanel, i);

                }

            }
        
        

        private void save_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    SAVE s = new SAVE();
                    s.TICk = Tick;
                    s.points = points;
                    s.highscore = max_points;

                    foreach ( Dot d in MainList)
                    {
                        if(d.getname() == "positive") { s.PC++; }
                        if (d.getname() == "timer-reduce") { s.RT++; }
                        if (d.getname() == "negative") { s.CL++; }

                    }
                  formatter.Serialize(stream, s);
                }
            }
            Application.Exit();
        }

        private void load_Click(object sender, EventArgs e)
        {
            MainMenuLables();
            replay.Enabled = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
               SAVE S = (SAVE)binaryFormatter.Deserialize(stream);

      
                    Random rnd = new Random();
               
                for (int i = 0; i < S.PC; i++)
                {

                    Create_Position_Circle();

                }
                for (int i = 0; i < S.CL; i++)
                {

                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    ChangeLocations CL = new ChangeLocations(X, Y, i);
                    MainList.Add(CL);
                    //>>>>>>>>>>         // PC_list.Add(i,pc);      <<<<<<<<<<
                    CL.DrawChangeLocations(gamePanel, i);

                }
                for (int i = 0; i < S.RT; i++)
                {
                    int X = rnd.Next(10, 550);
                    int Y = rnd.Next(10, 270);

                    Reduces_Time RT = new Reduces_Time(X, Y, i);
                    MainList.Add(RT);
                    //>>>>>>>>>>         // PC_list.Add(i,pc);      <<<<<<<<<<
                    RT.DrawReduceTime(gamePanel, i);


                }
                load.Enabled = false;
                ContinueButton.Show();
                points = S.points;
                score.Text = "Score: " + S.points;
                Tick = S.TICk;
                real_timer.Text = "time left: " + (25 - Tick);
                max_points = S.highscore;
                high_Score.Text = "Your Highest Score Is: " + max_points;
                

            }
        }
        void ContinueButton_Click(object sender, EventArgs e)
        {
            ContinueButton.Hide();
            timer1.Start();
        }
        private void lbl_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuLables()
        {
            GameNameLabel.Hide();
            Smile1.Hide();
            Smile2.Hide();
            Smile3.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void Game_Menu_Enter(object sender, EventArgs e)
        {

        }
       





        // MainMenu Clicks

        /*private void StartGameMenu_Click(object sender, EventArgs e)
        {
           // NewMainMenu.Hide();
            replay.Hide();
            Restart();
            replay.Enabled = false;
        }
        private void QuitMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/


    }
}



    

       

