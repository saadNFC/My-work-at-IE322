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
    public partial class frm1 : Form
    {
        string username = "Saad";
        string myPassword = "1234";
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;

        public frm1()
        {
            
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TextUse.Text == username && TextPass.Text==myPassword)
            {
                MessageBox.Show("Success");
            }
            else
            
            {
                if (TextUse.Text != username && TextPass.Text != myPassword) 
                {
                 MessageBox.Show("incorrect username and password");
                }
                 else if (TextUse.Text != username) 
                {
                    MessageBox.Show("incorrect username ");
                }
                 else
                {
                    MessageBox.Show("incorrect password");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();              // الكود اللي تكتبه عشان اذا ضغطت على الزر يفتح لك فورم جديد
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheckBox frm = new frmCheckBox();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            frmcombo frm = new frmcombo();
            frm.ShowDialog();
           
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Math frm = new Math();
            frm.ShowDialog();


            
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            frmPicture frm = new frmPicture();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCom_Click(object sender, EventArgs e)
        {
            frmCoboRandom frm = new frmCoboRandom();
            frm.ShowDialog();
        }

        private void BtnCom_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
