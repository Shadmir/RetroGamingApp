namespace RetroGamingApp
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.startGameLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(12, 186);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 127);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Fuchsia;
            this.cpu.Location = new System.Drawing.Point(897, 230);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 127);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(434, 239);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 27);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Lime;
            this.playerScore.Location = new System.Drawing.Point(105, 9);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(47, 33);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLabel.ForeColor = System.Drawing.Color.Red;
            this.cpuLabel.Location = new System.Drawing.Point(735, 9);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(47, 33);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "00";
            // 
            // startGameLabel
            // 
            this.startGameLabel.AutoSize = true;
            this.startGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameLabel.ForeColor = System.Drawing.Color.White;
            this.startGameLabel.Location = new System.Drawing.Point(367, 202);
            this.startGameLabel.Name = "startGameLabel";
            this.startGameLabel.Size = new System.Drawing.Size(156, 20);
            this.startGameLabel.TabIndex = 5;
            this.startGameLabel.Text = "Press [enter] to start!";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(232, 17);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(450, 19);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Press [G] to switch between 1-Player and 2-Player";
            // 
            // backPanel
            // 
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(987, 711);
            this.backPanel.TabIndex = 7;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.startGameLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pong";
            this.ShowInTaskbar = false;
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label startGameLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel backPanel;
    }
}