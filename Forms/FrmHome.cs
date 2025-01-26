using System;
using System.Media;
using System.Windows.Forms;
using PROG7311_ICE_1_ST10023767.Forms;
using WMPLib;

namespace PROG7311_ICE_1_ST10023767
{
    public partial class FrmHome : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();   

        //Location Variables
        public int cpuDirection = 5;
        public int ballX = 5;
        public int ballY = 5;

        //Score Variables
        public int playerScore = 0;
        public int cpuScore = 0;

        //Size Variables
        public int bottomBoundary;
        public int centrePoint;
        public int xMidpoint;
        public int yMidpoint;

        // Detection Variables
        public bool playerDetectedUp;
        public bool playerDetectedDown;

        // Special Keys
        public int spaceBarClicked = 0;

        //Sound effect
        public  SoundPlayer soundEffect;

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Default constructor
        /// </summary>
        public FrmHome()
        {           
            InitializeComponent();
            player.URL = "song.mp3";

           
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// One player button that will initialize a new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            FrmOnePlayer frmOnePlayer = new FrmOnePlayer();
            this.Hide();
            frmOnePlayer.Show();
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Two player button that will initialize a new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            FrmTwoPlayers frmTwoPlayers = new FrmTwoPlayers();
            this.Hide();
            frmTwoPlayers.Show();
        }


        private void musicMethod()
        {
            player.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            musicMethod();
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//

