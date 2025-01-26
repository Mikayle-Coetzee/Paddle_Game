using System;
using System.Media;
using System.Windows.Forms;

namespace PROG7311_ICE_1_ST10023767.Forms
{
    public partial class FrmOnePlayer : Form
    {
        //Location Variables
        private int cpuDirection = 5;
        private int ballX = 5;
        private int ballY = 5;

        //Score Variables
        private int playerScore = 0;
        private int cpuScore = 0;

        //Size Variables
        private int bottomBoundary;
        private int centrePoint;
        private int xMidpoint;
        private int yMidpoint;

        // Detection Variables
        bool playerDetectedUp;
        bool playerDetectedDown;

        // Special Keys
        int spaceBarClicked = 0;

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Default constructor
        /// </summary>
        public FrmOnePlayer()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - pbPlayer1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;

            // Use double buffering to reduce flicker.
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            this.UpdateStyles();
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        ///  Play the boing sound file resource.
        /// </summary>
        private void Boing()
        {
            using (var player = new SoundPlayer(Properties.Resources.boing))
            {
                player.Play();
                return;
            }
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Timer for every 20s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrTrack_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);

            // Adjust where the ball is
            pbBall.Top -= ballY;
            pbBall.Left -= ballX;

            // Make the CPU move
            pbPlayer2.Top += cpuDirection;

            // Make CPU better at the game, the higher the playerScore
            if (playerScore > 5)
            {
                pbPlayer2.Top = pbBall.Top + 30;
            }

            // Check if CPU has reached the top or the bottom
            if (pbPlayer2.Top < 0 || pbPlayer2.Top > bottomBoundary)
            {
                cpuDirection = -cpuDirection;
                Boing();
            }

            // Check if the ball has exited the left side of the screen
            if (pbBall.Left < 0)
            {
                //soundEffect.Play();
                pbBall.Left = xMidpoint;
                pbBall.Top = newSpot;
                ballX = -ballX;

                if (playerScore < 5)
                {
                    ballX -= 1;
                }

                Boing();

                cpuScore++;
                lblPlayer2Score.Text = cpuScore.ToString();
            }

            // Check if the ball has exited the right side of the screen
            if (pbBall.Left + pbBall.Width > ClientSize.Width)
            {
                pbBall.Left = xMidpoint;
                pbBall.Top = newSpot;
                ballX = -ballX;

                if (playerScore < 5)
                {
                    ballX += 1;
                }

                Boing();

                playerScore++;
                lblPlayer1Score.Text = playerScore.ToString();
            }

            // Ensure the ball is within the boundaries of the screen
            if (pbBall.Top < 0 || pbBall.Top + pbBall.Height > ClientSize.Height)
            {
                ballY = -ballY;
            }

            // Check if the ball hits the player or CPU paddle
            if (pbBall.Bounds.IntersectsWith(pbPlayer1.Bounds) || pbBall.Bounds.IntersectsWith(pbPlayer2.Bounds))
            {
                // Send ball opposite direction
                ballX = -ballX;
                Boing();
            }

            // Move player up
            if (playerDetectedUp == true && pbPlayer1.Top > 0)
            {
                pbPlayer1.Top -= 10;
            }

            // Move player down
            if (playerDetectedDown == true && pbPlayer1.Top < bottomBoundary)
            {
                pbPlayer1.Top += 10;
            }

            // Check for winner
            if (playerScore >= 10)
            {
                tmrTrack.Stop();
                MessageBox.Show("Player 1 is the winner!!!");
                playerScore = 0;
                cpuScore = 0;
                FrmHome frmHome = new FrmHome();
                this.Hide();
                frmHome.Show();
            } else if (cpuScore >= 10)
            {
                tmrTrack.Stop();
                MessageBox.Show("Player 2 is the winner!!!");
                playerScore = 0;
                cpuScore = 0;
                FrmHome frmHome = new FrmHome();
                this.Hide();
                frmHome.Show();
            }
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// When the player presses a key 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOnePlayer_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = true;
            }

            // If player presses the down arrow, move paddle downwards
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = true;
            }
            if (e.KeyCode == Keys.B)
            {
                this.playerScore = 0;
                this.cpuScore = 0;
                Form home = new FrmHome();
                home.Owner = this;
                tmrTrack.Stop();
                this.Hide();
                home.Show();
            }
            // If player presses space bar, pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    tmrTrack.Stop();
                }
                else
                {
                    tmrTrack.Start();
                }
            }
            spaceBarClicked++;
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// When the player releases the key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOnePlayer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = false;
            }
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//

