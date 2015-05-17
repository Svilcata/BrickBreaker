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
        

        public int speed_left = 4;   //speed of the ball
        public int speed_top = 4;
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
            _soundPlayer = new SoundPlayer("background.wav");
            musicOn_lbl.Visible = false;
            musicOff_lbl.Visible = true;
            pause_lbl.Top = playground.Height / 2 - pause_lbl.Height / 2;
            pause_lbl.Left = playground.Width / 2 - pause_lbl.Width / 2;
            pause_lbl.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            racket.Left = Cursor.Position.X - (racket.Width / 2); //Set the center of the racket to the position of the cursor
            ball.Left += speed_left;
            ball.Top += speed_top;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
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
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;       //ball is out -> Game over!
                _soundPlayer.Stop();
            }
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Form2 f2 = new Form2();
            Cursor.Show();
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Cursor.Show();
                timer1.Enabled = !timer1.Enabled;
                
                f2.Show();
                
                //return true;
            }
            //return base.ProcessDialogKey(keyData);
            
            
        
            if (Form.ModifierKeys == Keys.None && keyData == Keys.P)
            {
                timer1.Enabled = !timer1.Enabled;
                pause_lbl.Visible = !pause_lbl.Visible;
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.M)
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

    }
}
