using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_1
{
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChCoffee.Checked == true)
            {
                msg = ChCoffee.Text;
            }
           if (ChDonut.Checked == true)
            {
                msg = msg+" "+ChDonut.Text;
            }
           if (ChBrownie.Checked == true)
            {
                msg = msg+" "+ChBrownie.Text;
            }
           if (msg.Length > 0)
            {
                MessageBox.Show(msg + " orderd");
            }
           else
            {
                MessageBox.Show("Nothing orederd");
            }

        }

        private void ChBrownie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ChCoffee_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
