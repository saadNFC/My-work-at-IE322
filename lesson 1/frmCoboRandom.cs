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
    public partial class frmCoboRandom : Form
    {
        Random y = new Random();
        public frmCoboRandom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            
            button1.BackColor = Color.FromArgb(r, g, b);
            this.BackColor = Color.FromArgb(255 - r, 255 - g, 255 - b);
        }
    }
}
