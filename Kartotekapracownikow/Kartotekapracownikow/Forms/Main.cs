using Kartotekapracownikow.Forms.AddEmployees;
using Kartotekapracownikow.Forms.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pracownikaBTN_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            wyswietlanieFormsWZakladkach.Controls.Add(tabPage);

            Employees form = new Employees();
            tabPage.Text = form.Text = "Pracownicy";
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
        }

        private void dodajPracownikaBTN_Click(object sender, EventArgs e)
        {
            TabPage tabPageEmployees = new TabPage();
            wyswietlanieFormsWZakladkach.Controls.Add(tabPageEmployees);

            AddEmployees form = new AddEmployees();
            tabPageEmployees.Text = form.Text = "Dodaj";
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPageEmployees.Controls.Add(form);
        }
    }
}
