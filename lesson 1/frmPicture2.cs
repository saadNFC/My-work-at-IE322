using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;             
using System.Reflection;     
using System.Windows.Forms;


namespace lesson_1
{
    public partial class frmPicture2 : Form
    {
        Assembly _assembly;
        Stream _imageStream;
        public frmPicture2()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void Form6_Load(object sender, EventArgs e)
        {

            


        }

        private void picTry_Click(object sender, EventArgs e)
        {

        }
    }
}
