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
    public partial class frmcombo : Form
    {
        public frmcombo()
        {
            InitializeComponent();
            cmbDays.Items.Add("Sunday");
            cmbDays.Items.Add("Monday");
            cmbDays.Items.Add("Tuesday");
            cmbDays.Items.Add("Wednesday");
            cmbDays.Items.Add("Thursday");
            cmbDays.Items.Add("Friday");
            cmbDays.Items.Add("Saturday");
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmcombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnRmvName_Click(object sender, EventArgs e)
        {
            cmbDays.Items.Remove("Friday");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
        }

        private void BtnRmvIndex_Click(object sender, EventArgs e)
        {
            cmbDays.Items.RemoveAt(1);
        }

        private void BtnRmvLast_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 1)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void BtnRmv2Last_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 2)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void BtnM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.Text);
        }

        private void BtnM2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(cmbDays.GetItemText(cmbDays.SelectedItem));
        }

        private void BtnM3_Click(object sender, EventArgs e)
        {
            var itemTxt = cmbDays.SelectedItem;
            MessageBox.Show(itemTxt.ToString());
        }
    }
}
