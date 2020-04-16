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
    public partial class frmRandom : Form
    {
        Random y = new Random();
        Random x = new Random();
        public frmRandom()
        {
            InitializeComponent();
           
        }

        private void Random_Load(object sender, EventArgs e)
        {

        }

        private void TextRGB_Click(object sender, EventArgs e)
        {

        }

        private void BtnRN_Click(object sender, EventArgs e)
        {
            
            BtnRN.Text = Convert.ToString(y.Next(1, 100)); // y.Next(1, 100); >>> To generate a random number from 1 to 100. it has been converted to stering to able to write it in the button. 
        }                                                    // الاكواد سليمة بس فيه مشكلة في البرنامج

        private void BtnRC_Click(object sender, EventArgs e)
        {
            int r = y.Next(0,255);
            int g = y.Next(0,255);
            int b = y.Next(0,255);

            TextRGB.Text = Convert.ToString(r) + " " + Convert.ToString(g) + " " + Convert.ToString(b);
            BtnRC.ForeColor = Color.FromArgb(r,g,b);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
