namespace Assignment2GameApp
{
    public partial class Form1 : Form
    {
        // jumping variables
        private bool isJumping = false;
        int jumpHeight = 35; // jump height
        int gravity = 7; // gravity effect: fall slowly 
        int groundHeight; // or else it will fall under the screen
        bool isCoinCaptured1 = false;
        bool isCoinCaptured2 = false;
        bool isCoinCaptured3 = false;
        bool isCoinCaptured4 = false;
        bool isExitCoinCaptured = false;
        bool enemyMovingLeft = true;
        bool enemyMovingRight = false;

        bool enemy2MovingLeft = true;
        bool enemy2MovingRight = false;

        int enemySpeed = 3;
        int enemy2Speed = 3;

        int score = 0;


        //right Movement 
        private bool isGoingRight = false;
        //left Movement
        private bool isGoingLeft = false;
        //time related variables 
        private DateTime startTime;
        public Form1()
        {
            InitializeComponent();
            groundHeight = ClientSize.Height - player.Height;
            timer.Start(); // start the timer
            startTime = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }
        private void gameOver(int timeItTook)
        {
            timer.Stop();
            player.Visible = false;
            coin1.Visible = false;
            coin2.Visible = false;
            coin3.Visible = false;
            coin4.Visible = false;
            exitCoin.Visible = false;
            platform1.Visible = false;
            platform2.Visible = false;
            enemy.Visible = false;
            enemy2.Visible = false;
            obstacle.Visible = false;
            isJumping = false;
            isGoingLeft = false;
            isGoingRight = false;
            MessageBox.Show("Game Overr " + "it took you " + timeItTook + "seconds" + "and you gain " + score + "coin");
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //calculation of time elapsing 
            TimeSpan elapsedTime = DateTime.Now - startTime;

            //jumping logic 
            if (isJumping)
            {
                player.Top -= jumpHeight; //move the player up
                jumpHeight -= gravity; // bringing the player downwards slowly under gravity

                //check if player landing on the ground
                if (player.Top >= groundHeight) //check against ground height
                {
                    player.Top = groundHeight; //reset player to the ground
                    isJumping = false; //reset the jumping flag
                    jumpHeight = 35; // reset the jump height for the next jump on the press of Space key again
                }
            }
            else
            {
                if (player.Top < groundHeight) //in all cases where the player is not jumping -> bring him down 
                {
                    player.Top += gravity; // bring the player down under gravity 
                }

            }

            // right movement logic
            if (isGoingRight)
            {
                player.Left += 5;

            }
            // left movement logic 
            if (isGoingLeft)
            {
                player.Left -= 5;
            }

            //check for collision with the platform1 
            if (player.Bounds.IntersectsWith(platform1.Bounds))
            {
                player.Top = platform1.Top - player.Height; //place the player on top of the platform
                isJumping = false; // reset the jumping flag 
                jumpHeight = 35; // reset the jump height for the next jump on the press of Space key again
            }
            //check for collision with the platform2
            if (player.Bounds.IntersectsWith(platform2.Bounds))
            {
                player.Top = platform2.Top - player.Height; //place the player on top of the platform
                isJumping = false; // reset the jumping flag 
                jumpHeight = 35; // reset the jump height for the next jump on the press of Space key again
            }

            //check if the player is falling off the edges of the platform1
            if (player.Top == platform1.Top - player.Height && (player.Left < platform1.Left || player.Right > platform1.Right))
            {
                isJumping = false;
            }
            labelTime.Text = "Time Elapsed: " + elapsedTime.Seconds + "seconds";

            //check if the player is falling off the edges of the platform2
            if (player.Top == platform2.Top - player.Height && (player.Left < platform2.Left || player.Right > platform2.Right))
            {
                isJumping = false;
            }
            labelTime.Text = "Time Elapsed: " + elapsedTime.Seconds + "seconds";

            //check for collison with the coin1
            if (!isCoinCaptured1 && coin1.Bounds.IntersectsWith(player.Bounds))
            {
                isCoinCaptured1 = true;
                coin1.Visible = false;
                score++;
            }
            labelScore.Text = "Coin gain: " + score;

            //check for collison with the coin2
            if (!isCoinCaptured2 && coin2.Bounds.IntersectsWith(player.Bounds))
            {
                isCoinCaptured2 = true;
                coin2.Visible = false;
                score++;
            }
            //check for collison with the coin3
            if (!isCoinCaptured3 && coin3.Bounds.IntersectsWith(player.Bounds))
            {
                isCoinCaptured3 = true;
                coin3.Visible = false;
                score++;
            }
            //check for collison with the coin4
            if (!isCoinCaptured4 && coin4.Bounds.IntersectsWith(player.Bounds))
            {
                isCoinCaptured4 = true;
                coin4.Visible = false;
                score++;
            }

            //check for exit coin capture 
            if (!isExitCoinCaptured && exitCoin.Bounds.IntersectsWith(player.Bounds))
            {
                isExitCoinCaptured = true;
                exitCoin.Visible = false;
                gameOver(elapsedTime.Seconds);
            }

            // Check for collision with the enemy
            if (player.Bounds.IntersectsWith(enemy.Bounds))
            {
                isJumping = false;
                jumpHeight = 35; // reset the jump height for the next jump on the press of Space key again
                gameOver(elapsedTime.Seconds);
            }
            // Check for collision with the enemy2
            if (player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                isJumping = false;
                jumpHeight = 35; // reset the jump height for the next jump on the press of Space key again
                gameOver(elapsedTime.Seconds);
            }

            // Check for collision with the obstacle
            if (player.Bounds.IntersectsWith(obstacle.Bounds))
            {
                gameOver(elapsedTime.Seconds);
            }

            //enemy1 movement logic

            if (enemyMovingLeft && enemy.Location.X > ClientSize.Width / 2)
            {
                enemy.Left = enemy.Location.X - enemySpeed;
            }
            else
            { //enemy has reached the middle of the form on the x-axis
                enemyMovingLeft = false;
                enemyMovingRight = true;

            }

            //enemy changes direction and starts moving right till it reaches the right end of the form boundary
            if (enemyMovingRight && enemy.Location.X < ClientSize.Width - enemy.Width)
            {
                enemy.Left = enemy.Location.X + enemySpeed;
            }
            else
            { //enemy has reached the end of the form, and should change direction to left
                enemyMovingRight = false;
                enemyMovingLeft = true;
            }

            //enemy 2 movement logic

            if (enemy2MovingLeft && enemy2.Location.X > platform2.Left)
            {
                enemy2.Left = enemy2.Location.X - enemy2Speed;
            }
            else
            { //enemy has reached the middle of the form on the x-axis
                enemy2MovingLeft = false;
                enemy2MovingRight = true;

            }

            //enemy changes direction and starts moving right till it reaches the right end of the form boundary
            if (enemy2MovingRight && enemy2.Location.X < platform2.Right - enemy2.Width)
            {
                enemy2.Left = enemy2.Location.X + enemy2Speed;
            }
            else
            { //enemy has reached the end of the form, and should change direction to left
                enemy2MovingRight = false;
                enemy2MovingLeft = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !isGoingLeft) // start moving left
            {
                isGoingLeft = true;
            }
            if (e.KeyCode == Keys.Right && !isGoingRight) // start moving right
            {
                isGoingRight = true;
            }
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left) //stop going left
            {
                isGoingLeft = false;
            }
            if (e.KeyCode == Keys.Right) //stop going right
            {
                isGoingRight = false;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            isJumping = true;
            jumpHeight = 40;
        }

        private void exitCoin_Click(object sender, EventArgs e)
        {

        }
    }
}
