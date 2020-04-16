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
    public partial class Math : Form
    {
        public void NumSign(int a)
        {
            if (a > 0)
            {
                MessageBox.Show("Positive number");
                
            }
            else if (a < 0)
            {
                MessageBox.Show("Negative number");

            }
            else {
                MessageBox.Show("Zero");
            }
        }
        public Math()
        {
            InitializeComponent();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            int N1 = 0;
            int N2 = 0;
            int Result = N1 * N2;
            MessageBox.Show("");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumSign(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
