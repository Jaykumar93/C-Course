using System.Numerics;
using ZombieShooting.Properties;
namespace ZombieShooting
{
    public partial class Form1 : Form
    {
        bool goup;
        bool godown; // this boolean will be used for the player to go down the screen
        bool goleft; // this boolean will be used for the player to go left to the screen
        bool goright; // this boolean will be used for the player to right to the screen
        string facing = "up"; // this string is called facing and it will be used to guide the bullets
        double playerHealth = 100;
        int speed = 10;
        int ammo = 10; // this integer will hold the number of ammo the player has start of the game
        int zombieSpeed = 3; // this integer will hold the speed which the zombies move in the game
        int score = 0; // this integer will hold the score the player achieved through the game
        bool gameOver = false; // this boolean is false in the beginning and it will be used when the game is finished
        Random rnd = new Random(); // this is an instance of the random class we will use this to create a random number for this game
        int protectionCount = 100;

        bool isShielded = false;
        List<PictureBox> zombiesList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;
            if (e.KeyCode == Keys.Left)
            {

                goleft = true;
                facing = "left";
                Player.Image = Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right";
                Player.Image = Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                facing = "up";
                goup = true;
                Player.Image = Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                facing = "down";
                godown = true;
                Player.Image = Resources.down;
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return;
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }

            }

            if (playerHealth < 20 && e.KeyCode == Keys.Space)
            {
                DropHealth();
            }
            if (playerHealth < 35 && e.KeyCode == Keys.Space)
            {
                DropShield();
            }


        }

        private void ShootBullet(string direct)
        {
            Bullet shoot = new Bullet();
            shoot.direction = direct;
            shoot.bulletLeft = Player.Left + (Player.Width / 2);
            shoot.bulletTop = Player.Top + (Player.Height / 2);
            shoot.mkBullet(this);
        }

        private void makeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rnd.Next(0, 900);
            zombie.Top = rnd.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombie);
            Player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox(); 
            ammo.Image = Properties.Resources.ammo_Image; 
            ammo.SizeMode = PictureBoxSizeMode.AutoSize; 
            ammo.Left = rnd.Next(10, 890);
            ammo.Top = rnd.Next(50, 600); 
            ammo.Tag = "ammo"; 
            this.Controls.Add(ammo); 
            ammo.BringToFront(); 
            Player.BringToFront(); 
        }


        private void DropHealth()
        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.health;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Left = rnd.Next(10, 890);
            health.Top = rnd.Next(50, 600);
            health.Tag = "health";
            this.Controls.Add(health);
            health.BringToFront();
            Player.BringToFront();
        }
        private void shieldActivated()
        {
            isShielded = true;
            shieldBox.Image = Resources.shield;
            shieldBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void DropShield()
        {
            PictureBox shield = new PictureBox();
            shield.Image = Properties.Resources.shield;
            shield.SizeMode = PictureBoxSizeMode.AutoSize;
            shield.Left = rnd.Next(10, 890);
            shield.Top = rnd.Next(50, 600);
            shield.Tag = "shield";
            this.Controls.Add(shield);
            shield.BringToFront();
            Player.BringToFront();
        }
            
        private void gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1) // if player health is greater than 1
            {
                HealthBar.Value = Convert.ToInt32(playerHealth); // assign the progress bar to the player health integer
            }
            else
            {
                // if the player health is below 1
                Player.Image = Resources.dead; // show the player dead image
                timer2.Stop(); // stop the timer
                gameOver = true; // change game over to true
            }
            label1.Text = "   Ammo:  " + ammo; // show the ammo amount on label 1
            label2.Text = "Kills: " + score; // show the total kills on the score
            // if the player health is less than 20
            if (playerHealth < 20)
            {
                HealthBar.ForeColor = Color.Red; // change the progress bar colour to red. 
            }
            if (goleft && Player.Left > 0)
            {
                Player.Left -= speed;
                // if moving left is true AND pacman is 1 pixel more from the left 
                // then move the player to the LEFT
            }
            if (goright && Player.Left + Player.Width < 930)
            {
                Player.Left += speed;
                // if moving RIGHT is true AND player left + player width is less than 930 pixels
                // then move the player to the RIGHT
            }
            if (goup && Player.Top > 60)
            {
                Player.Top -= speed;
                // if moving TOP is true AND player is 60 pixel more from the top 
                // then move the player to the UP
            }
            if (godown && Player.Top + Player.Height < 700)
            {
                Player.Top += speed;
                // if moving DOWN is true AND player top + player height is less than 700 pixels
                // then move the player to the DOWN
            }
            // run the first for each loop below
            // X is a control and we will search for all controls in this loop
            foreach (Control x in this.Controls)
            {
                // if the X is a picture box and X has a tag AMMO
                if (x is PictureBox && x.Tag == "ammo")
                {
                    // check is X in hitting the player picture box
                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        // once the player picks up the ammo
                        this.Controls.Remove(((PictureBox)x)); // remove the ammo picture box
                        ((PictureBox)x).Dispose(); // dispose the picture box completely from the program
                        ammo += 5; // add 5 ammo to the integer
                    }
                }

                if (x is PictureBox && x.Tag == "health")
                {
                    // check is X in hitting the player picture box
                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        // once the player picks up the ammo
                        this.Controls.Remove(((PictureBox)x)); // remove the ammo picture box
                        ((PictureBox)x).Dispose(); // dispose the picture box completely from the program
                        playerHealth += 15; // add 15 health  to the integer
                    }
                }
                if (x is PictureBox && x.Tag == "shield")
                {
                    // check is X in hitting the player picture box
                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        // once the player picks up the ammo
                        this.Controls.Remove(((PictureBox)x)); // remove the ammo picture box
                        ((PictureBox)x).Dispose(); // dispose the picture box completely from the program
                        shieldActivated();      
                    }
                }

                // if the bullets hits the 4 borders of the game
                // if x is a picture box and x has the tag of bullet
                if (x is PictureBox && x.Tag == "bullet")
                {
                    // if the bullet is less the 1 pixel to the left
                    // if the bullet is more then 930 pixels to the right
                    // if the bullet is 10 pixels from the top
                    // if the bullet is 700 pixels to the buttom
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x)); // remove the bullet from the display
                        ((PictureBox)x).Dispose(); // dispose the bullet from the program
                    }
                }
                // below is the if statement which will be checking if the player hits a zombie
                if (x is PictureBox && x.Tag == "zombie")
                {
                    // below is the if statament thats checking the bounds of the player and the zombie
                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        if (isShielded && protectionCount > 0)
                        {
                            protectionCount--;
                        }
                        else if (isShielded && protectionCount == 0)
                        {
                            isShielded = false;
                            protectionCount = 100;
                            shieldBox.Image = null;
                        }
                        else
                            playerHealth -= 0.50; // if the zombie hits the player then we decrease the health by 1
                    }   
                    
                    //move zombie towards the player picture box
                    if (((PictureBox)x).Left > Player.Left)
                    {
                        ((PictureBox)x).Left -= zombieSpeed; // move zombie towards the left of the player
                        ((PictureBox)x).Image = Properties.Resources.zleft; // change the zombie image to the left
                    }
                    if (((PictureBox)x).Top > Player.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed; // move zombie upwards towards the players top
                        ((PictureBox)x).Image = Properties.Resources.zup; // change the zombie picture to the top pointing image
                    }
                    if (((PictureBox)x).Left < Player.Left)
                    {
                        ((PictureBox)x).Left += zombieSpeed; // move zombie towards the right of the player
                        ((PictureBox)x).Image = Properties.Resources.zright; // change the image to the right image
                    }
                    if (((PictureBox)x).Top < Player.Top)
                    {
                        ((PictureBox)x).Top += zombieSpeed; // move the zombie towards the bottom of the player
                        ((PictureBox)x).Image = Properties.Resources.zdown; // change the image to the down zombie
                    }
                }
                // below is the second for loop, this is nexted inside the first one
                // the bullet and zombie needs to be different than each other
                // then we can use that to determine if the hit each other
                foreach (Control j in this.Controls)
                {
                    // below is the selection thats identifying the bullet and zombie
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                    {
                        // below is the if statement thats checking if bullet hits the zombie
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++; // increase the kill score by 1 
                            this.Controls.Remove(j); // this will remove the bullet from the screen
                            j.Dispose(); // this will dispose the bullet all together from the program
                            this.Controls.Remove(x); // this will remove the zombie from the screen
                            x.Dispose(); // this will dispose the zombie from the program
                            makeZombies(); // this function will invoke the make zombies function to add another zombie to the game
                        }
                    }
                }
            }
        }
    }
}
