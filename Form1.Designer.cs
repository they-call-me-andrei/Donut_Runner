namespace game3
{
    partial class game3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game3));
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.floor = new System.Windows.Forms.PictureBox();
            this.spikes = new System.Windows.Forms.PictureBox();
            this.upwall = new System.Windows.Forms.PictureBox();
            this.healthbar = new System.Windows.Forms.PictureBox();
            this.heart = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.donut1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hole = new System.Windows.Forms.PictureBox();
            this.donut2 = new System.Windows.Forms.PictureBox();
            this.menu_button = new System.Windows.Forms.Button();
            this.menupanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.Button();
            this.HowToPlay_but = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dialog = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.Panel();
            this.hard = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upwall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut2)).BeginInit();
            this.menupanel.SuspendLayout();
            this.dialog.SuspendLayout();
            this.levels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(834, 286);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 114);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // floor
            // 
            this.floor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("floor.BackgroundImage")));
            this.floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.floor.Location = new System.Drawing.Point(-2000, 391);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(3000, 500);
            this.floor.TabIndex = 1;
            this.floor.TabStop = false;
            // 
            // spikes
            // 
            this.spikes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spikes.BackgroundImage")));
            this.spikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spikes.Location = new System.Drawing.Point(87, 336);
            this.spikes.Name = "spikes";
            this.spikes.Size = new System.Drawing.Size(154, 64);
            this.spikes.TabIndex = 2;
            this.spikes.TabStop = false;
            // 
            // upwall
            // 
            this.upwall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upwall.BackgroundImage")));
            this.upwall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.upwall.Location = new System.Drawing.Point(110, 164);
            this.upwall.Name = "upwall";
            this.upwall.Size = new System.Drawing.Size(242, 40);
            this.upwall.TabIndex = 3;
            this.upwall.TabStop = false;
            // 
            // healthbar
            // 
            this.healthbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("healthbar.BackgroundImage")));
            this.healthbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.healthbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthbar.Location = new System.Drawing.Point(358, 29);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(320, 38);
            this.healthbar.TabIndex = 5;
            this.healthbar.TabStop = false;
            // 
            // heart
            // 
            this.heart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart.BackgroundImage")));
            this.heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart.Location = new System.Drawing.Point(298, 29);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(54, 38);
            this.heart.TabIndex = 6;
            this.heart.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // donut1
            // 
            this.donut1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("donut1.BackgroundImage")));
            this.donut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donut1.Location = new System.Drawing.Point(145, 105);
            this.donut1.Name = "donut1";
            this.donut1.Size = new System.Drawing.Size(54, 53);
            this.donut1.TabIndex = 8;
            this.donut1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(358, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 38);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // hole
            // 
            this.hole.Location = new System.Drawing.Point(310, 391);
            this.hole.Name = "hole";
            this.hole.Size = new System.Drawing.Size(202, 103);
            this.hole.TabIndex = 10;
            this.hole.TabStop = false;
            // 
            // donut2
            // 
            this.donut2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("donut2.BackgroundImage")));
            this.donut2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donut2.Location = new System.Drawing.Point(551, 270);
            this.donut2.Name = "donut2";
            this.donut2.Size = new System.Drawing.Size(54, 53);
            this.donut2.TabIndex = 11;
            this.donut2.TabStop = false;
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_button.Location = new System.Drawing.Point(-20, -6);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(214, 42);
            this.menu_button.TabIndex = 12;
            this.menu_button.Text = "Menu";
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.menupanel.Controls.Add(this.button2);
            this.menupanel.Controls.Add(this.difficulty);
            this.menupanel.Controls.Add(this.HowToPlay_but);
            this.menupanel.Controls.Add(this.menu_button);
            this.menupanel.Location = new System.Drawing.Point(64, 35);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(177, 32);
            this.menupanel.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(23, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "About author";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // difficulty
            // 
            this.difficulty.BackColor = System.Drawing.Color.DodgerBlue;
            this.difficulty.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficulty.ForeColor = System.Drawing.Color.Black;
            this.difficulty.Location = new System.Drawing.Point(23, 133);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(124, 39);
            this.difficulty.TabIndex = 14;
            this.difficulty.Text = "Difficulty";
            this.difficulty.UseVisualStyleBackColor = false;
            this.difficulty.Click += new System.EventHandler(this.difficulty_Click);
            // 
            // HowToPlay_but
            // 
            this.HowToPlay_but.BackColor = System.Drawing.Color.DodgerBlue;
            this.HowToPlay_but.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HowToPlay_but.ForeColor = System.Drawing.Color.Black;
            this.HowToPlay_but.Location = new System.Drawing.Point(23, 59);
            this.HowToPlay_but.Name = "HowToPlay_but";
            this.HowToPlay_but.Size = new System.Drawing.Size(124, 39);
            this.HowToPlay_but.TabIndex = 13;
            this.HowToPlay_but.Text = "How to play";
            this.HowToPlay_but.UseVisualStyleBackColor = false;
            this.HowToPlay_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(169, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rules ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(102, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "- Dodge the traps !\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(28, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Every trap you hit will lower your health state with 10% !";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(102, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "- Collect the donuts !";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(49, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 34);
            this.label6.TabIndex = 19;
            this.label6.Text = "      Donuts are randomly placed on the map.\r\nCollecting 20 donuts will have you " +
    "win the game !";
            // 
            // dialog
            // 
            this.dialog.BackColor = System.Drawing.Color.Black;
            this.dialog.Controls.Add(this.label9);
            this.dialog.Controls.Add(this.label8);
            this.dialog.Controls.Add(this.label7);
            this.dialog.Controls.Add(this.label2);
            this.dialog.Controls.Add(this.label6);
            this.dialog.Controls.Add(this.label3);
            this.dialog.Controls.Add(this.label5);
            this.dialog.Controls.Add(this.label4);
            this.dialog.Location = new System.Drawing.Point(969, 46);
            this.dialog.Name = "dialog";
            this.dialog.Size = new System.Drawing.Size(405, 238);
            this.dialog.TabIndex = 20;
            this.dialog.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(141, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "- Have fun !";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(22, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(358, 51);
            this.label8.TabIndex = 21;
            this.label8.Text = "Traps are interesting, but how about holes in the floor ?\r\n    Every jump that ca" +
    "n lead you falling in the hole will\r\n                   lower your health state " +
    "with 10% !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(81, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "- Watch out for the holes !";
            // 
            // levels
            // 
            this.levels.BackColor = System.Drawing.Color.Black;
            this.levels.Controls.Add(this.hard);
            this.levels.Controls.Add(this.normal);
            this.levels.Controls.Add(this.easy);
            this.levels.Location = new System.Drawing.Point(947, 224);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(405, 238);
            this.levels.TabIndex = 21;
            this.levels.Visible = false;
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Red;
            this.hard.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hard.ForeColor = System.Drawing.Color.Black;
            this.hard.Location = new System.Drawing.Point(79, 161);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(242, 39);
            this.hard.TabIndex = 2;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.Color.Yellow;
            this.normal.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.normal.ForeColor = System.Drawing.Color.Black;
            this.normal.Location = new System.Drawing.Point(120, 83);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(168, 39);
            this.normal.TabIndex = 1;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = false;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Lime;
            this.easy.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.easy.Location = new System.Drawing.Point(151, 9);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(99, 39);
            this.easy.TabIndex = 0;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(862, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 32);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.dialog);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.donut2);
            this.Controls.Add(this.hole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.donut1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heart);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.upwall);
            this.Controls.Add(this.spikes);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.player);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(452, 286);
            this.Name = "game3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.game3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upwall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donut2)).EndInit();
            this.menupanel.ResumeLayout(false);
            this.dialog.ResumeLayout(false);
            this.dialog.PerformLayout();
            this.levels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox spikes;
        private System.Windows.Forms.PictureBox upwall;
        private System.Windows.Forms.PictureBox healthbar;
        private System.Windows.Forms.PictureBox heart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox donut1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hole;
        private System.Windows.Forms.PictureBox donut2;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button HowToPlay_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel dialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button difficulty;
        private System.Windows.Forms.Panel levels;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button normal;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

