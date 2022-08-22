namespace PacmanGame
{
    partial class GamePlayForm
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
            this.UserTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UsersStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbToStart = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTimer
            // 
            this.UserTimer.Tick += new System.EventHandler(this.UserTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UsersStatus
            // 
            this.UsersStatus.Name = "UsersStatus";
            this.UsersStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // lbToStart
            // 
            this.lbToStart.AutoSize = true;
            this.lbToStart.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbToStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbToStart.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToStart.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbToStart.Location = new System.Drawing.Point(153, 104);
            this.lbToStart.Name = "lbToStart";
            this.lbToStart.Size = new System.Drawing.Size(352, 38);
            this.lbToStart.TabIndex = 2;
            this.lbToStart.Text = "Press space to start";
            // 
            // GamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbToStart);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GamePlayForm";
            this.Text = "GamePlay";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePlayForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlayForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UserTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsersStatus;
        private System.Windows.Forms.Label lbToStart;
    }
}