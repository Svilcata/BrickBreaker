namespace PingPongGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.restartButton_lbl = new System.Windows.Forms.Button();
            this.exitButton_lbl = new System.Windows.Forms.Button();
            this.musicButton_lbl = new System.Windows.Forms.Button();
            this.resumeButton_lbl = new System.Windows.Forms.Button();
            this.pause_lbl = new System.Windows.Forms.Label();
            this.ball = new OvalPictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.points_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.musicOn_lbl = new System.Windows.Forms.Label();
            this.musicOff_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.restartButton_lbl);
            this.playground.Controls.Add(this.exitButton_lbl);
            this.playground.Controls.Add(this.musicButton_lbl);
            this.playground.Controls.Add(this.resumeButton_lbl);
            this.playground.Controls.Add(this.pause_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.score_lbl);
            this.playground.Controls.Add(this.musicOn_lbl);
            this.playground.Controls.Add(this.musicOff_lbl);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1068, 590);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameover_lbl.Location = new System.Drawing.Point(437, 74);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(190, 37);
            this.gameover_lbl.TabIndex = 14;
            this.gameover_lbl.Text = "Game Over!";
            // 
            // restartButton_lbl
            // 
            this.restartButton_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton_lbl.Location = new System.Drawing.Point(453, 180);
            this.restartButton_lbl.Name = "restartButton_lbl";
            this.restartButton_lbl.Size = new System.Drawing.Size(150, 50);
            this.restartButton_lbl.TabIndex = 13;
            this.restartButton_lbl.Text = "Restart";
            this.restartButton_lbl.UseVisualStyleBackColor = true;
            this.restartButton_lbl.Click += new System.EventHandler(this.restartButton_lbl_Click);
            // 
            // exitButton_lbl
            // 
            this.exitButton_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton_lbl.Location = new System.Drawing.Point(453, 273);
            this.exitButton_lbl.Name = "exitButton_lbl";
            this.exitButton_lbl.Size = new System.Drawing.Size(150, 50);
            this.exitButton_lbl.TabIndex = 12;
            this.exitButton_lbl.Text = "EXIT :(";
            this.exitButton_lbl.UseVisualStyleBackColor = true;
            this.exitButton_lbl.Click += new System.EventHandler(this.exitButton_lbl_Click);
            // 
            // musicButton_lbl
            // 
            this.musicButton_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicButton_lbl.Location = new System.Drawing.Point(453, 224);
            this.musicButton_lbl.Name = "musicButton_lbl";
            this.musicButton_lbl.Size = new System.Drawing.Size(150, 50);
            this.musicButton_lbl.TabIndex = 11;
            this.musicButton_lbl.Text = "Music";
            this.musicButton_lbl.UseVisualStyleBackColor = true;
            this.musicButton_lbl.Click += new System.EventHandler(this.musicButton_lbl_Click);
            // 
            // resumeButton_lbl
            // 
            this.resumeButton_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton_lbl.Location = new System.Drawing.Point(453, 134);
            this.resumeButton_lbl.Name = "resumeButton_lbl";
            this.resumeButton_lbl.Size = new System.Drawing.Size(150, 50);
            this.resumeButton_lbl.TabIndex = 10;
            this.resumeButton_lbl.Text = "Resume";
            this.resumeButton_lbl.UseVisualStyleBackColor = true;
            this.resumeButton_lbl.Click += new System.EventHandler(this.resumeButton_lbl_Click);
            // 
            // pause_lbl
            // 
            this.pause_lbl.AutoSize = true;
            this.pause_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_lbl.Location = new System.Drawing.Point(377, 249);
            this.pause_lbl.Name = "pause_lbl";
            this.pause_lbl.Size = new System.Drawing.Size(301, 74);
            this.pause_lbl.TabIndex = 7;
            this.pause_lbl.Text = "Game paused!\r\nPress \"P\" to resume";
            this.pause_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pause_lbl.Click += new System.EventHandler(this.pause_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.DimGray;
            this.ball.Location = new System.Drawing.Point(172, 180);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // racket
            // 
            this.racket.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(415, 558);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 1;
            this.racket.TabStop = false;
            this.racket.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_lbl.Location = new System.Drawing.Point(162, 22);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(52, 55);
            this.points_lbl.TabIndex = 4;
            this.points_lbl.Text = "0";
            this.points_lbl.Click += new System.EventHandler(this.points_lbl_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(22, 22);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(169, 55);
            this.score_lbl.TabIndex = 3;
            this.score_lbl.Text = "Score:";
            // 
            // musicOn_lbl
            // 
            this.musicOn_lbl.AutoSize = true;
            this.musicOn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicOn_lbl.Location = new System.Drawing.Point(947, 12);
            this.musicOn_lbl.Name = "musicOn_lbl";
            this.musicOn_lbl.Size = new System.Drawing.Size(99, 24);
            this.musicOn_lbl.TabIndex = 9;
            this.musicOn_lbl.Text = "Music: ON";
            this.musicOn_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musicOn_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // musicOff_lbl
            // 
            this.musicOff_lbl.AutoSize = true;
            this.musicOff_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicOff_lbl.Location = new System.Drawing.Point(947, 12);
            this.musicOff_lbl.Name = "musicOff_lbl";
            this.musicOff_lbl.Size = new System.Drawing.Size(109, 24);
            this.musicOff_lbl.TabIndex = 8;
            this.musicOff_lbl.Text = "Music: OFF";
            this.musicOff_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musicOff_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 590);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pause_Click);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox racket;
        private OvalPictureBox ball;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label pause_lbl;
        private System.Windows.Forms.Label musicOff_lbl;
        private System.Windows.Forms.Label musicOn_lbl;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitButton_lbl;
        private System.Windows.Forms.Button musicButton_lbl;
        private System.Windows.Forms.Button resumeButton_lbl;
        private System.Windows.Forms.Button restartButton_lbl;
        private System.Windows.Forms.Label gameover_lbl;
    }
}
