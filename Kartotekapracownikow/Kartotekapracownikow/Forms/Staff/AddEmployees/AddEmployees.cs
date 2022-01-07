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
            ValidateData();
        }

        private void ValidateData()
        {
            if (string.IsNullOrWhiteSpace(nazwiskoPracownikaTB.Text))
            {
                walidacjaNazwiskoEP.SetError(nazwiskoPracownikaTB, "Pole Nazwisko nie może być puste.");
            }
            else
            {
                walidacjaNazwiskoEP.Clear();
            }

            if (string.IsNullOrWhiteSpace(imiePracownikaTB.Text))
            {
                walidacjaImieEP.SetError(imiePracownikaTB, "Pole Imię nie może być puste.");
            }
            else
            {
                walidacjaImieEP.Clear();
            }
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

        private void dataUrodzinDTP_ValueChanged(object sender, EventArgs e)
        {
            dataUrodzinDTP.Format = DateTimePickerFormat.Short;
        }

        private void imiePracownikaTB_TextChanged(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void nazwiskoPracownikaTB_TextChanged(object sender, EventArgs e)
        {
            ValidateData();
        }

        private void peselTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void peselTB_Validated(object sender, EventArgs e)
        {
            string peselHelp = peselTB.Text;

            if (!string.IsNullOrWhiteSpace(peselHelp))
            {
                walidacjaPeselEP.SetError(peselTB, "Podaj prawidłową wartość PESEL");
            }
            else
            {
                walidacjaPeselEP.Clear();
            }
        }
    }
}
