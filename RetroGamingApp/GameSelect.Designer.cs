namespace RetroGamingApp
{
    partial class GameSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSelect));
            this.GameSelectMenus = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retroGamingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHighScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pongButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GameSelectMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameSelectMenus
            // 
            this.GameSelectMenus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameSelectMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.viewHighScoresToolStripMenuItem});
            this.GameSelectMenus.Location = new System.Drawing.Point(0, 0);
            this.GameSelectMenus.Name = "GameSelectMenus";
            this.GameSelectMenus.Size = new System.Drawing.Size(800, 24);
            this.GameSelectMenus.TabIndex = 0;
            this.GameSelectMenus.Text = "GameSelectMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailsToolStripMenuItem,
            this.editDetailsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // editDetailsToolStripMenuItem
            // 
            this.editDetailsToolStripMenuItem.Name = "editDetailsToolStripMenuItem";
            this.editDetailsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editDetailsToolStripMenuItem.Text = "Edit Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem,
            this.retroGamingHistoryToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // retroGamingHistoryToolStripMenuItem
            // 
            this.retroGamingHistoryToolStripMenuItem.Name = "retroGamingHistoryToolStripMenuItem";
            this.retroGamingHistoryToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.retroGamingHistoryToolStripMenuItem.Text = "Retro Gaming History";
            // 
            // viewHighScoresToolStripMenuItem
            // 
            this.viewHighScoresToolStripMenuItem.Name = "viewHighScoresToolStripMenuItem";
            this.viewHighScoresToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.viewHighScoresToolStripMenuItem.Text = "View High Scores";
            // 
            // pongButton
            // 
            this.pongButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pongButton.Location = new System.Drawing.Point(12, 37);
            this.pongButton.Name = "pongButton";
            this.pongButton.Size = new System.Drawing.Size(228, 188);
            this.pongButton.TabIndex = 1;
            this.pongButton.Text = "Pong!";
            this.pongButton.UseVisualStyleBackColor = true;
            this.pongButton.Click += new System.EventHandler(this.pongButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(286, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 188);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zombies!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RetroGamingApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pongButton);
            this.Controls.Add(this.GameSelectMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GameSelectMenus;
            this.Name = "GameSelect";
            this.Text = "GameSelect";
            this.GameSelectMenus.ResumeLayout(false);
            this.GameSelectMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GameSelectMenus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retroGamingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHighScoresToolStripMenuItem;
        private System.Windows.Forms.Button pongButton;
        private System.Windows.Forms.Button button1;
    }
}