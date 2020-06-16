using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_ArcadeBubblePopper
{
    public partial class Form1 : Form
    {
        private int score;
        private int speed;
        private Random random;
        private bool gameOver;
        private List<Player> players;
        public Form1()
        {
            InitializeComponent();
            this.score = 0;
            this.speed = 5;
            this.random = new Random();
            this.gameOver = false;
            players = new List<Player>();
            ResetGame();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ScoreLabel.Text = "Score: " + this.score;
            
            foreach(Control control in this.Controls)
            {
                if(control is PictureBox)
                {
                    control.Top -= speed;

                    if (control.Top + control.Height < 0) //AKO E BOMBA, TOGAS MOZE DA SE RESETNUVA
                    {
                        control.Top = random.Next(this.Height + 100, this.Height + 400);
                        control.Left = random.Next(5, this.Width - 100);
                    }

                    if(control.Tag.Equals("Balloon") && control.Top < -50) // AKO KONTROLATA E BALON I STASA DO GORE, TOGAS IGRATA ZAVRSUVA
                    {
                        gameTimer.Stop();
                        ScoreLabel.Text = " GAME OVER!!! --- PRESS ENTER TO RETRY";
                        ShowDialogs();
                        gameOver = true;
                    }

                    if (score > 10)
                    {
                        speed = 8;
                    }
                    if(score > 20)
                    {
                        speed = 13;
                    }
                    if(score >= 35)
                    {
                        speed = 16;
                    }
                    if(score >= 50)
                    {
                        speed = 20;
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

        private void popBomb(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                bomb.Image = Properties.Resources.boom;
                gameTimer.Stop();
                ScoreLabel.Text = " GAME OVER!!! --- PRESS ENTER TO RETRY";
                ShowDialogs();
                gameOver = true;
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
                if(control is PictureBox)
                {
                    control.Top = random.Next(this.Height + 100, this.Height + 400);
                    control.Left = random.Next(5, this.Width - 100);
                }
            }
            bomb.Image = Properties.Resources.bomb;
            speed = 5;
            score = 0;
            ScoreLabel.Text = "Score: " + score;
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
                players.Add(p);
                nameForm.Close();
                ShowPlayersForm showPlayers = new ShowPlayersForm(players);
                showPlayers.ShowDialog();

            }
        }
    }
}
