﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacmanGame.Items;
using System.IO;
using PacmanGame.Managers;

namespace PacmanGame
{
    public partial class GamePlayForm : Form
    {
       
        public GameManager gameManager { get; set; }

        public GameConfig gameConfig { get; set; }

        public List<String> userNames { get; set; }

        public bool isStarted { get; set; }

        public GamePlayForm(GameConfig gameConfig, List<String> userNames)
        {
            InitializeComponent();
            this.gameConfig = gameConfig;
            this.userNames = userNames;
            startNewGame();
        }

        private void GamePlayForm_Paint(object sender, PaintEventArgs e)
        {
            gameManager.Draw(e.Graphics);
        }
        private bool RegisterKeyPress(Direction direction)
        {
            return gameManager.UpdateUserDirection(direction, "1");
        }


        private void GamePlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            Direction direction = Direction.NONE;
            if(e.KeyCode == Keys.A)
            {
                direction = Direction.LEFT;

            }
            if (e.KeyCode == Keys.D)
            {
                direction = Direction.RIGHT;

            }
            if (e.KeyCode == Keys.S)
            {
                direction = Direction.DOWN;

            }
            if (e.KeyCode == Keys.W)
            {
                direction = Direction.UP;
               
            }
            if(e.KeyCode == Keys.Space)
            {
                StartTimer();
            }
            Invalidate(RegisterKeyPress(direction));
        }

        private void InitializeUserTime()
        {
            UserTimer.Interval = 500;
        }

        private void UserTimer_Tick(object sender, EventArgs e)
        {
            gameManager.Move();
            UsersStatus.Text = gameManager.getStatus();
            Invalidate(true);

            checkWon();
            checkLost();
              
        }
        public void StartTimer()
        {
            if (!isStarted)
            {
                tbToStart.Visible = false;
                isStarted = true;
                UserTimer.Start();
            }
        }

        private void startNewGame()
        {
            this.Height = Constants.HEIGHT_SIZE * Constants.CELL_SIZE + 70;
            this.Width = Constants.WIDTH_SIZE * Constants.CELL_SIZE + 50;
            gameManager = new GameManager(gameConfig, userNames);
            isStarted = false;
            tbToStart.Visible = true;

            InitializeUserTime();

            Invalidate(true);
            DoubleBuffered = true;
        }

        
        public void checkWon()
        {
            if (gameManager.CheckIfFInished())
            {
                ShowFinishedDialog("YOU WON");
            }

        }

        public void checkLost()
        {
            if (gameManager.CheckIfLost())
            {
                ShowFinishedDialog("YOU LOST");
            }
        }

        public void ShowFinishedDialog(String message)
        {
            UserTimer.Stop();
            DialogResult result = MessageBox.Show(message, "Do you want to play another round?", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                HomeForm home = new HomeForm();
                this.Hide();
                home.ShowDialog();
            }
            if (result == DialogResult.Yes)
            {
                startNewGame();
            }
        }
    }
}
