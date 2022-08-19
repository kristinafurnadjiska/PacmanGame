using System;
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

        public GamePlayForm(GameConfig gameConfig, List<String> userNames)
        {
            InitializeComponent();
            this.Height = Constants.HEIGHT_SIZE * Constants.CELL_SIZE + 50;
            this.Width = Constants.WIDTH_SIZE * Constants.CELL_SIZE + 50;
            gameManager = new GameManager(gameConfig, userNames);
            InitializeUserTime();
            
            Invalidate(true);
            DoubleBuffered = true;

        }

        private void InitializeUserTime()
        {
            UserTimer.Interval = 200;
            UserTimer.Start();
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
            Invalidate(RegisterKeyPress(direction));
        }

        private void GamePlayForm_Load(object sender, EventArgs e)
        {

        }

        private void UserTimer_Tick(object sender, EventArgs e)
        {
            gameManager.MoveUsers();
            Invalidate(true);
            if (gameManager.CheckIfFInished())
            {
                UserTimer.Stop();
                DialogResult result = MessageBox.Show("YOU WON!", "Do you want to play another round?", MessageBoxButtons.YesNo);

                if(result == DialogResult.No)
                {
                    HomeForm home = new HomeForm();
                    this.Hide();
                    home.ShowDialog();
                }    
            }   
        }
    }
}
