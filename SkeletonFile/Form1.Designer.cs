namespace Assignment2GameApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			player = new PictureBox();
			platform2 = new PictureBox();
			obstacle = new PictureBox();
			enemy = new PictureBox();
			labelTime = new Label();
			labelScore = new Label();
			timer = new System.Windows.Forms.Timer(components);
			coin2 = new PictureBox();
			coin4 = new PictureBox();
			coin3 = new PictureBox();
			coin1 = new PictureBox();
			platform1 = new PictureBox();
			exitCoin = new PictureBox();
			enemy2 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)player).BeginInit();
			((System.ComponentModel.ISupportInitialize)platform2).BeginInit();
			((System.ComponentModel.ISupportInitialize)obstacle).BeginInit();
			((System.ComponentModel.ISupportInitialize)enemy).BeginInit();
			((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
			((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
			((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
			((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
			((System.ComponentModel.ISupportInitialize)platform1).BeginInit();
			((System.ComponentModel.ISupportInitialize)exitCoin).BeginInit();
			((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
			SuspendLayout();
			// 
			// player
			// 
			player.BackColor = Color.Transparent;
			player.Image = (Image)resources.GetObject("player.Image");
			player.Location = new Point(26, 253);
			player.Name = "player";
			player.Size = new Size(58, 54);
			player.TabIndex = 0;
			player.TabStop = false;
			// 
			// platform2
			// 
			platform2.BackColor = Color.Transparent;
			platform2.Image = (Image)resources.GetObject("platform2.Image");
			platform2.Location = new Point(293, 154);
			platform2.Name = "platform2";
			platform2.Size = new Size(194, 44);
			platform2.SizeMode = PictureBoxSizeMode.StretchImage;
			platform2.TabIndex = 1;
			platform2.TabStop = false;
			// 
			// obstacle
			// 
			obstacle.BackColor = Color.Transparent;
			obstacle.Image = (Image)resources.GetObject("obstacle.Image");
			obstacle.Location = new Point(394, 237);
			obstacle.Name = "obstacle";
			obstacle.Size = new Size(93, 76);
			obstacle.TabIndex = 3;
			obstacle.TabStop = false;
			// 
			// enemy
			// 
			enemy.BackColor = Color.Transparent;
			enemy.Image = (Image)resources.GetObject("enemy.Image");
			enemy.Location = new Point(660, 237);
			enemy.Name = "enemy";
			enemy.Size = new Size(51, 70);
			enemy.TabIndex = 5;
			enemy.TabStop = false;
			// 
			// labelTime
			// 
			labelTime.AutoSize = true;
			labelTime.BackColor = Color.Transparent;
			labelTime.Location = new Point(793, 27);
			labelTime.Name = "labelTime";
			labelTime.Size = new Size(127, 25);
			labelTime.TabIndex = 9;
			labelTime.Text = "Running time: ";
			// 
			// labelScore
			// 
			labelScore.AutoSize = true;
			labelScore.BackColor = Color.Transparent;
			labelScore.Location = new Point(791, 52);
			labelScore.Name = "labelScore";
			labelScore.Size = new Size(129, 50);
			labelScore.TabIndex = 10;
			labelScore.Text = "Running score:\r\n ";
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Interval = 20;
			timer.Tick += timer_Tick;
			// 
			// coin2
			// 
			coin2.BackColor = Color.Transparent;
			coin2.Image = (Image)resources.GetObject("coin2.Image");
			coin2.Location = new Point(437, 94);
			coin2.Name = "coin2";
			coin2.Size = new Size(36, 31);
			coin2.TabIndex = 12;
			coin2.TabStop = false;
			// 
			// coin4
			// 
			coin4.BackColor = Color.Transparent;
			coin4.Image = (Image)resources.GetObject("coin4.Image");
			coin4.Location = new Point(782, 274);
			coin4.Name = "coin4";
			coin4.Size = new Size(36, 31);
			coin4.TabIndex = 15;
			coin4.TabStop = false;
			// 
			// coin3
			// 
			coin3.BackColor = Color.Transparent;
			coin3.Image = (Image)resources.GetObject("coin3.Image");
			coin3.Location = new Point(549, 274);
			coin3.Name = "coin3";
			coin3.Size = new Size(36, 31);
			coin3.TabIndex = 16;
			coin3.TabStop = false;
			// 
			// coin1
			// 
			coin1.BackColor = Color.Transparent;
			coin1.Image = (Image)resources.GetObject("coin1.Image");
			coin1.Location = new Point(198, 167);
			coin1.Name = "coin1";
			coin1.Size = new Size(36, 31);
			coin1.TabIndex = 17;
			coin1.TabStop = false;
			// 
			// platform1
			// 
			platform1.BackColor = Color.Transparent;
			platform1.Image = (Image)resources.GetObject("platform1.Image");
			platform1.Location = new Point(117, 204);
			platform1.Name = "platform1";
			platform1.Size = new Size(169, 40);
			platform1.TabIndex = 18;
			platform1.TabStop = false;
			// 
			// exitCoin
			// 
			exitCoin.BackColor = Color.Transparent;
			exitCoin.Image = (Image)resources.GetObject("exitCoin.Image");
			exitCoin.Location = new Point(922, 259);
			exitCoin.Name = "exitCoin";
			exitCoin.Size = new Size(61, 49);
			exitCoin.SizeMode = PictureBoxSizeMode.StretchImage;
			exitCoin.TabIndex = 19;
			exitCoin.TabStop = false;
			exitCoin.Click += exitCoin_Click;
			// 
			// enemy2
			// 
			enemy2.BackColor = Color.Transparent;
			enemy2.Image = (Image)resources.GetObject("enemy2.Image");
			enemy2.Location = new Point(322, 94);
			enemy2.Name = "enemy2";
			enemy2.Size = new Size(51, 70);
			enemy2.TabIndex = 20;
			enemy2.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(980, 316);
			Controls.Add(enemy2);
			Controls.Add(enemy);
			Controls.Add(exitCoin);
			Controls.Add(platform1);
			Controls.Add(coin1);
			Controls.Add(coin3);
			Controls.Add(coin4);
			Controls.Add(coin2);
			Controls.Add(labelScore);
			Controls.Add(labelTime);
			Controls.Add(obstacle);
			Controls.Add(platform2);
			Controls.Add(player);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			KeyDown += Form1_KeyDown;
			KeyPress += Form1_KeyPress;
			KeyUp += Form1_KeyUp;
			((System.ComponentModel.ISupportInitialize)player).EndInit();
			((System.ComponentModel.ISupportInitialize)platform2).EndInit();
			((System.ComponentModel.ISupportInitialize)obstacle).EndInit();
			((System.ComponentModel.ISupportInitialize)enemy).EndInit();
			((System.ComponentModel.ISupportInitialize)coin2).EndInit();
			((System.ComponentModel.ISupportInitialize)coin4).EndInit();
			((System.ComponentModel.ISupportInitialize)coin3).EndInit();
			((System.ComponentModel.ISupportInitialize)coin1).EndInit();
			((System.ComponentModel.ISupportInitialize)platform1).EndInit();
			((System.ComponentModel.ISupportInitialize)exitCoin).EndInit();
			((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox player;
		private PictureBox platform2;
		private PictureBox obstacle;
		private PictureBox enemy;
		private Label labelTime;
		private Label labelScore;
		private System.Windows.Forms.Timer timer;
		private PictureBox coin2;
		private PictureBox coin4;
		private PictureBox coin3;
		private PictureBox coin1;
		private PictureBox platform1;
		private PictureBox exitCoin;
		private PictureBox enemy2;
	}
}
