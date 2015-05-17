using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void EscapeMenu_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            Form2 secondForm = new Form2();
            Form1 mainScr = new Form1();
            
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                mainScr.timer1.Enabled = !mainScr.timer1.Enabled;

                secondForm.Hide();
                return true;
            }
            return base.ProcessDialogKey(keyData);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //if (musicOn == false)
            //{
            //    _soundPlayer.PlayLooping();
            //    musicOn = true;
            //}
            //else
            //{
            //    _soundPlayer.Stop();
            //    musicOn = false;
            //}

        }
        
        private void resume_Click(object sender, EventArgs e)
        {
            
            
        }
        Form1 f1 = new Form1();
        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
