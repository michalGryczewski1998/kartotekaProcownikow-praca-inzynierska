using System;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.AddEmployees
{
    public partial class AddEmployees : Form
    {
        public AddEmployees()
        {
            InitializeComponent();
            rezydenciGB.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dodanie scrollBar do panelu
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
        }

        private void nierezydentCB_CheckedChanged(object sender, EventArgs e)
        {
            if(nierezydentCB.Checked){
                rezydenciGB.Show();
            }
            else
            {
                rezydenciGB.Hide();
            }
        }

        private void numerIdLB_SelectedIndexChanged(object sender, EventArgs e){}


    }
}
