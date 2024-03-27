namespace ZombieShooting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            HealthBar = new ProgressBar();
            Player = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            shieldBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shieldBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 27);
            label1.TabIndex = 0;
            label1.Text = "Ammo : 0 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 27);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 1;
            label2.Text = "Kills : 0 ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 54);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 2;
            label3.Text = "Health :";
            // 
            // HealthBar
            // 
            HealthBar.Location = new Point(86, 57);
            HealthBar.Name = "HealthBar";
            HealthBar.Size = new Size(150, 20);
            HealthBar.TabIndex = 3;
            HealthBar.Value = 50;
            // 
            // Player
            // 
            Player.Image = Properties.Resources.up;
            Player.Location = new Point(416, 287);
            Player.Name = "Player";
            Player.Size = new Size(71, 100);
            Player.SizeMode = PictureBoxSizeMode.AutoSize;
            Player.TabIndex = 4;
            Player.TabStop = false;
            Player.Tag = "Players";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zdown;
            pictureBox1.Location = new Point(108, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "zombie";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.zup;
            pictureBox3.Location = new Point(331, 493);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "zombie";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zleft;
            pictureBox2.Location = new Point(725, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "zombie";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 20;
            timer2.Tick += gameEngine;
            // 
            // shieldBox
            // 
            shieldBox.Location = new Point(812, 12);
            shieldBox.Name = "shieldBox";
            shieldBox.Size = new Size(100, 50);
            shieldBox.TabIndex = 9;
            shieldBox.TabStop = false;
            shieldBox.Tag = "shieldBox";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(924, 681);
            Controls.Add(shieldBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(Player);
            Controls.Add(HealthBar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Zombie Shooting Game";
            KeyDown += Keyisdown;
            KeyUp += Keyisup;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)shieldBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar HealthBar;
        private PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private PictureBox shieldBox;
    }
}
