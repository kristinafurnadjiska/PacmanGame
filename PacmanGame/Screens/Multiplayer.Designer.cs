namespace PacmanGame
{
    partial class Multiplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiplayer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.btnMOk = new System.Windows.Forms.Button();
            this.btnMCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(28, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(28, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbPlayer1.Location = new System.Drawing.Point(32, 201);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(373, 22);
            this.tbPlayer1.TabIndex = 3;
            this.tbPlayer1.TextChanged += new System.EventHandler(this.tbPlayer1_TextChanged);
            this.tbPlayer1.Validating += new System.ComponentModel.CancelEventHandler(this.tbPlayer1_Validating);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbPlayer2.Location = new System.Drawing.Point(32, 263);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(373, 22);
            this.tbPlayer2.TabIndex = 4;
            this.tbPlayer2.TextChanged += new System.EventHandler(this.tbPlayer2_TextChanged);
            this.tbPlayer2.Validating += new System.ComponentModel.CancelEventHandler(this.tbPlayer2_Validating);
            // 
            // btnMOk
            // 
            this.btnMOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMOk.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMOk.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMOk.Location = new System.Drawing.Point(32, 304);
            this.btnMOk.Name = "btnMOk";
            this.btnMOk.Size = new System.Drawing.Size(133, 38);
            this.btnMOk.TabIndex = 5;
            this.btnMOk.Text = "OK";
            this.btnMOk.UseVisualStyleBackColor = false;
            this.btnMOk.Click += new System.EventHandler(this.btnMOk_Click);
            // 
            // btnMCancel
            // 
            this.btnMCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMCancel.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMCancel.Location = new System.Drawing.Point(267, 304);
            this.btnMCancel.Name = "btnMCancel";
            this.btnMCancel.Size = new System.Drawing.Size(133, 38);
            this.btnMCancel.TabIndex = 6;
            this.btnMCancel.Text = "CANCEL";
            this.btnMCancel.UseVisualStyleBackColor = false;
            this.btnMCancel.Click += new System.EventHandler(this.btnMCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 373);
            this.Controls.Add(this.btnMCancel);
            this.Controls.Add(this.btnMOk);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Multiplayer";
            this.Text = "Multiplayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.Button btnMOk;
        private System.Windows.Forms.Button btnMCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}