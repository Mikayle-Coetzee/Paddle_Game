namespace PROG7311_ICE_1_ST10023767.UserControls
{
    partial class UCOnePlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.tmrTrack = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(347, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Score";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(394, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPlayer2Score.Location = new System.Drawing.Point(435, 59);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(38, 42);
            this.lblPlayer2Score.TabIndex = 11;
            this.lblPlayer2Score.Text = "0";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPlayer1Score.Location = new System.Drawing.Point(347, 59);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(38, 42);
            this.lblPlayer1Score.TabIndex = 10;
            this.lblPlayer1Score.Text = "0";
            // 
            // pbBall
            // 
            this.pbBall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.BackgroundImage = global::PROG7311_ICE_1_ST10023767.Properties.Resources.pearl1;
            this.pbBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBall.Location = new System.Drawing.Point(392, 216);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(32, 33);
            this.pbBall.TabIndex = 9;
            this.pbBall.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer1.BackgroundImage = global::PROG7311_ICE_1_ST10023767.Properties.Resources.Player1;
            this.pbPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer1.Location = new System.Drawing.Point(46, 173);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(93, 127);
            this.pbPlayer1.TabIndex = 8;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer2.BackgroundImage = global::PROG7311_ICE_1_ST10023767.Properties.Resources.Player2;
            this.pbPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer2.Location = new System.Drawing.Point(663, 173);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(86, 127);
            this.pbPlayer2.TabIndex = 7;
            this.pbPlayer2.TabStop = false;
            // 
            // tmrTrack
            // 
            this.tmrTrack.Interval = 15;
            this.tmrTrack.Tick += new System.EventHandler(this.tmrTrack_Tick_1);
            // 
            // UCOnePlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PROG7311_ICE_1_ST10023767.Properties.Resources.Ocean;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.pbPlayer2);
            this.Name = "UCOnePlayer";
            this.Size = new System.Drawing.Size(800, 504);
            this.Load += new System.EventHandler(this.UCOnePlayer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCOnePlayer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UCOnePlayer_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Timer tmrTrack;
    }
}
