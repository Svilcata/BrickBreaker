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

        public int maxSpeed = 12;
        public static SpeechSynthesizer synth = new SpeechSynthesizer(); //synth.Speak("type message here");
        private SoundPlayer _soundPlayer;
        public int level = 1;
        public int PadcoordinаteX = 0;
        public int CursorcoordinаteY = 0;
        public int CursorcoordinаteX = 0;
        public double speed_left = RandomGenerator(-4, 4);  //speed of the ball
        public double speed_top = 4;
        public int points = 0; //scored points
        public bool musicOn = false;


        #region Body
        public void InitializeBricks()
        {
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
            pictureBox11.Top = pictureBox1.Bottom + 25;
            pictureBox11.Left = playground.Left + 50;
            pictureBox11.Visible = true;
            pictureBox15.Top = pictureBox1.Bottom + 25;
            pictureBox15.Left = pictureBox11.Left + 130;
            pictureBox15.Visible = true;
            pictureBox12.Top = pictureBox1.Bottom + 25;
            pictureBox12.Left = pictureBox15.Left + 130;
            pictureBox12.Visible = true;
            pictureBox16.Top = pictureBox1.Bottom + 25;
            pictureBox16.Left = pictureBox12.Left + 130;
            pictureBox16.Visible = true;
            pictureBox13.Top = pictureBox1.Bottom + 25;
            pictureBox13.Left = pictureBox16.Left + 130;
            pictureBox13.Visible = true;
            pictureBox17.Top = pictureBox1.Bottom + 25;
            pictureBox17.Left = pictureBox13.Left + 130;
            pictureBox17.Visible = true;
            pictureBox14.Top = pictureBox1.Bottom + 25;
            pictureBox14.Left = pictureBox17.Left + 130;
            pictureBox14.Visible = true;
            pictureBox18.Top = pictureBox1.Bottom + 25;
            pictureBox18.Left = pictureBox14.Left + 130;
            pictureBox18.Visible = true;
            pictureBox19.Top = pictureBox1.Bottom + 25;
            pictureBox19.Left = pictureBox18.Left + 130;
            pictureBox19.Visible = true;
            pictureBox20.Top = pictureBox1.Bottom + 25;
            pictureBox20.Left = pictureBox19.Left + 130;
            pictureBox20.Visible = true;
        }
        public void HideBricks()
        {
            
            pictureBox1.Visible = false;
                                
            pictureBox2.Visible = false;
                            
            pictureBox3.Visible = false;
                      
            pictureBox4.Visible = false;
                    
            pictureBox5.Visible = false;
                      
            pictureBox6.Visible = false;
                      
            pictureBox7.Visible = false;
                     
            pictureBox8.Visible = false;
                       
            pictureBox9.Visible = false;
            
            pictureBox10.Visible = false;
                                   
            pictureBox11.Visible = false;
                         
            pictureBox15.Visible = false;
                       
            pictureBox12.Visible = false;
                         
            pictureBox16.Visible = false;
                          
            pictureBox13.Visible = false;
                         
            pictureBox17.Visible = false;
                         
            pictureBox14.Visible = false;
                   
            pictureBox18.Visible = false;

            pictureBox19.Visible = false;
                            
            pictureBox20.Visible = false;
        }
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
            
            label1.Top = playground.Top + 25;
            label1.Left = playground.Right - 110;
            level_lbl.Text = level.ToString();
            level_lbl.Left = label1.Left+55;
            level_lbl.Top = playground.Top + 25;
            musicOn_lbl.Visible = false;
            musicOff_lbl.Visible = true;

            InitializeBricks();

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
            int midOfRacket = racket.Letf + racket.Width / 2;
            racket.Left = Cursor.Position.X - (racket.Width / 2); //Set the center of the racket to the position of the cursor
            ball.Left += (int)speed_left;
            ball.Top += (int)speed_top;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Right >= racket.Left && ball.Left <= racket.Right)
            {
                if (speed_left <= maxSpeed && speed_top <= maxSpeed)
                {
                    if (ball.Right <= midOfRacket && speed_left > 0)
                    {
                        speed_top += 1;
                        speed_left += 2;
                        speed_top = -speed_top;
                        points += 1;
                        points_lbl.Text = points.ToString();
                    }
                    if (ball.Right <= midOfRacket && speed_left < 0)
                    {
                        speed_top += 1;
                        speed_left += 0;
                        speed_top = -speed_top;
                        points += 1;
                        points_lbl.Text = points.ToString();
                    }
                    if (ball.Right >= midOfRacket && speed_left > 0)
                    {
                        speed_top += 1;
                        speed_left += 0;
                        speed_top = -speed_top;
                        points += 1;
                        points_lbl.Text = points.ToString();
                    }
                    if (ball.Right >= midOfRacket && speed_left < 0)
                    {
                        speed_top += 1;
                        speed_left -= 2;
                        speed_top = -speed_top; //change the direction
                        points += 1;
                        points_lbl.Text = points.ToString();
                    }
                }
                else
                {
                    speed_top = -speed_top; //change the direction
                    points += 1;
                    points_lbl.Text = points.ToString();
                }
            }
            if (pictureBox1.Visible==true&&(ball.Top <= pictureBox1.Bottom && ball.Left <= pictureBox1.Right&&ball.Right>=pictureBox1.Left))
            {

                pictureBox1.Visible = false;
                
                
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox2.Visible==true&&(ball.Top <= pictureBox2.Bottom && ball.Left <= pictureBox2.Right && ball.Right >= pictureBox2.Left))
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
            else if (pictureBox3.Visible==true&&(ball.Top <= pictureBox3.Bottom && ball.Left <= pictureBox3.Right && ball.Right >= pictureBox3.Left))
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
            else if (pictureBox4.Visible == true && (ball.Top <= pictureBox4.Bottom && ball.Left <= pictureBox4.Right && ball.Right >= pictureBox4.Left))
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
            else if (pictureBox5.Visible == true && (ball.Top <= pictureBox5.Bottom && ball.Left <= pictureBox5.Right && ball.Right >= pictureBox5.Left))
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
            else if (pictureBox6.Visible == true && (ball.Top <= pictureBox6.Bottom && ball.Left <= pictureBox6.Right && ball.Right >= pictureBox6.Left))
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
            else if (pictureBox7.Visible == true && (ball.Top <= pictureBox7.Bottom && ball.Left <= pictureBox7.Right && ball.Right >= pictureBox7.Left))
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
            else if (pictureBox8.Visible == true && (ball.Top <= pictureBox8.Bottom && ball.Left <= pictureBox8.Right && ball.Right >= pictureBox8.Left))
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
            else if (pictureBox9.Visible == true && (ball.Top <= pictureBox9.Bottom && ball.Left <= pictureBox9.Right && ball.Right >= pictureBox9.Left))
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
            else if (pictureBox10.Visible == true && (ball.Top <= pictureBox10.Bottom && ball.Left <= pictureBox10.Right && ball.Right >= pictureBox10.Left))
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
            else if (pictureBox11.Visible == true && (ball.Top <= pictureBox11.Bottom && ball.Left <= pictureBox11.Right && ball.Right >= pictureBox11.Left))
            {

                pictureBox11.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox12.Visible == true && (ball.Top <= pictureBox12.Bottom && ball.Left <= pictureBox12.Right && ball.Right >= pictureBox12.Left))
            {

                pictureBox12.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox13.Visible == true && (ball.Top <= pictureBox13.Bottom && ball.Left <= pictureBox13.Right && ball.Right >= pictureBox13.Left))
            {

                pictureBox13.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox14.Visible == true && (ball.Top <= pictureBox14.Bottom && ball.Left <= pictureBox14.Right && ball.Right >= pictureBox14.Left))
            {

                pictureBox14.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox15.Visible == true && (ball.Top <= pictureBox15.Bottom && ball.Left <= pictureBox15.Right && ball.Right >= pictureBox15.Left))
            {

                pictureBox15.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox16.Visible == true && (ball.Top <= pictureBox16.Bottom && ball.Left <= pictureBox16.Right && ball.Right >= pictureBox16.Left))
            {

                pictureBox16.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox17.Visible == true && (ball.Top <= pictureBox17.Bottom && ball.Left <= pictureBox17.Right && ball.Right >= pictureBox17.Left))
            {

                pictureBox17.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox18.Visible == true && (ball.Top <= pictureBox18.Bottom && ball.Left <= pictureBox18.Right && ball.Right >= pictureBox18.Left))
            {

                pictureBox18.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox19.Visible == true && (ball.Top <= pictureBox19.Bottom && ball.Left <= pictureBox19.Right && ball.Right >= pictureBox19.Left))
            {

                pictureBox19.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
                points_lbl.Text = points.ToString();
            }
            else if (pictureBox20.Visible == true && (ball.Top <= pictureBox20.Bottom && ball.Left <= pictureBox20.Right && ball.Right >= pictureBox20.Left))
            {

                pictureBox20.Visible = false;
                speed_top = -speed_top; //change the direction
                points += 1;
                //speed_left = -speed_left;
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
                HideBricks();
            }
            if (points % 20 == 0 && points > 0)
            {


                InitializeBricks();
                level++;
                bool incr = true;
                if (incr)
                {
                    speed_top += 0.2;
                    speed_left += 0.2;
                    incr = false;
                    level_lbl.Text =level.ToString();
                    racket.Width -= 20;
                }


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
            InitializeBricks();
            CursorcoordinаteY = Cursor.Position.Y;
            Point pt = new Point(PadcoordinаteX, CursorcoordinаteY);
            ball.Top = RandomGenerator(50, 200);
            ball.Left = RandomGenerator(0, 1000);
            speed_left = RandomGenerator(-4, 4);
            speed_top = 4;
            level = 1;
            level_lbl.Text = level.ToString();
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
