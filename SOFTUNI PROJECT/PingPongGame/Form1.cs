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
        private const int WIDTH = 500;

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
            this.Width = WIDTH;
            this.MaximizeBox = false; 
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;  //Bring the form to the front
            //this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fullscreen
            racket.Top = playground.Bottom - (playground.Bottom / 10);  //set the position of the racket


            musicOff_lbl.Top = playground.Top - (playground.Top / 10);
            musicOff_lbl.Left = playground.Right - 110;
            musicOn_lbl.Top = playground.Top - (playground.Top / 10);
            musicOn_lbl.Left = playground.Right - 110;
            
            musicOn_lbl.Visible = false;
            musicOff_lbl.Visible = true;
            
            pictureBox1.Top = playground.Top - (playground.Top - 80);

            pictureBox1.Left = playground.Left + 50;
            pictureBox1.Visible = true;
            pictureBox2.Top = playground.Top - (playground.Top - 80);
            pictureBox2.Left = pictureBox1.Left + 130;
            pictureBox2.Visible = true;
            pictureBox3.Top = playground.Top - (playground.Top - 80);
            pictureBox3.Left = pictureBox2.Left + 130; ;
            pictureBox3.Visible = true;
            pictureBox4.Top = playground.Top - (playground.Top - 80);
            pictureBox4.Left = pictureBox3.Left + 130;
            pictureBox4.Visible = true;
            pictureBox5.Top = playground.Top - (playground.Top - 80);
            pictureBox5.Left = pictureBox4.Left + 130;
            pictureBox5.Visible = true;
            pictureBox6.Top = playground.Top - (playground.Top - 80);
            pictureBox6.Left = pictureBox5.Left + 130;
            pictureBox6.Visible = true;
            pictureBox7.Top = playground.Top - (playground.Top - 80);
            pictureBox7.Left = pictureBox6.Left + 130;
            pictureBox7.Visible = true;
            pictureBox8.Top = playground.Top - (playground.Top - 80);
            pictureBox8.Left = pictureBox7.Left + 130;
            pictureBox8.Visible = true;
            pictureBox9.Top = playground.Top - (playground.Top - 80);
            pictureBox9.Left = pictureBox8.Left + 130;
            pictureBox9.Visible = true;
            pictureBox10.Top = playground.Top - (playground.Top - 80);
            pictureBox10.Left = pictureBox9.Left + 130;
            pictureBox10.Visible = true;

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
                //points += 1;
                //points_lbl.Text = points.ToString();
            }
            if (ball.Top <= pictureBox1.Bottom && ball.Left <= pictureBox1.Right&&ball.Right>=pictureBox1.Left)
            {

                pictureBox1.Visible = false;
                pictureBox1.Hide();
                pictureBox1.Top = playground.Top - (playground.Top - 800);
                pictureBox1.Left = playground.Left + 1030;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox2.Bottom && ball.Left <= pictureBox2.Right && ball.Right >= pictureBox2.Left)
            {

                pictureBox2.Visible = false;
                pictureBox2.Hide();
                pictureBox2.Top = playground.Top - (playground.Top - 800);
                pictureBox2.Left = playground.Left + 1030;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox3.Bottom && ball.Left <= pictureBox3.Right && ball.Right >= pictureBox3.Left)
            {

                pictureBox3.Visible = false;
                pictureBox3.Hide();
                pictureBox3.Top = playground.Top - (playground.Top - 8000);
                pictureBox3.Left = playground.Left + 10030;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox4.Bottom && ball.Left <= pictureBox4.Right && ball.Right >= pictureBox4.Left)
            {

                pictureBox4.Visible = false;
                pictureBox4.Hide();
                pictureBox4.Top = playground.Top - (playground.Top - 8000);
                pictureBox4.Left = playground.Left + 10030;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox5.Bottom && ball.Left <= pictureBox5.Right && ball.Right >= pictureBox5.Left)
            {

                pictureBox5.Visible = false;
                pictureBox5.Hide();
                pictureBox5.Top = playground.Top - (playground.Top - 8000);
                pictureBox5.Left = playground.Left + 10300;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox6.Bottom && ball.Left <= pictureBox6.Right && ball.Right >= pictureBox6.Left)
            {

                pictureBox6.Visible = false;
                pictureBox6.Hide();
                pictureBox6.Top = playground.Top - (playground.Top - 8000);
                pictureBox6.Left = playground.Left + 10030; ;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox7.Bottom && ball.Left <= pictureBox7.Right && ball.Right >= pictureBox7.Left)
            {

                pictureBox7.Visible = false;
                pictureBox7.Hide();
                pictureBox7.Top = playground.Top - (playground.Top - 8000);
                pictureBox7.Left = playground.Left + 10300;
                speed_top = -speed_top; //change the direction
                points += 1;
               // speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox8.Bottom && ball.Left <= pictureBox8.Right && ball.Right >= pictureBox8.Left)
            {

                pictureBox8.Visible = false;
                pictureBox8.Hide();
                pictureBox8.Top = playground.Top - (playground.Top - 8000);
                pictureBox8.Left = playground.Left + 10300;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox9.Bottom && ball.Left <= pictureBox9.Right && ball.Right >= pictureBox9.Left)
            {

                pictureBox9.Visible = false;
                pictureBox9.Hide();
                pictureBox9.Top = playground.Top - (playground.Top - 8000);
                pictureBox9.Left = playground.Left + 10030;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (ball.Top <= pictureBox10.Bottom && ball.Left <= pictureBox10.Right && ball.Right >= pictureBox10.Left)
            {

                pictureBox10.Visible = false;
                pictureBox10.Hide();
                pictureBox10.Top = playground.Top - (playground.Top - 8000);
                pictureBox10.Left = playground.Left + 10300;
                speed_top = -speed_top; //change the direction
                points += 1;
               // speed_left = -speed_left;
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void gameover_lbl_Click(object sender, EventArgs e)
        {

        }


    }
}
