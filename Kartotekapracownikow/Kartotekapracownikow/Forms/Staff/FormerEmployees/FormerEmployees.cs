using Kartotekapracownikow.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.FormerEmployees
{
    public partial class FormerEmployees : Form
    {

        private static FormerEmployees _instance = null;

        int employeesID;
        string imieZwolnionego;

        public static FormerEmployees Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FormerEmployees();
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

        private FormerEmployees()
        {
            InitializeComponent();
            DaneZwolnieniPracownicyWyswietl();      
        }

        private void FormerEmployees_Load(object sender, EventArgs e)
        {

        }

        private void DaneZwolnieniPracownicyWyswietl()
        {
            using(var db = new Database())
            {
                try
                {
                    var query = (from collection in db.ZwolnieniPracownicy
                                 select new
                                 {
                                     collection.ID,
                                     collection.Imie,
                                     collection.Nazwisko,
                                     collection.Kraj,
                                     collection.NumerTelefonu,
                                     collection.Dzial,
                                     collection.Stanowisko,
                                     collection.DataRozpoczeciaPracy,
                                     collection.DataZakonczeniaPracy
                                 }).ToList();

                    DaneZwolnienieDGW.DataSource = query;
                }
                catch(Exception)
                {
                    MessageBox.Show("Błąd podczas pobierania danych o zwolnionych pracownikach");
                }
            }
        }

        private void DaneZwolnienieDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DaneZwolnienieDGW.Rows[e.RowIndex];
                    employeesID = (int)row.Cells["ID"].Value;
                    imieZwolnionego = row.Cells["Imie"].Value.ToString();
                    zaznaczonyPracownikLabel.Text = row.Cells["Imie"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas pobierania danych o zwolnionych pracownikach");
            }

        }
    }
}
