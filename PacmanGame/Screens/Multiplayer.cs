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
    public partial class Multiplayer : Form
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public Multiplayer()
        {
            InitializeComponent();
        }

        private void tbPlayer1_Validating(object sender, CancelEventArgs e)
        {
            if (tbPlayer1.Text == "")
            {
                btnMOk.Enabled = false;
                errorProvider1.SetError(tbPlayer1, "You must enter name!!!");
            }
            else
            {

                errorProvider1.SetError(tbPlayer1, null);
            }
        }

        private void tbPlayer2_Validating(object sender, CancelEventArgs e)
        {
            if (tbPlayer2.Text == "")
            {
                btnMOk.Enabled = false;
                errorProvider1.SetError(tbPlayer2, "You must enter name!!!");
            }
            else
            {

                errorProvider1.SetError(tbPlayer2, null);
            }
        }

        private void btnMOk_Click(object sender, EventArgs e)
        {
            Player1 = tbPlayer1.Text;
            Player2 = tbPlayer2.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnMCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbPlayer1_TextChanged(object sender, EventArgs e)
        {
            if (tbPlayer1.Text != "" && tbPlayer2.Text!="")
            {
                btnMOk.Enabled = true;
            }
        }

        private void tbPlayer2_TextChanged(object sender, EventArgs e)
        {
            if (tbPlayer1.Text != "" && tbPlayer2.Text != "")
            {
                btnMOk.Enabled = true;
            }
        }
    }
}
