using System;
using System.Media;
using System.Windows.Forms;

namespace PROG7311_ICE_1_ST10023767.Forms
{
    public partial class FrmTwoPlayers : Form
    {
        private const int ScreenWidth = 1009;
        private const int ScreenHeight = 613;

        //Location Variables
        private int cpuDirection = 5;
        private int ballX = 5;
        private int ballY = 5;

        //Score Variables
        private int playerOneScore = 0;
        private int playerTwoScore = 0;

        //Size Variables
        private int bottomBoundary;
        private int centrePoint;
        private int xMidpoint;
        private int yMidpoint;

        // Detection Variables for player 1
        bool playerOneDetectedUp;
        bool playerOneDetectedDown;

        // Detection Variables for player 2
        bool playerTwoDetectedUp;
        bool playerTwoDetectedDown;

        // Special Keys
        int spaceBarClicked = 0;

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// default constructor
        /// </summary>
        public FrmTwoPlayers()
        {
            InitializeComponent();

            bottomBoundary = ClientSize.Height - pbPlayer1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;

            // double buffering to reduce flicker.
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
        /// When the player presses a key 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTwoPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.W)
            {
                playerOneDetectedUp = true;
            }

            // If player presses the down arrow, move paddle downwards
            if (e.KeyCode == Keys.S)
            {
                playerOneDetectedDown = true;
            }

            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up)
            {
                playerTwoDetectedUp = true;
            }

            if (e.KeyCode == Keys.B)
            {
                this.playerOneScore = 0;
                this.playerTwoScore = 0;
                Form home = new FrmHome();
                home.Owner = this;
                tmrTrack.Stop();
                this.Hide();
                home.Show();
            }

            // If player presses the down arrow, move paddle downwards
            if (e.KeyCode == Keys.Down)
            {
                playerTwoDetectedDown = true;
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
        /// When the player releases a key 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTwoPlayers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                playerOneDetectedUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                playerOneDetectedDown = false;
            }


            if (e.KeyCode == Keys.Up)
            {
                playerTwoDetectedUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerTwoDetectedDown = false;
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

            // Check if the ball has exited the left side of the screen
            if (pbBall.Left < 0)
            {
                //soundEffect.Play();
                pbBall.Left = xMidpoint;
                pbBall.Top = newSpot;
                ballX = -ballX;

                if (playerOneScore < 5)
                {
                    ballX -= 1;
                }

                Boing();

                playerTwoScore++;
                lblPlayer2Score.Text = playerTwoScore.ToString();
            }

            // Check if the ball has exited the right side of the screen
            if (pbBall.Left + pbBall.Width > ClientSize.Width)
            {
                pbBall.Left = xMidpoint;
                pbBall.Top = newSpot;
                ballX = -ballX;

                if (playerOneScore < 5)
                {
                    ballX += 1;
                }

                Boing();

                playerOneScore++;
                lblPlayer1Score.Text = playerOneScore.ToString();
            }

            // Ensure the ball is within the boundaries of the screen
            if (pbBall.Top < 0 || pbBall.Top + pbBall.Height > ClientSize.Height)
            {
                ballY = -ballY;
                Boing();
            }

            // Check if the ball hits the player or CPU paddle
            if (pbBall.Bounds.IntersectsWith(pbPlayer1.Bounds) || pbBall.Bounds.IntersectsWith(pbPlayer2.Bounds))
            {
                // Send ball opposite direction
                ballX = -ballX;
                Boing();
            }

            // Move player up
            if (playerOneDetectedUp == true && pbPlayer1.Top > 0)
            {
                pbPlayer1.Top -= 10;
            }
            // Move player up
            if (playerTwoDetectedUp == true && pbPlayer2.Top > 0)
            {
                pbPlayer2.Top -= 10;
            }

            // Move player down
            if (playerOneDetectedDown == true && pbPlayer1.Top < bottomBoundary)
            {
                pbPlayer1.Top += 10;
            }
            // Move player down
            if (playerTwoDetectedDown == true && pbPlayer2.Top < bottomBoundary)
            {
                pbPlayer2.Top += 10;
            }


            // Check for winner
            if (playerOneScore >= 10)
            {
                tmrTrack.Stop();
                MessageBox.Show("Player 1 is the winner!!!");
                playerOneScore = 0;
                playerTwoScore = 0;
                FrmHome frmHome = new FrmHome();
                this.Hide();
                frmHome.Show();
            }
            else if (playerTwoScore >= 10)
            {
                tmrTrack.Stop();
                MessageBox.Show("Player 2 is the winner!!!");
                playerOneScore = 0;
                playerTwoScore = 0;
                FrmHome frmHome = new FrmHome();
                this.Hide();
                frmHome.Show();
            }
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//

