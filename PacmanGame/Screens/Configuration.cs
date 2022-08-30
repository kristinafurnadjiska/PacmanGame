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

namespace PacmanGame
{
    public partial class Configuration : Form
    {
        public GameConfig gameConfig { get; set; }
        public HomeForm home { get; set; }

        public bool HomeDialog { get; set; }
        public Configuration(HomeForm home)
        {
            InitializeComponent();
            gameConfig = new GameConfig(Level.Easy, 1, 0);
            cbLevel.SelectedIndex = 0;
            nudEnemie.Value = 1;
            nudPortals.Value = 0;
            nudEnemie.Enabled = false;
            nudPortals.Enabled = false;
            HomeDialog = false;

            this.home = home;
        }
         
        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel.SelectedIndex == 0)
            {
                nudEnemie.Minimum = 1;
                nudPortals.Minimum = 0;

                nudEnemie.Value = 1;
                nudPortals.Value = 0;
                nudEnemie.Enabled = false;
                nudPortals.Enabled = false;
            }
            else if (cbLevel.SelectedIndex == 1)
            {
                nudEnemie.Minimum = 2;
                nudPortals.Minimum = 2;

                nudEnemie.Value = 2;
                nudPortals.Value = 2;
                nudEnemie.Enabled = false;
                nudPortals.Enabled = false;
            }
            else
            {
                nudEnemie.Minimum = 3;
                nudPortals.Minimum = 4;
                nudEnemie.Enabled = true;
                nudPortals.Enabled = true;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   
            gameConfig = new GameConfig(getLevel(cbLevel.SelectedIndex), (int)nudEnemie.Value, (int)nudPortals.Value);
            this.Hide();
            
        }

        public Level getLevel(int index)
        {
            if (index == 0) return Level.Easy;
            if (index == 1) return Level.Medium;
            if (index == 2) return Level.Hard;   
            
            return Level.Easy;
        }
        
    }
}
