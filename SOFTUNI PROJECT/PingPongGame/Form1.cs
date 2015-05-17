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
            //Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;  //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fullscreen
            racket.Top = playground.Bottom - (playground.Bottom / 10);  //set the position of the racket
            mute.Top = playground.Top - (playground.Top / 10);
            mute.Left = playground.Right - 100;
            _soundPlayer = new SoundPlayer("background.wav");
            
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
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.P)
            {
                timer1.Enabled = false;
                MessageBox.Show("The game is paused \nHit Ok to continue");
                timer1.Enabled = true;
            }
            return base.ProcessDialogKey(keyData);
            
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

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (musicOn == false)
            {
                _soundPlayer.PlayLooping();
                musicOn = true;
            }
            else
            {
                _soundPlayer.Stop();
                musicOn = false;
            }
            
        }
        
    }
}
