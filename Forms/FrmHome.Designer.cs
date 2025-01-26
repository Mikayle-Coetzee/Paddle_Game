namespace PROG7311_ICE_1_ST10023767
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOnePlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnOnePlayer.BackgroundImage = global::PROG7311_ICE_1_ST10023767.Properties.Resources.Buttons;
            this.btnOnePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnePlayer.FlatAppearance.BorderSize = 0;
            this.btnOnePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOnePlayer.Location = new System.Drawing.Point(108, 309);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(206, 120);
            this.btnOnePlayer.TabIndex = 0;
            this.btnOnePlayer.Text = "ONE PLAYER";
            this.btnOnePlayer.UseVisualStyleBackColor = false;
            this.btnOnePlayer.Click += new System.EventHandler(this.btnOnePlayer_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTwoPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnTwoPlayer.BackgroundImage = global::PROG7311_ICE_1_ST10023767.Properties.Resources.Buttons;
            this.btnTwoPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwoPlayer.FlatAppearance.BorderSize = 0;
            this.btnTwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTwoPlayer.Location = new System.Drawing.Point(680, 309);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(206, 120);
            this.btnTwoPlayer.TabIndex = 1;
            this.btnTwoPlayer.Text = "TWO PLAYERS";
            this.btnTwoPlayer.UseVisualStyleBackColor = false;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(338, 94);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Paddle AND Pearl";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 186000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7311_ICE_1_ST10023767.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 566);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.btnOnePlayer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1009, 613);
            this.MinimumSize = new System.Drawing.Size(1009, 613);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paddle And Pearl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
    }
}

