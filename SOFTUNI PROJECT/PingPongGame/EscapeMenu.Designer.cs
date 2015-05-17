namespace PingPongGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resume = new System.Windows.Forms.Button();
            this.musicSwitch = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(65, 45);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(99, 23);
            this.resume.TabIndex = 0;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // musicSwitch
            // 
            this.musicSwitch.Location = new System.Drawing.Point(65, 74);
            this.musicSwitch.Name = "musicSwitch";
            this.musicSwitch.Size = new System.Drawing.Size(99, 23);
            this.musicSwitch.TabIndex = 1;
            this.musicSwitch.Text = "Music ON/OFF";
            this.musicSwitch.UseVisualStyleBackColor = true;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(65, 103);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(99, 23);
            this.restart.TabIndex = 2;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(65, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Quit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 254);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.musicSwitch);
            this.Controls.Add(this.resume);
            this.HelpButton = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EscapeMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button musicSwitch;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button button4;
    }
}