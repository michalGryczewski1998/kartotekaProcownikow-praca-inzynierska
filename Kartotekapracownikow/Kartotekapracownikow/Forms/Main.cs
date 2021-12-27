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
        private TabPage tabPageEmployees;
        private TabPage tabPageDimissEmployees;
        private TabPage tabPageAddEmployees;
        private TabPage tabPageFormerEmployees;
        private TabPage tabPageInternationalStaff;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pracownikaBTN_Click(object sender, EventArgs e)
        {
            if (Employees.truOrFalseInstance)
            {
                tabPageEmployees = new TabPage();
                UstawieniaFormWewnatrzTabPage(tabPageEmployees, Employees.Instance);
            }
            else
            {
                wyswietlanieFormsWZakladkach.SelectedTab = tabPageEmployees;
            }
            
        }

        private void dodajPracownikaBTN_Click(object sender, EventArgs e)
        {
            if(AddEmployees.truOrFalseInstance)
            {
                tabPageAddEmployees = new TabPage();
                UstawieniaFormWewnatrzTabPage(tabPageAddEmployees, AddEmployees.Instance);
            }
            else
            {
                wyswietlanieFormsWZakladkach.SelectedTab = tabPageAddEmployees;
            }
        }

        private void pracownicyZagranica_Click(object sender, EventArgs e)
        {
            if (InternationalStaff.truOrFalseInstance)
            {
                tabPageInternationalStaff = new TabPage();
                UstawieniaFormWewnatrzTabPage(tabPageInternationalStaff, InternationalStaff.Instance);
            }
            else
            {
                wyswietlanieFormsWZakladkach.SelectedTab = tabPageInternationalStaff;
            }
        }

        private void zwolnijPracownikaBTN_Click(object sender, EventArgs e)
        {
            if (DismissEmployee.truOrFalseInstance)
            {
                tabPageDimissEmployees = new TabPage();
                UstawieniaFormWewnatrzTabPage(tabPageDimissEmployees, DismissEmployee.Instance);
            }
            else
            {
                wyswietlanieFormsWZakladkach.SelectedTab = tabPageDimissEmployees;
            }
        }

        private void byliPracownicyBTN_Click(object sender, EventArgs e)
        {
            if (FormerEmployees.truOrFalseInstance)
            {
                tabPageFormerEmployees = new TabPage();
                UstawieniaFormWewnatrzTabPage(tabPageFormerEmployees, FormerEmployees.Instance);
            }
            else
            {
                wyswietlanieFormsWZakladkach.SelectedTab = tabPageFormerEmployees;
            }
        }

        private void UstawieniaFormWewnatrzTabPage(TabPage tabPage, Form form)
        {
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
