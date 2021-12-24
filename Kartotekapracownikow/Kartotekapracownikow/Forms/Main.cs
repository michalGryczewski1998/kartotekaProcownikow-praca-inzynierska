using Kartotekapracownikow.Forms.AddEmployees;
using Kartotekapracownikow.Forms.Employees;
using Kartotekapracownikow.Forms.InternationalStaff;
using Kartotekapracownikow.Forms.Staff.DismissEmployee;
using Kartotekapracownikow.Forms.Staff.FormerEmployees;
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
            Employees form = new Employees();
            UstawieniaFormWewnatrzTabPage(form);
            
        }

        private void dodajPracownikaBTN_Click(object sender, EventArgs e)
        {
            if(AddEmployees.truOrFalseInstance)
            {
                UstawieniaFormWewnatrzTabPage(AddEmployees.Instance);
            }
        }

        private void pracownicyZagranica_Click(object sender, EventArgs e)
        {
            InternationalStaff form = new InternationalStaff();
            UstawieniaFormWewnatrzTabPage(form);
        }

        private void zwolnijPracownikaBTN_Click(object sender, EventArgs e)
        {
            DismissEmployee form = new DismissEmployee();
            UstawieniaFormWewnatrzTabPage(form);
        }

        private void byliPracownicyBTN_Click(object sender, EventArgs e)
        {
            FormerEmployees form = new FormerEmployees();
            UstawieniaFormWewnatrzTabPage(form);
        }

        private void UstawieniaFormWewnatrzTabPage(Form form)
        {
            TabPage tabPage = new TabPage();
            wyswietlanieFormsWZakladkach.Controls.Add(tabPage);
      
            tabPage.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
            wyswietlanieFormsWZakladkach.SelectedTab = tabPage;
        }
    }
}
