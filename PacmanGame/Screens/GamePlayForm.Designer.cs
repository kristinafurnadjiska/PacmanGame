﻿namespace PacmanGame
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
            this.SuspendLayout();
            // 
            // GamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GamePlayForm";
            this.Text = "GamePlay";
            this.Load += new System.EventHandler(this.GamePlayForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePlayForm_Paint);
            this.Resize += new System.EventHandler(this.GamePlayForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}