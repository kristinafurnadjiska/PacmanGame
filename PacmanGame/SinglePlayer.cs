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
    public partial class SinglePlayer : Form
    {
        public string Name { get; set; }
        public SinglePlayer()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text == "")
            {
                btnOk.Enabled = false;
                errorProvider1.SetError(tbName, "You must enter name!!!");
            }
            else
            {
                errorProvider1.SetError(tbName, null);  
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Name = tbName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                btnOk.Enabled=true;
            }
            
        }
    }
}
