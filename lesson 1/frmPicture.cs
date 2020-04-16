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
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void BtnImagrFile_Click(object sender, EventArgs e)
        {
            picleft.Image = Image.FromFile("C:\\Users\\saadc\\Desktop\\IE322 عاطف\\saeed2.jpg");

            
            MessageBox.Show("Image file not found!");
        }

        private void picleft_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picright.Image = Image.FromFile("C:\\Users\\saadc\\Desktop\\IE322 عاطف\\Saeed.jpg");
        }
    }
}
