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
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
           SinglePlayer sp=new SinglePlayer();
           Configuration conf=new Configuration();
           if(sp.ShowDialog() == DialogResult.OK)
           {
                GamePlayForm gpf = new GamePlayForm("SinglePlayer",conf.SelectedConfiguration);
                this.Hide();
                gpf.ShowDialog();
            }
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            Multiplayer mp=new Multiplayer();
            if(mp.ShowDialog() == DialogResult.OK)
            {
                GamePlayForm gpf = new GamePlayForm("Multiplayer", conf.SelectedConfiguration);
                this.Hide();
                gpf.ShowDialog();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuration config=new Configuration();
        }
    }
}
