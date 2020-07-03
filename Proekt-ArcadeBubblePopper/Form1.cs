using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proekt_ArcadeBubblePopper
{
    public partial class Form1 : Form
    {
        public int life;
        private int levels;
        private int score;
        private int speed;
        private Random random;
        private bool gameOver;
        private int BallonTop = 0;
        private int delayBoom=0;
        private int HeightGone;
        private List<Player> players;
        String ballonType;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.levels = 1;
            this.score = 0;
            this.speed = 5;
            this.life = 3;
            this.ballonType = "";
            this.random = new Random();
            this.gameOver = false;
            players = new List<Player>();
            ResetGame();
            
        }
        public void lifeMinus()
        {
            life--;
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            
            
            if (life == 2) { life1.Hide(); }
            if (life == 1) { life2.Hide(); }
            if (life == 0)
            {
                life3.Hide();
                gameTimer.Stop();
                ScoreLabel.Text = " GAME OVER!!! --- PRESS ENTER TO RETRY";
                ShowDialogs();
                gameOver = true;
            }

            ScoreLabel.Text = "Score: " + this.score;
            Level.Text = "Level " + this.levels;
            //Control old = new PictureBox();

            foreach (Control control in this.Controls)
            {

                // Vrati za novite baloni, stariot tag deka ne e pukknat.
               if (control.Name.Equals(ballonType) && control.Tag.Equals("ReachedTop") && control.Top>HeightGone)
               {
                      control.Tag = "Balloon"; 
               }

               
               
                if (BallonTop == 1)
                {
                    lifeMinus();
                    BallonTop = 0;
                }

                this.life1.Location = new Point(558, 36);
                this.life2.Location = new Point(594, 36);
                this.life3.Location = new Point(630, 36);
                if (control is PictureBox)
                {
                    if (control.Tag.Equals("blownBomb"))
                    {
                        delayBoom++;
                        if (delayBoom > 4)
                        {
                            control.Hide();
                            delayBoom = 0;
                            control.Tag = "bomb";
                        }
                    }
                    /*
                     //too much flickering
                    if(Math.Abs(old.Top-control.Top) <500 && Math.Abs(old.Left-control.Left)<500)
                    {
                        //Console.WriteLine(control.Top);
                      
                        control.BackColor = Color.Transparent;
                        control.BringToFront();
                        old.SendToBack();
                    }
                    */
                    control.Top -= speed;

                    if (control.Top + control.Height < 0) //AKO E BOMBA, TOGAS MOZE DA SE RESETNUVA
                    {
                        control.Top = random.Next(this.Height + 100, this.Height + 400);
                        control.Left = random.Next(5, this.Width - 100);
                        
                        bomb.Image = Properties.Resources.bomb;
                        control.Show();
                    }
                    
                        if (control.Tag.Equals("Balloon") && control.Top < -50 ) // AKO KONTROLATA E BALON I STASA DO GORE, TOGAS IGRATA ZAVRSUVA
                        {

                           
                            BallonTop=1;           // life--
                            control.Tag = "ReachedTop"; // Deaktiviraj Balon za da ne odzema zivoti istiot balon
                            ballonType = control.Name;
                            HeightGone = control.Top;
                            
                            //gameTimer.Stop();
                            //ScoreLabel.Text = " GAME OVER!!! --- PRESS ENTER TO RETRY";
                            //ShowDialogs();
                           // life--;
                            
                            //gameOver = true;
                        }
                    
                  
                   // old = control;

                    if (score > 10)
                    {
                        levels = 2;
                        speed = 6;
                       
                    }
                    if(score > 20)
                    {
                        speed = 8;
                        levels = 3;
                        
                    }
                    if(score >= 35)
                    {
                        speed = 9;
                        levels = 4;
                        
                    }
                    if(score >= 50)
                    {
                        speed = 11;
                        levels = 7;
                      
                    }
                }
            }
        }

        private void popBalloon(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                var balloon = (PictureBox)sender;
                
                balloon.Top = random.Next(this.Height + 100, this.Height + 400);
                balloon.Left = random.Next(5, this.Width - 100);

                score++;
            }

        }

        private bool Delay(int millisecond)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool flag = false;
            while (!flag)
            {
                if (sw.ElapsedMilliseconds > millisecond)
                {
                    flag = true;
                }
            }
            sw.Stop();
            return true;

        }

        private void popBomb(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                bomb.Image = Properties.Resources.boom;
                BallonTop=1;
                //(PictureBox)sender.
                var bomba = (PictureBox)sender;
               
                bomba.Tag = "blownBomb";



                
                //gameTimer.Stop();
                //ScoreLabel.Text = " GAME OVER!!! --- PRESS ENTER TO RETRY";
                //ShowDialogs();
                //life--;
                /*
                if (bomba.Tag.Equals("bomb") && BallonTop == 1)
                {
                    lifeMinus();
                    BallonTop = 0;
                    bomba.Tag = "blownup";

                }
                */
                //gameOver = true;
                //bomb.Image = Properties.Resources.bomb;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && gameOver == true)
            {
                ResetGame();
            }
        }
  
        public void ResetGame()
        {
            foreach(Control control in this.Controls)
            {
               
                if (control is PictureBox)
                {
                    control.Top = random.Next(this.Height + 100, this.Height + 400);
                    control.Left = random.Next(5, this.Width - 100);
                }
            }
            //bomb.Image = Properties.Resources.bomb;
            speed = 5;
            score = 0;
            
            ScoreLabel.Text = "Score: " + score;
            Level.Text = "Level " + levels;
            gameOver = false;
            gameTimer.Start();
            
        }
        /*Ovaa funkcija gi vagja dialozite na krajot na igrata
         * ovozmozhuva da vnesite ime vo forma , pri shto se otvora druga forma
         * kade shto se sodrzhat site igrachi koi ja zavrshile igrata i niven rezultat
         * listata e sortirana po goleminata na rezultatot vo nerastecki redosled
         * 
       */
        private void ShowDialogs()
        {
            AddNameForm nameForm = new AddNameForm();
            if (nameForm.ShowDialog() == DialogResult.OK)
            {
                Player p = nameForm.player;
                p.Score = score;
                p.level = levels;
                players.Add(p);
                nameForm.Close();
                ShowPlayersForm showPlayers = new ShowPlayersForm(players);
                showPlayers.ShowDialog();
               

            }
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Level_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
