using Kartotekapracownikow.DatabaseModel;
using Kartotekapracownikow.Forms.Staff.EmployessInfo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Employees
{
    public partial class Employees : Form
    {
        private static Employees _instance = null;

        public static Employees Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Employees();
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

        private Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dodanie scrollBar do panelu
            panelPracownicy.AutoScroll = true;
            panelPracownicy.HorizontalScroll.Enabled = false;
            panelPracownicy.HorizontalScroll.Visible = false;
            panelPracownicy.HorizontalScroll.Maximum = 0;
        }

        private void krajowiPracownicyBTN_Click(object sender, EventArgs e)
        {
            infoStatus.Text = "";

            using (var db = new Database())
            {
                try
                {
                    var querry = (from collection in db.DanePracownikaPodstawowe
                    select new
                    {
                        collection.ID,
                        collection.Imie,
                        collection.Nazwisko,
                        collection.NumerTelefonu,
                        collection.DataUrodzenia,
                        collection.Miejscowosc,
                        collection.Ulica
                    }).ToList();

                    daneDGW.DataSource = querry;
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas wyświetlania");
                }
            }           
        }

        private void daneDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pracownikID;

            int selectedRowCount = daneDGW.Rows.GetRowCount(DataGridViewElementStates.Selected);
            MessageBox.Show(selectedRowCount.ToString());

        }

        private void wyszukajBTN_Click(object sender, EventArgs e)
        {
            string nazwisko = nazwiskoPracownikaWyszukaj.Text;

            infoStatus.Text = "";
            clearDGW();

            using (var db = new Database())
            {

                try
                {
                    var querry = (from collection in db.DanePracownikaPodstawowe
                                    where collection.Nazwisko == nazwisko
                                    select new
                                    {
                                        collection.ID,
                                        collection.Imie,
                                        collection.Nazwisko,
                                        collection.NumerTelefonu,
                                        collection.DataUrodzenia,
                                        collection.Miejscowosc,
                                        collection.Ulica
                                    }).ToList();
                    daneDGW.DataSource = querry;

                    if(!querry.Any())
                    {
                        infoStatus.Text = "Nie znaleziono";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd wyszukiwania");
                }
            }
        }

        public void clearDGW()
        {
            daneDGW.DataSource = null;
            daneDGW.Rows.Clear();
            //daneDGW.DataSource = GetNewValues();
        }

        private object GetNewValues()
        {
            throw new NotImplementedException();
        }
    }
}
