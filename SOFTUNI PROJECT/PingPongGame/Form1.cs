﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace PingPongGame
{
   

    public partial class Form1 : Form
    {

        public static SpeechSynthesizer synth = new SpeechSynthesizer(); //synth.Speak("type message here");
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"c:\Windows\Media\chimes.wav");//Add sound directory from here and sp.Play(); & sp.PlayLooping();--->>> to play sound
        public int speed_left = 4;   //speed of the ball
        public int speed_top = 4;
        public int points = 0; //scored points
        


        #region MainLogic
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;  //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fullscreen
            racket.Top = playground.Bottom - (playground.Bottom / 10);  //set the position of the racket
            
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

            synth.SelectVoiceByHints(voiceGender);
            synth.Speak(message);
        }
        
    }
}
