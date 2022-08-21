using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGame
{
    public partial class HomeForm : Form
    {
        public string player { get; set; }
        public Configuration config { get; set; }

        public SinglePlayer singlePlayer { get; set; }

        public Multiplayer multiplayer { get; set; }

        public HomeForm()
        {
            InitializeComponent();
            player = "";
            config = new Configuration(this);
            singlePlayer = new SinglePlayer();
            multiplayer = new Multiplayer();
        }
        
        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            if (singlePlayer.ShowDialog() == DialogResult.OK)
            {
                player = "SinglePlayer";
                btnPlay.Enabled = true;
            }
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            if (multiplayer.ShowDialog() == DialogResult.OK)
            {
                player = "Multiplayer";
                btnPlay.Enabled = true;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //this.Hide();
            config.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (player == "")
            {
                btnPlay.Enabled = false;
                return;
            }
            GamePlayForm gpf = null; 
            if (player == "SinglePlayer")
            {
                gpf = new GamePlayForm(config.gameConfig, new List<String> { singlePlayer.Player});

            }
            if(player == "Multiplayer")
            {
                gpf = new GamePlayForm(config.gameConfig, new List<String> {multiplayer.Player1,multiplayer.Player2});
                
            }

            if(gpf != null)
            {
                this.Hide();
                gpf.ShowDialog();
            }
            
        }
    }

}