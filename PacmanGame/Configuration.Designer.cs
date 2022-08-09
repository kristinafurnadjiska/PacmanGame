namespace PacmanGame
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnCOk = new System.Windows.Forms.Button();
            this.btnCCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(65, 191);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(338, 50);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(65, 264);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(338, 50);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(65, 336);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(338, 50);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnCOk
            // 
            this.btnCOk.Location = new System.Drawing.Point(65, 419);
            this.btnCOk.Name = "btnCOk";
            this.btnCOk.Size = new System.Drawing.Size(122, 44);
            this.btnCOk.TabIndex = 4;
            this.btnCOk.Text = "OK";
            this.btnCOk.UseVisualStyleBackColor = true;
            this.btnCOk.Click += new System.EventHandler(this.btnCOk_Click);
            // 
            // btnCCancel
            // 
            this.btnCCancel.Location = new System.Drawing.Point(281, 419);
            this.btnCCancel.Name = "btnCCancel";
            this.btnCCancel.Size = new System.Drawing.Size(122, 44);
            this.btnCCancel.TabIndex = 5;
            this.btnCCancel.Text = "CANCEL";
            this.btnCCancel.UseVisualStyleBackColor = true;
            this.btnCCancel.Click += new System.EventHandler(this.btnCCancel_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 502);
            this.Controls.Add(this.btnCCancel);
            this.Controls.Add(this.btnCOk);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Configuration";
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnCOk;
        private System.Windows.Forms.Button btnCCancel;
    }
}