using System;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.AddEmployees
{
    public partial class AddEmployees : Form
    {

        private static AddEmployees _instance = null;

        public static AddEmployees Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddEmployees();
                }
                return _instance;
            }
        }

        public static bool truOrFalseInstance
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private AddEmployees()
        {
            InitializeComponent();
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
            if(!nierezydentCB.Checked){
                rezydenciGB.Hide();
                dodajPracownikaBTN.Show();
            }
            else
            {
                rezydenciGB.Show();
                dodajPracownikaBTN.Hide();
            }
        }

        private void dodajPracownikaBTN_Click(object sender, EventArgs e)
        {

        }

        private void anulujBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
