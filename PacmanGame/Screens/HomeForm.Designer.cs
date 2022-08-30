namespace PacmanGame
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.ForeColor = System.Drawing.Color.Yellow;
            this.btnSinglePlayer.Location = new System.Drawing.Point(38, 165);
            this.btnSinglePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(278, 45);
            this.btnSinglePlayer.TabIndex = 1;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMultiplayer.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnMultiplayer.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplayer.ForeColor = System.Drawing.Color.Yellow;
            this.btnMultiplayer.Location = new System.Drawing.Point(38, 226);
            this.btnMultiplayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(278, 45);
            this.btnMultiplayer.TabIndex = 5;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = false;
            this.btnMultiplayer.UseWaitCursor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Yellow;
            this.btnConfig.Location = new System.Drawing.Point(38, 288);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(278, 45);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "Configuration";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPlay.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Red;
            this.btnPlay.Location = new System.Drawing.Point(130, 388);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(90, 37);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 444);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnPlay;
    }
}