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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioYellow2.ForeColor = Color.FromName("Yellow");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RadioRed1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioRed1.Checked == true)
            {
                RadioRed1.ForeColor = Color.FromArgb(255, 0, 0);

            }
            else
            {
                RadioRed1.ForeColor = Color.FromArgb(0, 0, 0);
            }// coloring by codes
        }

        private void RadioGreen1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioGreen1.Checked == true)
            {
                RadioGreen1.ForeColor = Color.FromName("Green");
            }
            else
            {
                RadioGreen1.ForeColor = Color.FromName("Black");
            }
                // coloring by name
        }

        private void RadioBlue1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBlue1.Checked==true)
            {
                RadioBlue1.ForeColor = Color.FromArgb(0, 0, 255); 
            }
            else
            {
                RadioBlue1.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void RadioYellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioYellow1.Checked == true)
            {
                RadioYellow1.ForeColor = Color.FromName("Yellow");

            }
            else
            {
                RadioYellow1.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
           
            RadioRed1.ForeColor = Color.FromArgb(0, 0, 0);
            RadioGreen1.ForeColor = Color.FromArgb(0, 0, 0);
            RadioBlue1.ForeColor = Color.FromArgb(0, 0, 0);
            RadioYellow1.ForeColor = Color.FromArgb(0, 0, 0);
            RadioRed2.ForeColor = Color.FromArgb(0, 0, 0);
            RadioGreen2.ForeColor = Color.FromArgb(0, 0, 0);
            RadioBlue2.ForeColor = Color.FromArgb(0, 0, 0);
            RadioYellow2.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void RadioRed2_CheckedChanged(object sender, EventArgs e)
        {
            RadioRed2.ForeColor = Color.FromName("Red");
        }

        private void RadioGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RadioGreen2.ForeColor = Color.FromName("Green");
        }

        private void RadioBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RadioBlue2.ForeColor = Color.FromName("Blue");
        }
    }
}
