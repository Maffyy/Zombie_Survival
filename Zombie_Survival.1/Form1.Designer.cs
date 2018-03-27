namespace Zombie_Survival._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.Screen = new System.Windows.Forms.Panel();
            this.kills = new System.Windows.Forms.Label();
            this.enemies = new System.Windows.Forms.Label();
            this.Deaths = new System.Windows.Forms.Label();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.White;
            this.Screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Screen.Controls.Add(this.kills);
            this.Screen.Controls.Add(this.enemies);
            this.Screen.Controls.Add(this.Deaths);
            this.Screen.Controls.Add(this.bullet);
            this.Screen.Controls.Add(this.hero);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(650, 650);
            this.Screen.TabIndex = 0;
            // 
            // kills
            // 
            this.kills.AutoSize = true;
            this.kills.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kills.ForeColor = System.Drawing.SystemColors.MenuText;
            this.kills.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.kills.Location = new System.Drawing.Point(100, 21);
            this.kills.Name = "kills";
            this.kills.Size = new System.Drawing.Size(61, 18);
            this.kills.TabIndex = 7;
            this.kills.Text = "Kills: 0";
            this.kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemies
            // 
            this.enemies.AutoSize = true;
            this.enemies.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemies.ForeColor = System.Drawing.SystemColors.MenuText;
            this.enemies.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enemies.Location = new System.Drawing.Point(445, 21);
            this.enemies.Name = "enemies";
            this.enemies.Size = new System.Drawing.Size(175, 18);
            this.enemies.TabIndex = 5;
            this.enemies.Text = "Number of enemies:  1";
            // 
            // Deaths
            // 
            this.Deaths.AutoSize = true;
            this.Deaths.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deaths.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Deaths.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Deaths.Location = new System.Drawing.Point(12, 21);
            this.Deaths.Name = "Deaths";
            this.Deaths.Size = new System.Drawing.Size(82, 18);
            this.Deaths.TabIndex = 4;
            this.Deaths.Text = "Deaths:  0";
            this.Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bullet.Location = new System.Drawing.Point(176, 437);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(29, 23);
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            this.hero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hero.Image = ((System.Drawing.Image)(resources.GetObject("hero.Image")));
            this.hero.Location = new System.Drawing.Point(327, 235);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(40, 40);
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.Controls.Add(this.Screen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Label enemies;
        private System.Windows.Forms.Label Deaths;
        private System.Windows.Forms.Label kills;
    }
}

