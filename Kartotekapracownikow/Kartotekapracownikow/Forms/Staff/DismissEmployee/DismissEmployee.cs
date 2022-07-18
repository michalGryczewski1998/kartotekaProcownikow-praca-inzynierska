using Kartotekapracownikow.DatabaseModel;
using Kartotekapracownikow.Forms.Staff.DismissDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.DismissEmployee
{
    public partial class DismissEmployee : Form
    {
        string imiePracownika;
        string nazwiskoPracownika;
        string kraj;
        string numerTelefonu;
        string umowa;
        string etat;
        string dzial;
        string stanowisko;
        string stawkaGodzinowa;
        string dziennyCzasPracy;
        DateTime dataRozpoczeciaPracy;

        string imieZwolnionego;


        private static DismissEmployee _instance = null;
        int employeesID;
        public static DismissEmployee Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DismissEmployee();
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

        private DismissEmployee()
        {
            InitializeComponent();
            WczytanieDanych();
        }

        private void WczytanieDanych()
        {
            using var db = new Database();
            try
            {
                var querry = (from collection in db.DanePracownikaPodstawowe
                              select new
                              {
                                  collection.ID,
                                  collection.Imie,
                                  collection.Nazwisko,
                                  collection.ImieMatki,
                                  collection.ImieOjca,
                                  collection.NumerTelefonu,
                                  collection.DataUrodzenia,
                                  collection.Miejscowosc,
                                  collection.Kraj
                              }).ToList();

                daneDGW.DataSource = querry;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas wyświetlania");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {


            using var db = new Database();
            try
            {
                var querry = (from collection in db.DanePracownikZagranicznyPodstawowes
                              select new
                              {
                                  collection.ID,
                                  collection.Imie,
                                  collection.Nazwisko,
                                  collection.ImieMatki,
                                  collection.ImieOjca,
                                  collection.TelefonKontaktowy,
                                  collection.DataUrodzenia,
                                  collection.Miejscowosc,
                                  collection.Kraj
                              }).ToList();

                daneDGW.DataSource = querry;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas wyświetlania");
            }
        }

        private void DaneDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Po kliknięciu w dany wiersz
             * zostanie przypisany do zmiennej 
             * jego ID, dzięki temu możemy 
             * wykonywac operacje.
             * 
             */

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = daneDGW.Rows[e.RowIndex];
                employeesID = (int)row.Cells["ID"].Value;
                imieZwolnionego = row.Cells["Imie"].Value.ToString();
                zaznaczonyPracownikLabel.Text = row.Cells["Imie"].Value.ToString();

                bool status;
                FiredEmployeesDetails fed;

                if (row.Cells["Kraj"].Value.ToString() == "Polska")
                {
                    status = true;
                    fed = new(employeesID, status);
                    fed.ShowDialog();
                }
                else
                {
                    status = false;
                    fed = new(employeesID, status);
                    fed.ShowDialog();
                }
            }
        }

        private void DismissEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            daneDGW.Update();
            daneDGW.Refresh();

            WczytanieDanych();
        }
    }
}
