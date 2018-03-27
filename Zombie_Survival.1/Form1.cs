using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Zombie_Survival._1
{

    public partial class Form1 : Form
    {

        bool right, left, up, down,fire;
        int heroX, heroY, heroDir, bulletDir, bulletX, bulletY, rndInit, reload;
        PictureBox[] zombies = new PictureBox[20];
        int numberZombies = 0;
        int num_deaths = 0; int num_kill = 0; int num_enemies = 1;
        private static SoundPlayer shot = new SoundPlayer("gunshot.wav");
        private static SoundPlayer pain = new SoundPlayer("pain.wav");
        Image heroUp, heroDown, heroLeft, heroRight, zombieUp, zombieDown, zombieRight, zombieLeft,
            bulletUp, bulletDown, bulletLeft, bulletRight;

        const byte North = 1, South = 2, West = 3, East = 4;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            SetUpGame();   
        }

        public void SetUpGame()
        {
            heroDir = South;
            generateZombies();
            reload = 0;
            heroUp = Image.FromFile("up.png");
            heroDown = Image.FromFile("down.png");
            heroLeft = Image.FromFile("left.png");
            heroRight = Image.FromFile("right.png");

            zombieUp = Image.FromFile("zombie_up.png");
            zombieDown = Image.FromFile("zombie_down.png");
            zombieLeft = Image.FromFile("zombie_left.png");
            zombieRight = Image.FromFile("zombie_right.png");

            bulletUp = Image.FromFile("bullet_up.png");
            bulletDown = Image.FromFile("bullet_down.png");
            bulletLeft = Image.FromFile("bullet_left.png");
            bulletRight = Image.FromFile("bullet_right.png");
        }
        private void generateZombies()
        { 
            int i = numberZombies;
           
            zombies[i] = new PictureBox();
            zombies[i].Size = new Size(40, 40);
            zombies[i].Name = "child" + i;
            zombies[i].Image = Image.FromFile("zombie_left.png");
            zombies[i].Location = new Point(Screen.Width + zombies[i].Width, rndInit);
            zombies[i].BackColor = Color.Transparent;
            zombies[i].BackgroundImageLayout = ImageLayout.Center;
            Screen.Controls.Add(zombies[i]);
            
            enemies.Text = "Number of enemies: " + num_enemies;
            num_enemies++;
        }
      
        private void ZombiesMoving()
        {
            for (int i=numberZombies; i>=0; i--)
            { 
                if (hero.Location.X + hero.Width <= zombies[i].Location.X)
                {
                    zombies[i].Left -= 1;
                    zombies[i].Image = zombieLeft;
                  
                }
                if (heroX >= zombies[i].Location.X + zombies[i].Width)
                {
                    zombies[i].Left += 1;
                    zombies[i].Image = zombieRight;

                }
                if (heroY + hero.Height <= zombies[i].Location.Y)
                {
                    zombies[i].Top -= 1;
                    zombies[i].Image = zombieUp;
                }
                if (heroY >= zombies[i].Location.Y + zombies[i].Height)
                {
                    zombies[i].Top += 1;
                    zombies[i].Image = zombieDown;
                }
            }
        }

        private void clock_Tick(object sender, EventArgs e)            
        {
            reload++;
            heroMoves();
            FireBullet();
            DetectCollissions();
            ZombiesMoving();
        }
        private void heroMoves()
        {
            heroX = hero.Location.X;
            heroY = hero.Location.Y;
            if (left == true)
            {
                if (heroX > 0)
                    hero.Left -= 5;
            }

            if (right == true)
            {
                if (heroX + hero.Width < Screen.Width)
                    hero.Left += 5;
            }
            if (up == true)
            {
                if (heroY > 0)
                    hero.Top -= 5;

            }
            if (down == true)
            {
                if (heroY + hero.Height < Screen.Height)
                    hero.Top += 5;
            }
        }
        private bool CheckCollisions(PictureBox object1, PictureBox object2)
        {
             if (object1.Bounds.IntersectsWith(object2.Bounds)) { return true; }
             else { return false; }  
        }
        private void DetectCollissions()
        {
            bulletX = bullet.Location.X;
            bulletY = bullet.Location.Y;

            for (int i = numberZombies; i >= 0; i--)
            {
                if (CheckCollisions(hero, zombies[i]))
                {
                    pain.Play();
                    num_deaths++;
                    Deaths.Text = "Deaths:" + num_deaths;
                    if (num_deaths == 3)
                    {
                        clock.Stop();
                        MessageBox.Show("Game Over!","Zombie Survival",MessageBoxButtons.OK);
                        Hide();
                        
                        Form2 menu = new Form2();
                        menu.ShowDialog();

                        zombies[i].Location = new Point(Screen.Width + zombies[i].Width, rndInit);
                        rndInit = rnd.Next(0, 400);
                        if (numberZombies < 3)
                        {
                            numberZombies++;
                            generateZombies();
                        }

                    }
                }
                if (CheckCollisions(bullet,zombies[i]))
                {
                    num_kill++;
                    kills.Text = "Kills: " + num_kill;

                    bullet.Location = new Point(heroX, heroY);
                    bullet.Visible = false;
                    fire = false;
                    zombies[i].Location = new Point(Screen.Width + zombies[i].Width, rndInit);
                    rndInit = rnd.Next(0, 400);
                    if (numberZombies < 6)
                    {
                        numberZombies++;
                        generateZombies();
                    }
                }
            }
        }
       

        private void FireBullet()
        {
            bulletX = bullet.Location.X;
            bulletY = bullet.Location.Y;
            
            if ((bulletX <= 0) || (bulletX >= Screen.Width) || (bulletY <= 0) || (bulletY >= Screen.Height))
            {

                fire = false;
                bullet.Visible = false;  
            }
            if ( fire )
            {
                
                bullet.Visible = true;
                if (bulletDir == North)
                {
                    bullet.Image = bulletUp;
                    bullet.Top -= 20;
                }
                if (bulletDir == South)
                {
                    bullet.Image = bulletDown;
                    bullet.Top += 20;
                }
                if (bulletDir == West)
                {
                    bullet.Image = bulletLeft;
                    bullet.Left -= 20;
                }
                if (bulletDir == East)
                {
                    bullet.Image = bulletRight;
                    bullet.Left += 20;
                }
            }   
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                hero.Image = heroRight;
                heroDir = East;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                hero.Image = heroLeft;
               
                heroDir = West;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = true;
                hero.Image = heroUp;
               
                heroDir = North;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
                hero.Image =  heroDown;
                heroDir = South;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (reload > 30)
                {
                    bullet.Location = new Point(heroX, heroY);
                  
                    shot.Play();
                    getBulletDirection();
                    fire = true;
                    reload = 0;
                }
            }     
        }
        private void getBulletDirection()
        {
            if (heroDir == North) 
            {
                bulletDir = North;  
            }
            else if (heroDir == South)
            {
                bulletDir = South;
         
            }
            else if (heroDir == East)
            {
                bulletDir = East;
           
            }
            else if (heroDir == West)
            {
                bulletDir = West;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Up) { up = false; }
            if (e.KeyCode == Keys.Down) { down = false; } 
        }
        
    }
}
