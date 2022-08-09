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
    public partial class Configuration : Form
    {
        public int SelectedConfiguration { get; set; } // 1-easy 2-medium 3-hard

        public Configuration()
        {
            InitializeComponent();
            this.SelectedConfiguration = 1;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            SelectedConfiguration = 1;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            SelectedConfiguration = 2;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            SelectedConfiguration = 3;
        }

        private void btnCOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
