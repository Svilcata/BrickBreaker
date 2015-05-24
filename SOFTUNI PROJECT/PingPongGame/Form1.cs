using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;


namespace PingPongGame
{


    public partial class Form1 : Form
    {

        public static SpeechSynthesizer synth = new SpeechSynthesizer(); //synth.Speak("type message here");
        private SoundPlayer _soundPlayer;

        public int PadcoordinаteX = 0;
        public int CursorcoordinаteY = 0;
        public int CursorcoordinаteX = 0;
        public double speed_left = RandomGenerator(-4, 4);  //speed of the ball
        public double speed_top = 4;
        public int points = 0; //scored points
        public bool musicOn = false;


        #region Body
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;  //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fullscreen
            racket.Top = playground.Bottom - (playground.Bottom / 10);  //set the position of the racket


            musicOff_lbl.Top = playground.Top - (playground.Top / 10);
            musicOff_lbl.Left = playground.Right - 110;
            musicOn_lbl.Top = playground.Top - (playground.Top / 10);
            musicOn_lbl.Left = playground.Right - 110;

            musicOn_lbl.Visible = false;
            musicOff_lbl.Visible = true;

            _soundPlayer = new SoundPlayer("background.wav");

            pause_lbl.Top = playground.Height / 2 - pause_lbl.Height / 2;
            pause_lbl.Left = playground.Width / 2 - pause_lbl.Width / 2;
            pause_lbl.Visible = false;

            resumeButton_lbl.Visible = false;
            resumeButton_lbl.Top = (playground.Height / 2 - resumeButton_lbl.Height / 2) - 100;
            resumeButton_lbl.Left = playground.Width / 2 - resumeButton_lbl.Width / 2;

            restartButton_lbl.Visible = false;
            restartButton_lbl.Top = (playground.Height / 2 - resumeButton_lbl.Height / 2) - 50;
            restartButton_lbl.Left = playground.Width / 2 - resumeButton_lbl.Width / 2;

            musicButton_lbl.Visible = false;
            musicButton_lbl.Top = playground.Height / 2 - musicButton_lbl.Height / 2;
            musicButton_lbl.Left = playground.Width / 2 - musicButton_lbl.Width / 2;

            exitButton_lbl.Visible = false;
            exitButton_lbl.Top = (playground.Height / 2 - exitButton_lbl.Height / 2) + 50;
            exitButton_lbl.Left = (playground.Width / 2 - exitButton_lbl.Width / 2);

            gameover_lbl.Visible = false;
            gameover_lbl.Top = (playground.Height / 2 - resumeButton_lbl.Height / 2) - 150;
            gameover_lbl.Left = playground.Width / 2 - resumeButton_lbl.Width / 2 - 20;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            racket.Left = Cursor.Position.X - (racket.Width / 2); //Set the center of the racket to the position of the cursor
            ball.Left += (int)speed_left;
            ball.Top += (int)speed_top;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Right >= racket.Left && ball.Left <= racket.Right)
            {
                speed_top += 0.3;
                speed_left += 1;
                speed_top = -speed_top; //change the direction
                points += 1;
                points_lbl.Text = points.ToString();
            }

            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;

            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Top >= playground.Bottom)
            {
                timer1.Enabled = false;       //ball is out -> Game over!
                Cursor.Show();
                gameover_lbl.Show();
                restartButton_lbl.Show();
                exitButton_lbl.Show();
                musicButton_lbl.Show();
                _soundPlayer.Stop();
            }
          
        }

  
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape) // Help Menu
            {
                if (!pause_lbl.Visible == true)
                {
                    PadcoordinаteX = Cursor.Position.X;

                    if (musicOn)
                    {
                        _soundPlayer.Stop();
                        //musicOff_lbl.Visible = true;
                        //musicOn_lbl.Visible = false;
                    }
                    timer1.Enabled = false;
                    Cursor.Show();
                    resumeButton_lbl.Visible = true;
                    restartButton_lbl.Visible = true;
                    musicButton_lbl.Visible = true;
                    exitButton_lbl.Visible = true;
                }
            }


            if (Form.ModifierKeys == Keys.None && keyData == Keys.P) // Pausing the game
            {
                if (!exitButton_lbl.Visible == true)
                {
                    timer1.Enabled = !timer1.Enabled;
                    pause_lbl.Visible = !pause_lbl.Visible;
                }

            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.M) // Music On/Off
            {
                musicOff_lbl.Visible = !musicOff_lbl.Visible;
                musicOn = !musicOn;
                musicOn_lbl.Visible = !musicOn_lbl.Visible;
                if (musicOn == true)
                {
                    _soundPlayer.PlayLooping();
                }
                else
                {
                    _soundPlayer.Stop();
                    musicOn = false;
                }
            }

            return true;

        }

        private void points_lbl_Click(object sender, EventArgs e)
        {

        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void Speaker(string message, VoiceGender voiceGender)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pause_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resumeButton_lbl_Click(object sender, EventArgs e) // Resume the game
        {
            Cursor.Hide();
            CursorcoordinаteY = Cursor.Position.Y;
            Point pt = new Point(PadcoordinаteX, CursorcoordinаteY);
            timer1.Enabled = true;
            resumeButton_lbl.Visible = false;
            restartButton_lbl.Visible = false;
            musicButton_lbl.Visible = false;
            exitButton_lbl.Visible = false;

            if (musicOn)
            {
                musicOn_lbl.Visible = true;
                musicOff_lbl.Visible = false;
                _soundPlayer.PlayLooping();
            }
            Cursor.Position = pt;
        }

        private void musicButton_lbl_Click(object sender, EventArgs e)
        {
            CursorcoordinаteY = Cursor.Position.Y;
            CursorcoordinаteX = Cursor.Position.X;
            Point pt = new Point(CursorcoordinаteX, CursorcoordinаteY);
            musicOff_lbl.Visible = !musicOff_lbl.Visible;
            musicOn = !musicOn;
            musicOn_lbl.Visible = !musicOn_lbl.Visible;
            Cursor.Position = pt;
            //if (musicOn == true)
            //{
            //    _soundPlayer.PlayLooping();
            //}
            //else
            //{
            //    _soundPlayer.Stop();
            //    musicOn = false;
            //}
            //timer1.Enabled = true;
            //Cursor.Hide();
            //resumeButton_lbl.Visible = false;
            //musicButton_lbl.Visible = false;
            //exitButton_lbl.Visible = false;
            //restartButton_lbl.Visible = false;
        }

        private void exitButton_lbl_Click(object sender, EventArgs e) // Exit the game
        {
            this.Close();
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void restartButton_lbl_Click(object sender, EventArgs e) //Restart button
        {
            Cursor.Hide();
            CursorcoordinаteY = Cursor.Position.Y;
            Point pt = new Point(PadcoordinаteX, CursorcoordinаteY);
            ball.Top = RandomGenerator(50, 200);
            ball.Left = RandomGenerator(0, 1000);
            speed_left = RandomGenerator(-4, 4);
            speed_top = 4;
            points = 0;
            points_lbl.Text = points.ToString();
            gameover_lbl.Hide();
            timer1.Enabled = true;
            resumeButton_lbl.Visible = false;
            restartButton_lbl.Visible = false;
            musicButton_lbl.Visible = false;
            exitButton_lbl.Visible = false;
            if (musicOn)
            {
                musicOn_lbl.Visible = true;
                musicOff_lbl.Visible = false;
                _soundPlayer.PlayLooping();
            }
        }
        public static int RandomGenerator(int i, int p)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(i, p);
            return randomNumber;
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void TheBrick_Click(object sender, EventArgs e)
        {

        }


    }
}
